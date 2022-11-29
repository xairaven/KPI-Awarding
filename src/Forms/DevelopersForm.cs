using System.Windows.Forms;

namespace Program.Forms
{
    public partial class DevelopersForm : Form
    {
        public DevelopersForm()
        {
            InitializeComponent();
            addInfo();
        }

        private void addInfo()
        {
            dataDev.Rows.Add("Владислав", "Каркушевський", "@vlad_karkushevskiy");
            dataDev.Rows.Add("Артем", "Діковський", "@UncleFitz ");
            dataDev.Rows.Add("Олександр", "Ковальов", "@xairaven");
            dataDev.Rows.Add("Єлизавета", "Дреля", "@liza_drelya ");
            dataDev.Rows.Add("Данило", "Жуковський", "@Etherwoood ");
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            Hide();
        }
    }
}