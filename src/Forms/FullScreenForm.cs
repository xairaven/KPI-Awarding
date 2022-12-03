using System.Data;
using System.Windows.Forms;
using Program.DataBase;

namespace Program.Forms
{
    public partial class FullScreenForm : Form
    {
        public FullScreenForm()
        {
            InitializeComponent();
            
            var dt = new DataTable();
            
            for (var i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dt.Columns.Add(dataGridView1.Columns[i].HeaderText);
            }
            
            for (int i = 1; i <= DataWork.GetRewdNum(); i++)
            {
                string[] arr =  DataWork.GetUsRewards(i);
               
                var dtRow = dt.NewRow();

                dtRow[0] = i.ToString();
                
                for (int j = 0; j < arr.Length; j++)
                {
                    dtRow[j + 1] = arr[j];
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
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
    }
}