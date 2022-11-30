using System.Windows.Forms;

namespace Program.Forms
{
    public partial class AddPersonForm : Form
    {
        public AddPersonForm()
        {
            InitializeComponent();
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            StartForm.MainForm.Show();
            Hide();
        }
    }
}