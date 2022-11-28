using System.Windows.Forms;

namespace Program.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void devBut_MouseClick(object sender, MouseEventArgs e)
        {
            DevelopersForm developersForm = new DevelopersForm();
            developersForm.Show();
            Hide();
        }
    }
}