using System.Windows.Forms;

namespace Program.Forms
{
    public partial class AddRewardsForm : Form
    {
        public AddRewardsForm()
        {
            InitializeComponent();
            for (var i = 0; i < StartForm.MainForm.dataGridView1.RowCount - 1; i++)
            {
                personListBox.Items.Add(StartForm.MainForm.dataGridView1[0, i].Value);
            }
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            StartForm.MainForm.Show();
            Hide();
        }

        private void startBut_MouseClick(object sender, MouseEventArgs e)
        {
            StartForm.MainForm.dataGridView1.Rows.Add(
                StartForm.MainForm.dataGridView1[personListBox.SelectedIndex, 0].Value,
                StartForm.MainForm.dataGridView1[personListBox.SelectedIndex, 1].Value, comboBox1.Text, comboBox2.Text,
                protocolNumberText.Text, yearsKPIText.Text, yearsStateText.Text);
            StartForm.MainForm.Show();
            Hide();
        }
    }
}