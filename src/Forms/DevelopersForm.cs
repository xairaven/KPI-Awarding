using System.Windows.Forms;

namespace Program.Forms
{
    public partial class DevelopersForm : Form
    {
        public DevelopersForm()
        {
            InitializeComponent();
            AddInfo();
        }

        private void AddInfo()
        {
            dataDev.Rows.Add("Владислав", "Каркушевський", "@vlad_karkushevskiy","Desktop Developer");
            dataDev.Rows.Add("Артем", "Діковський", "@UncleFitz","Database Engineer");
            dataDev.Rows.Add("Олександр", "Ковальов", "@xairaven","DevOps");
            dataDev.Rows.Add("Єлизавета", "Дреля", "@liza_drelya","Frontend, Design");
            dataDev.Rows.Add("Данило", "Жуковський", "@Etherwoood","Frontend");
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            var startForm = new StartForm();
            startForm.Show();
            Hide();
        }
    }
}