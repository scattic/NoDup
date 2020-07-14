using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

using Microsoft.VisualBasic.FileIO;

/*
 * The algorithm:
 * - create list of files with the attributes as selected in the window
 * - create aonther list holding unique AttribHashes 
 * - for each unique AttribHashes
 * -- find the entries with that AttribHash
 * -- group them (assign GroupID)
 */

namespace NoDup
{

    public partial class frmMain : Form
    {

        private List<DupFile> DupFiles = new List<DupFile>();
        private int GroupsCount;
        private long WastedSpace;
        private long RecoveredSpace;

        private void CreateListOfFiles(string path)
        {
            //var DupFiles = new List<DupFile>();

            DirectoryInfo root = new DirectoryInfo(path);
            if(!root.Exists)
            {
                MessageBox.Show("Cannot find the folder specified. Use the 'Select a folder' button to pick a folder to scan, or review the text in the text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var folders = new List<DirectoryInfo>();
            var tdir = new Queue<string>();

            tdir.Enqueue(path);

            this.label4.Visible = true;
            this.pbrProgress.Visible = false; 

            while (tdir.Count>0)
            {
                var current_folder = new DirectoryInfo(tdir.Peek());

                folders.Add(current_folder);

                this.label4.Text = current_folder.FullName;
                Application.DoEvents();
                 
                tdir.Dequeue();
                // get list of child folders if any 
                DirectoryInfo[] tchil = { };
                try
                {
                    tchil = current_folder.GetDirectories("*", System.IO.SearchOption.TopDirectoryOnly);

                }
                catch
                {
                    // we might fail if we cannot read the current_folder folder (due to permissions for example)
                    //TODO: save these folders and show them
                }
                if(tchil.Length>0)
                {
                    foreach(DirectoryInfo tc in tchil) {
                        tdir.Enqueue(tc.FullName);
                    }
                } 

            }

            this.label4.Visible = false;
            this.pbrProgress.Visible = true;

            // then in all directories from that list
            int i = 0;
            int progress = 0;
            foreach (DirectoryInfo f in folders)
            {
                i++;
                progress = (i * 100) / folders.Count;
                pbrProgress.Value = progress;
                Application.DoEvents();
                FileInfo[] files = { };
                try
                {
                   files = f.GetFiles();
                }
                catch
                {
                    // sometimes we just cannot list the files... no biggie 
                }

                foreach (FileInfo ff in files) {
                    DupFile temp2 = new NoDup.DupFile();
                    temp2.Name = ff.Name;
                    temp2.Path = ff.DirectoryName;
                    temp2.Size = ff.Length; // in bytes
                    temp2.Created = ff.CreationTimeUtc;
                    temp2.Modified = ff.LastWriteTimeUtc;
                    temp2.ComputeHash(chkNames.Checked, chkSizes.Checked, chkDates.Checked, chkContents.Checked);
                    DupFiles.Add(temp2);
                }
                 
            }
            
        }

        private void GroupDuplicates()
        {
            /*
             compare all entries and when finding a match create a new group or add to existing group
             */

            int LastGroup = 1;
            int progress = 0;

            WastedSpace = 0;

            for (int i=0;i<DupFiles.Count;i++)
            {
                progress = (i * 100) / DupFiles.Count;
                pbrProgress.Value = progress;
                Application.DoEvents();

                if (DupFiles[i].Group != 0) continue; // this entry has been groupped already, skip it

                for (int j=i+1;j<DupFiles.Count;j++)
                {
                    if(DupFiles[i].AttribHash == DupFiles[j].AttribHash) // we have a match
                    {
                        if(DupFiles[i].Group==0) // create a new group
                        {
                            DupFiles[j].Group = DupFiles[i].Group = LastGroup++;
                            WastedSpace += DupFiles[j].Size;
                        }
                        else // we have a secondary.. match 
                        {
                            if (DupFiles[j].Group == 0)
                            {
                                DupFiles[j].Group = DupFiles[i].Group;
                                WastedSpace += DupFiles[j].Size;
                            }
                        }
                    }
                }
            }

            GroupsCount = LastGroup;
        }

        private void UpdateResultsListBox()
        {
            /*
             * "moves" items from the list of DupFiles into the ListView
             * should display the columns based on which the comparison was made
             */
            foreach(DupFile df in DupFiles)
            {
                if (df.Group > 0)
                {
                    ListViewItem item = new ListViewItem(new string[] { df.Group.ToString(), df.Name, df.Path, df.Size.ToString(), df.Created.ToString(), df.Modified.ToString(), "N" });
                    lvDuplicates.Items.Add(item);
                    // so we now free memory? maybe we don't do this in case we need to rescan!!?
                }
            }

        }

        private void EnableStart()
        {
            if (txtFolderName.Text.Length >= 3) {
                btnStart.Enabled = true;
            }
            else {
                btnStart.Enabled = false;
                return; 
            }
            if ((chkNames.Checked == true) ||
                (chkSizes.Checked == true) ||
                (chkDates.Checked == true) ||
                (chkContents.Checked == true))
            {
                btnStart.Enabled = true;
            }
            else { btnStart.Enabled = false; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void SetFileAction(bool ActionDelete, bool AllFromFolder) {
            // check size of selection first
            if(lvDuplicates.SelectedItems.Count == 0)
            {
                MessageBox.Show("No files selected. Please select some files first using the checkboxes next to the Group ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach(int i in lvDuplicates.SelectedIndices)
            {
                if(AllFromFolder)
                {
                    string strFolder = lvDuplicates.Items[i].SubItems[2].Text;
                    foreach(ListViewItem lvi in lvDuplicates.Items)
                    {
                        if(lvi.SubItems[2].Text == strFolder)
                        {
                            lvi.SubItems[6].Text = (ActionDelete == true ? "Y" : "N");
                            lvi.BackColor = (ActionDelete == true ? Color.Red : Color.White);
                        }
                    }
                }
                else
                {
                    lvDuplicates.Items[i].SubItems[6].Text = (ActionDelete==true ? "Y" : "N");
                    lvDuplicates.Items[i].BackColor = (ActionDelete == true ? Color.Red : Color.White);
                }
            }
            RecoveredSpace = 0;
            foreach (ListViewItem lvi in lvDuplicates.Items)
            {
                if (lvi.SubItems[6].Text == "Y") RecoveredSpace += Int32.Parse(lvi.SubItems[3].Text);
            }
            lblReclaimed.Text = "To be reclaimed: " + (RecoveredSpace / 1024 / 1024).ToString() + "MB";
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            dlgPickFolder.ShowDialog();
            txtFolderName.Text = dlgPickFolder.SelectedPath;
            EnableStart();

            chkNames.Enabled = true;
            chkSizes.Enabled = true;
            chkContents.Enabled = true;
            chkDates.Enabled = true;
        }

        private void txtFolderName_TextChanged(object sender, EventArgs e)
        {
            EnableStart();
        }

        private void chkNames_CheckedChanged(object sender, EventArgs e)
        {
            EnableStart();
        }

        private void chkSizes_CheckedChanged(object sender, EventArgs e)
        {
            EnableStart();
        }

        private void chkDates_CheckedChanged(object sender, EventArgs e)
        {
            EnableStart();
        }

        private void chkContents_CheckedChanged(object sender, EventArgs e)
        {
            EnableStart();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lvDuplicates.Items.Clear();
            if (DupFiles != null)
            {
                DupFiles.Clear();
            }

            lblFilesCount.Text = "Duplicate files: 0";
            lblReclaimed.Text = "To be reclaimed: 0 b";
            lblWasted.Text = "Waisted space: 0 b";

            btnSelectFolder.Enabled = false;
            btnStart.Enabled = false;

            pbrProgress.Visible = true;
            pbrProgress.Value = 0;

            CreateListOfFiles(txtFolderName.Text);
            GroupDuplicates();
            UpdateResultsListBox();

            lblFilesCount.Text = "Duplicate files: " + lvDuplicates.Items.Count.ToString();
            lblWasted.Text = "Wasted space: " + (WastedSpace / 1024 / 1024).ToString() + "MB";

            btnKeepAll.Enabled = true;
            btnKeepSel.Enabled = true;
            btnDelSel.Enabled = true;
            btnDelAll.Enabled = true;
            btnDeleteDuplicates.Enabled = true;
            btnExplore.Enabled = true;

            chkNames.Enabled = false;
            chkSizes.Enabled = false;
            chkContents.Enabled = false;
            chkDates.Enabled = false;

            pbrProgress.Visible = false;
            btnSelectFolder.Enabled = true;
            btnStart.Enabled = true;
        }

        private void lvDuplicates_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.lvDuplicates.ListViewItemSorter = new ListViewItemComparer(e.Column);
            this.lvDuplicates.Sort();
        }

        private void btnKeepSel_Click(object sender, EventArgs e)
        {
            SetFileAction(false, false);
        }

        private void btnDelSel_Click(object sender, EventArgs e)
        {
            SetFileAction(true, false);
        }

        private void btnKeepAll_Click(object sender, EventArgs e)
        {
            SetFileAction(false, true);
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            SetFileAction(true, true);
        }

        private void btnDeleteDuplicates_Click(object sender, EventArgs e)
        {
            // first, make sure that there is at least one left of every file

            bool SavedOneKindOfEach = false;

            for (int i=1;i<GroupsCount;i++)
            {
                int NonMarkedFilesInGroup = 0;
                ListViewItem backup =null;

                foreach (ListViewItem lvi in lvDuplicates.Items)
                {
                    if (lvi.SubItems[0].Text == i.ToString())
                    {
                        backup = lvi;
                        if (lvi.SubItems[6].Text == "N")
                        {
                            NonMarkedFilesInGroup++; //are there any files with this name saved?
                        }
                  
                    }
                }

                if(NonMarkedFilesInGroup==0) // this is wrong, we are deleting data forever... no
                {
                    if (backup != null) {
                        backup.SubItems[6].Text = "N";
                        backup.BackColor = Color.Yellow;
                        RecoveredSpace -= Int32.Parse(backup.SubItems[3].Text);
                        lblReclaimed.Text = "To be reclaimed: " + (RecoveredSpace / 1024 / 1024).ToString() + "MB";
                        SavedOneKindOfEach = true;
                    }
                }
            }

            if (SavedOneKindOfEach)
            {
                MessageBox.Show("Because for some files ALL copies were found marked for deletion, the program automatically saved one of the files to prevent data loss (yellow highlight). Please review these fixes before continuing.", "Data loss prevented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // now we can delete

            foreach (ListViewItem lvi in lvDuplicates.Items)
            {
                if (lvi.SubItems[6].Text == "Y")
                {
                    string fullpath= lvi.SubItems[2].Text + "\\"+ lvi.SubItems[1].Text;
                    try
                    {
                        FileSystem.DeleteFile(fullpath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        // also remove from statistics and from the list if deleted successfuly 
                        lvi.Remove();
                        lblFilesCount.Text = "Duplicate files: " + lvDuplicates.Items.Count.ToString();
                        RecoveredSpace -= Int32.Parse(lvi.SubItems[3].Text);
                        WastedSpace -= Int32.Parse(lvi.SubItems[3].Text);
                        lblWasted.Text = "Wasted space: " + (WastedSpace / 1024 / 1024).ToString() + "MB";
                        lblReclaimed.Text = "To be reclaimed: " + (RecoveredSpace / 1024 / 1024).ToString() + "MB";
                        Application.DoEvents();
                    }
                    catch
                    {
                        MessageBox.Show("Cannot delete file: "+fullpath+". Try running the program as Administrator, checking file system permissions, or open files/applications.","Error deleting file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show("All selected duplicate files have been sent to Recycle Bin.", "Duplicates removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            Process.Start(lvDuplicates.SelectedItems[0].SubItems[2].Text);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // shoud we ask something if operation is in progress?
        }

    }

    //----------------------------------------------------------------

    class ListViewItemComparer : IComparer
    {
        private int col;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
            ((ListViewItem)y).SubItems[col].Text);
            return returnVal;
        }
    }

}
