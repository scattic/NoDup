namespace NoDup
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chkContents = new System.Windows.Forms.CheckBox();
            this.chkDates = new System.Windows.Forms.CheckBox();
            this.chkSizes = new System.Windows.Forms.CheckBox();
            this.chkNames = new System.Windows.Forms.CheckBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvDuplicates = new System.Windows.Forms.ListView();
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Delete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExplore = new System.Windows.Forms.Button();
            this.btnDeleteDuplicates = new System.Windows.Forms.Button();
            this.lblReclaimed = new System.Windows.Forms.Label();
            this.lblWasted = new System.Windows.Forms.Label();
            this.lblFilesCount = new System.Windows.Forms.Label();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnKeepAll = new System.Windows.Forms.Button();
            this.btnDelSel = new System.Windows.Forms.Button();
            this.btnKeepSel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgPickFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbrProgress);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.chkContents);
            this.panel1.Controls.Add(this.chkDates);
            this.panel1.Controls.Add(this.chkSizes);
            this.panel1.Controls.Add(this.chkNames);
            this.panel1.Controls.Add(this.btnSelectFolder);
            this.panel1.Controls.Add(this.txtFolderName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 93);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "<FOLDER>";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label3.Size = new System.Drawing.Size(74, 43);
            this.label3.TabIndex = 10;
            this.label3.Text = "NoDup";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(706, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(68, 93);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pbrProgress
            // 
            this.pbrProgress.Location = new System.Drawing.Point(300, 58);
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(226, 23);
            this.pbrProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrProgress.TabIndex = 8;
            this.pbrProgress.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ImageKey = "folder-sync.ico";
            this.btnStart.ImageList = this.imageList1;
            this.btnStart.Location = new System.Drawing.Point(416, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 26);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start scan";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document-open-folder.ico");
            this.imageList1.Images.SetKeyName(1, "edit-delete-2.ico");
            this.imageList1.Images.SetKeyName(2, "edit-delete-5.ico");
            this.imageList1.Images.SetKeyName(3, "folder-sync.ico");
            this.imageList1.Images.SetKeyName(4, "table-cell-delete.ico");
            this.imageList1.Images.SetKeyName(5, "view-list-tree-4.ico");
            // 
            // chkContents
            // 
            this.chkContents.AutoSize = true;
            this.chkContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkContents.Location = new System.Drawing.Point(124, 71);
            this.chkContents.Name = "chkContents";
            this.chkContents.Size = new System.Drawing.Size(112, 17);
            this.chkContents.TabIndex = 6;
            this.chkContents.Text = "Compare contents";
            this.chkContents.UseVisualStyleBackColor = true;
            this.chkContents.CheckedChanged += new System.EventHandler(this.chkContents_CheckedChanged);
            // 
            // chkDates
            // 
            this.chkDates.AutoSize = true;
            this.chkDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDates.Location = new System.Drawing.Point(124, 48);
            this.chkDates.Name = "chkDates";
            this.chkDates.Size = new System.Drawing.Size(97, 17);
            this.chkDates.TabIndex = 5;
            this.chkDates.Text = "Compare dates";
            this.chkDates.UseVisualStyleBackColor = true;
            this.chkDates.CheckedChanged += new System.EventHandler(this.chkDates_CheckedChanged);
            // 
            // chkSizes
            // 
            this.chkSizes.AutoSize = true;
            this.chkSizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSizes.Location = new System.Drawing.Point(5, 70);
            this.chkSizes.Name = "chkSizes";
            this.chkSizes.Size = new System.Drawing.Size(94, 17);
            this.chkSizes.TabIndex = 4;
            this.chkSizes.Text = "Compare sizes";
            this.chkSizes.UseVisualStyleBackColor = true;
            this.chkSizes.CheckedChanged += new System.EventHandler(this.chkSizes_CheckedChanged);
            // 
            // chkNames
            // 
            this.chkNames.AutoSize = true;
            this.chkNames.Checked = true;
            this.chkNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNames.Location = new System.Drawing.Point(5, 48);
            this.chkNames.Name = "chkNames";
            this.chkNames.Size = new System.Drawing.Size(102, 17);
            this.chkNames.TabIndex = 3;
            this.chkNames.Text = "Compare names";
            this.chkNames.UseVisualStyleBackColor = true;
            this.chkNames.CheckedChanged += new System.EventHandler(this.chkNames_CheckedChanged);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.ImageKey = "document-open-folder.ico";
            this.btnSelectFolder.ImageList = this.imageList1;
            this.btnSelectFolder.Location = new System.Drawing.Point(300, 23);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(110, 26);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Select a folder";
            this.btnSelectFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.Location = new System.Drawing.Point(5, 25);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(287, 20);
            this.txtFolderName.TabIndex = 1;
            this.txtFolderName.TextChanged += new System.EventHandler(this.txtFolderName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step 1 - Select the folder you wish to scan for duplicates and the matching optio" +
    "ns:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvDuplicates);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 289);
            this.panel2.TabIndex = 1;
            // 
            // lvDuplicates
            // 
            this.lvDuplicates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDuplicates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Group,
            this.FileName,
            this.Path,
            this.Size,
            this.Created,
            this.Modified,
            this.Delete});
            this.lvDuplicates.FullRowSelect = true;
            this.lvDuplicates.GridLines = true;
            this.lvDuplicates.Location = new System.Drawing.Point(5, 19);
            this.lvDuplicates.Name = "lvDuplicates";
            this.lvDuplicates.Size = new System.Drawing.Size(595, 265);
            this.lvDuplicates.TabIndex = 3;
            this.lvDuplicates.UseCompatibleStateImageBehavior = false;
            this.lvDuplicates.View = System.Windows.Forms.View.Details;
            this.lvDuplicates.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvDuplicates_ColumnClick);
            // 
            // Group
            // 
            this.Group.Text = "Group";
            this.Group.Width = 50;
            // 
            // FileName
            // 
            this.FileName.Text = "Name";
            this.FileName.Width = 150;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 150;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 70;
            // 
            // Created
            // 
            this.Created.Text = "Created";
            // 
            // Modified
            // 
            this.Modified.Text = "Modified";
            // 
            // Delete
            // 
            this.Delete.Text = "Delete?";
            this.Delete.Width = 50;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExplore);
            this.panel3.Controls.Add(this.btnDeleteDuplicates);
            this.panel3.Controls.Add(this.lblReclaimed);
            this.panel3.Controls.Add(this.lblWasted);
            this.panel3.Controls.Add(this.lblFilesCount);
            this.panel3.Controls.Add(this.btnDelAll);
            this.panel3.Controls.Add(this.btnKeepAll);
            this.panel3.Controls.Add(this.btnDelSel);
            this.panel3.Controls.Add(this.btnKeepSel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(608, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 289);
            this.panel3.TabIndex = 2;
            // 
            // btnExplore
            // 
            this.btnExplore.Enabled = false;
            this.btnExplore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplore.ImageKey = "view-list-tree-4.ico";
            this.btnExplore.ImageList = this.imageList1;
            this.btnExplore.Location = new System.Drawing.Point(3, 134);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(160, 26);
            this.btnExplore.TabIndex = 8;
            this.btnExplore.Text = "Open Explorer here";
            this.btnExplore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnDeleteDuplicates
            // 
            this.btnDeleteDuplicates.Enabled = false;
            this.btnDeleteDuplicates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDuplicates.ImageKey = "edit-delete-2.ico";
            this.btnDeleteDuplicates.ImageList = this.imageList1;
            this.btnDeleteDuplicates.Location = new System.Drawing.Point(3, 255);
            this.btnDeleteDuplicates.Name = "btnDeleteDuplicates";
            this.btnDeleteDuplicates.Size = new System.Drawing.Size(160, 26);
            this.btnDeleteDuplicates.TabIndex = 7;
            this.btnDeleteDuplicates.Text = "Delete duplicates";
            this.btnDeleteDuplicates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteDuplicates.UseVisualStyleBackColor = true;
            this.btnDeleteDuplicates.Click += new System.EventHandler(this.btnDeleteDuplicates_Click);
            // 
            // lblReclaimed
            // 
            this.lblReclaimed.AutoSize = true;
            this.lblReclaimed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReclaimed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReclaimed.Location = new System.Drawing.Point(3, 230);
            this.lblReclaimed.Name = "lblReclaimed";
            this.lblReclaimed.Size = new System.Drawing.Size(102, 13);
            this.lblReclaimed.TabIndex = 6;
            this.lblReclaimed.Text = "To be reclaimed:";
            // 
            // lblWasted
            // 
            this.lblWasted.AutoSize = true;
            this.lblWasted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWasted.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWasted.Location = new System.Drawing.Point(3, 207);
            this.lblWasted.Name = "lblWasted";
            this.lblWasted.Size = new System.Drawing.Size(92, 13);
            this.lblWasted.TabIndex = 5;
            this.lblWasted.Text = "Wasted space:";
            // 
            // lblFilesCount
            // 
            this.lblFilesCount.AutoSize = true;
            this.lblFilesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFilesCount.Location = new System.Drawing.Point(3, 184);
            this.lblFilesCount.Name = "lblFilesCount";
            this.lblFilesCount.Size = new System.Drawing.Size(92, 13);
            this.lblFilesCount.TabIndex = 4;
            this.lblFilesCount.Text = "Duplicate files:";
            // 
            // btnDelAll
            // 
            this.btnDelAll.Enabled = false;
            this.btnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAll.ImageKey = "table-cell-delete.ico";
            this.btnDelAll.ImageList = this.imageList1;
            this.btnDelAll.Location = new System.Drawing.Point(3, 105);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(160, 26);
            this.btnDelAll.TabIndex = 3;
            this.btnDelAll.Text = "Delete all from folder";
            this.btnDelAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnKeepAll
            // 
            this.btnKeepAll.Enabled = false;
            this.btnKeepAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeepAll.ImageList = this.imageList1;
            this.btnKeepAll.Location = new System.Drawing.Point(3, 76);
            this.btnKeepAll.Name = "btnKeepAll";
            this.btnKeepAll.Size = new System.Drawing.Size(160, 26);
            this.btnKeepAll.TabIndex = 2;
            this.btnKeepAll.Text = "Keep all from folder";
            this.btnKeepAll.UseVisualStyleBackColor = true;
            this.btnKeepAll.Click += new System.EventHandler(this.btnKeepAll_Click);
            // 
            // btnDelSel
            // 
            this.btnDelSel.Enabled = false;
            this.btnDelSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSel.ImageKey = "edit-delete-5.ico";
            this.btnDelSel.ImageList = this.imageList1;
            this.btnDelSel.Location = new System.Drawing.Point(3, 47);
            this.btnDelSel.Name = "btnDelSel";
            this.btnDelSel.Size = new System.Drawing.Size(160, 26);
            this.btnDelSel.TabIndex = 1;
            this.btnDelSel.Text = "Delete selected";
            this.btnDelSel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelSel.UseVisualStyleBackColor = true;
            this.btnDelSel.Click += new System.EventHandler(this.btnDelSel_Click);
            // 
            // btnKeepSel
            // 
            this.btnKeepSel.Enabled = false;
            this.btnKeepSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeepSel.ImageList = this.imageList1;
            this.btnKeepSel.Location = new System.Drawing.Point(3, 18);
            this.btnKeepSel.Name = "btnKeepSel";
            this.btnKeepSel.Size = new System.Drawing.Size(160, 26);
            this.btnKeepSel.TabIndex = 0;
            this.btnKeepSel.Text = "Keep selected";
            this.btnKeepSel.UseVisualStyleBackColor = true;
            this.btnKeepSel.Click += new System.EventHandler(this.btnKeepSel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Step 2 - Review the list of duplicates and decide the appropriate action:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 382);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "NoDup v0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkContents;
        private System.Windows.Forms.CheckBox chkDates;
        private System.Windows.Forms.CheckBox chkSizes;
        private System.Windows.Forms.CheckBox chkNames;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FolderBrowserDialog dlgPickFolder;
        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnKeepAll;
        private System.Windows.Forms.Button btnDelSel;
        private System.Windows.Forms.Button btnKeepSel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteDuplicates;
        private System.Windows.Forms.Label lblReclaimed;
        private System.Windows.Forms.Label lblWasted;
        private System.Windows.Forms.Label lblFilesCount;
        private System.Windows.Forms.ListView lvDuplicates;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Delete;
        private System.Windows.Forms.ColumnHeader Created;
        private System.Windows.Forms.ColumnHeader Modified;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
    }
}

