using System;
using System.Windows.Forms;
using Program.DataBase;
using Program.Forms;

namespace Program
{
    static class Startup
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataWork.RunDB();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FormUtils.SetDefaultIcon();

            Application.Run(new StartForm());
            Application.Exit();

            
        }
    }
}