using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NoDup
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            frmMain fm = new frmMain();
            //fs.Height = 180;
            Application.Run(fm);
        }
    }
}
