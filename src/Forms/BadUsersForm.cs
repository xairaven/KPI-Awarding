using System.Data;
using System.Windows.Forms;
using Program.DataBase;

namespace Program.Forms
{
    public partial class BadUsersForm : Form
    {
        public BadUsersForm()
        {
            InitializeComponent();
            
            
            var dt = new DataTable();

            for (var i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dt.Columns.Add(dataGridView1.Columns[i].HeaderText);
            }
            
            for (int i = 1; i <= DataWork.GetBadNum(); i++)
            {
                string[] arr =  DataWork.GetBadRewards(i);
               
                var dtRow = dt.NewRow();

                dtRow[0] = i.ToString();
                
                for (int j = 0; j < arr.Length; j++)
                {
                    dtRow[j + 1] = arr[j];
                }
                
                dt.Rows.Add(dtRow);
            }
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt; //заполняем dataGridView
            InitializeDataGrid();
        }
        
        private void InitializeDataGrid()
        {
            dataGridView1.Columns[0].FillWeight = 30;
            dataGridView1.Columns[1].FillWeight = 170;
            dataGridView1.Columns[2].FillWeight = 80;
            dataGridView1.Columns[3].FillWeight = 150;
            dataGridView1.Columns[4].FillWeight = 150;
            dataGridView1.Columns[5].FillWeight = 150;
            dataGridView1.Columns[6].FillWeight = 100;
            dataGridView1.Columns[7].FillWeight = 100;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
    }
}