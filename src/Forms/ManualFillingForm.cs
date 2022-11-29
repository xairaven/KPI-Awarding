using System.Windows.Forms;

namespace Program.Forms
{
    public partial class ManualFillingForm : Form
    {
        public ManualFillingForm()
        {
            InitializeComponent();

          
        }


        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                @"Якщо ви вийдете, ви втратите всі дані.
Ви впевнені?", 
                "", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2, 
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                var changeDataUploadForm = new ChangeDataUploadForm();
                changeDataUploadForm.TopMost = true;
                changeDataUploadForm.Show();
                changeDataUploadForm.TopMost = false;

                Hide();
            }
            else
            {
                TopMost = true;
                TopMost = false;
            }        



        }
    }
 

}