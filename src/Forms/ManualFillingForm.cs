using System.Data;
using System.Windows.Forms;

namespace Program.Forms
{
    public partial class ManualFillingForm : Form
    {
        public ManualFillingForm()
        {
            InitializeComponent();
        }

        private void saveBut_MouseClick(object sender, MouseEventArgs e)
        {
            var dt = new DataTable();

            for (var i = 0; i < StartForm.MainForm.dataGridView1.Columns.Count; i++)
            {
                dt.Columns.Add(StartForm.MainForm.dataGridView1.Columns[i].HeaderText);
            }

            for (var i = 0; i < StartForm.MainForm.dataGridView1.Rows.Count; i++)
            {
                var dtRow = dt.NewRow();

                for (var j = 0; j < StartForm.MainForm.dataGridView1.Columns.Count; j++)
                {
                    dtRow[j] = StartForm.MainForm.dataGridView1[j, i].Value;
                }

                dt.Rows.Add(dtRow);
            }

            dt.Rows.Add(StartForm.MainForm.dataGridView1.Rows.Count+1,$"{firstNameText.Text} {lastNameText.Text} {middleNameText.Text}",
                facultyComboBox.Text, rewardKpiComboBox.Text, rewardCountryComboBox.Text, protocolNumberText.Text,
                yearsKPIText.Text, yearsStateText.Text);
            StartForm.MainForm.dataGridView1.Columns.Clear();
            StartForm.MainForm.dataGridView1.DataSource = dt;
            StartForm.MainForm.Show();
            Hide();
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            StartForm.MainForm.Show();
            Hide();
        }

    }
}