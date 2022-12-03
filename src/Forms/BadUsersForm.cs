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

            for (var i = 0; i < MainForm.dataGridView1.Columns.Count; i++)
            {
                dt.Columns.Add(MainForm.dataGridView1.Columns[i].HeaderText);
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
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
    }
}