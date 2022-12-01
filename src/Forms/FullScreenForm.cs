using System.Data;
using System.Windows.Forms;

namespace Program.Forms
{
    public partial class FullScreenForm : Form
    {
        public FullScreenForm()
        {
            InitializeComponent();
            
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
            
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt;
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            dataGridView1.Columns[0].FillWeight = 30;

        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            StartForm.MainForm.Show();
            Hide();
        }
    }
}