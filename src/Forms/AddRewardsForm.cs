using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Program.Forms
{
    public partial class AddRewardsForm : Form
    {
        public AddRewardsForm()
        {
            InitializeComponent();
            for (var i = 0; i < StartForm.MainForm.dataGridView1.RowCount; i++)
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
            var dt = new DataTable();

            var a = new List<string>();
            for (var i = 0; i < StartForm.MainForm.dataGridView1.Columns.Count; i++)
            {
                dt.Columns.Add(StartForm.MainForm.dataGridView1.Columns[i].Name);
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

            dt.Rows.Add(StartForm.MainForm.dataGridView1[0, personListBox.SelectedIndex].Value,
                StartForm.MainForm.dataGridView1[1, personListBox.SelectedIndex].Value, rewardKpiComboBox.Text,
                rewardCountryComboBox.Text, protocolNumberText.Text,
                yearsKPIText.Text, yearsStateText.Text);
            


            StartForm.MainForm.dataGridView1.Columns.Clear();
            StartForm.MainForm.dataGridView1.DataSource = dt;
            StartForm.MainForm.Show();
            Hide();
        }
    }
}