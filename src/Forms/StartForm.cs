using System.Windows.Forms;

namespace Program.Forms
{
    public partial class StartForm : Form
    {
        
       // public static MainForm MainForm { get; set; }
        public StartForm()
        {
            InitializeComponent();
            //MainForm = new MainForm();
        }

        private void devBut_MouseClick(object sender, MouseEventArgs e)
        {
            var developersForm = new DevelopersForm();
            developersForm.Show();
            Hide();
        }

        private void startBut_MouseClick(object sender, MouseEventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
    }
}