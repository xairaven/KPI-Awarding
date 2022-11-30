using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Program.Forms
{
    public partial class ChangeDataUploadForm : Form
    {
        public ChangeDataUploadForm()
        {
            InitializeComponent();
        }

        private void manuallyBut_MouseClick(object sender, MouseEventArgs e)
        {
            var manualFillingForm = new ManualFillingForm();
            manualFillingForm.Show();
            Hide();
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            var startForm = new StartForm();
            startForm.Show();
            Hide();
        }

        private void excelBut_MouseClick(object sender, MouseEventArgs e)
        {

            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }

    }
}