using System;
using System.Windows.Forms;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FormUtils.SetDefaultIcon();

            Application.Run(new StartForm());
            Application.Exit();
        }
    }
}