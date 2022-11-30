using System.Windows.Forms;

namespace Program.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            var changeDataUploadForm = new ChangeDataUploadForm();
            changeDataUploadForm.Show();
            Hide();
        }
    }
}