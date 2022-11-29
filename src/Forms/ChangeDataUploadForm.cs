using System.Windows.Forms;

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
            
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            Hide();
        }
    }
}