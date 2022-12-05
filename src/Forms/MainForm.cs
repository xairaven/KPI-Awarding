using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Program.DataBase;
using Excel = Microsoft.Office.Interop.Excel;

namespace Program.Forms
{
    public partial class MainForm : Form
    {
        
        public static Dictionary<int, Users> UserList;
        public static List<string> FacList = DataWork.GetFacs();
        public static List<string> RewList = DataWork.GetRews();
        public static List<string> KPIList = DataWork.GetKPI();
        public static List<string> YearsList = DataWork.GetYears();
        
        public MainForm()
        {
            InitializeComponent();
            for (var i = 0; i < dataGridView1.ColumnCount-1; i++)
            {
                searchComboBox.Items.Add(dataGridView1.Columns[i].HeaderText);
            }

            UserList = new Dictionary<int, Users>();

            RealizeDefaultData();
            InitializeDataGrid();
        }
        
        
        private void InitializeDataGrid()//метод встановлення розиіру для dataGridView
        {
            dataGridView1.Columns[0].FillWeight = 30;
            dataGridView1.Columns[1].FillWeight = 130;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].FillWeight = 100;
            dataGridView1.Columns[3].FillWeight = 110;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[4].FillWeight = 110;
            dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[5].FillWeight = 130;
            dataGridView1.Columns[6].FillWeight = 120;
            dataGridView1.Columns[7].FillWeight = 120;
           dataGridView1.Columns[8].FillWeight = 130;
           dataGridView1.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
           dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        
        }


        private void RealizeDefaultData()//метод для заповнення даними з бази даних
        {
            var dt = new DataTable();

            for (var i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dt.Columns.Add(dataGridView1.Columns[i].HeaderText);
            }

            for (int i = 1; i <= DataWork.GetRewdNum(); i++)
            {
                string[] arr = DataWork.GetUsRewards(i);

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


        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Unable to release the object " + ex);
            }
            finally
            {
                GC.Collect();
            }
        }
        

        private void importExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {//метод імпорту з Екселя
            var ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = @"Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = @"Выберите документ Excel";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show(@"Вы не выбрали файл для открытия", @"Внимание", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            DataWork.ClearDB();
            dataGridView1.Columns.Clear();
            var xlFileName = ofd.FileName;


            var xlApp = new Excel.Application();
            var xlWb = xlApp.Workbooks.Open(xlFileName);       
            var xlSht = (Excel.Worksheet)xlWb.ActiveSheet; 

            var iLastRow = xlSht.UsedRange.Rows.Count;
            var iLastCol = xlSht.UsedRange.Columns.Count;


            var rng = xlSht.Range["A1",
                xlSht.Cells[iLastRow, iLastCol]];


            var dataArr = (object[,])rng.Value;         

            xlWb.Close(true);
            xlApp.Quit();
            ReleaseObject(xlSht);
            ReleaseObject(xlWb);
            ReleaseObject(xlApp);

            var dt = new DataTable();

            dt.Columns.Add("№");
            var count = 1;

            for (var i = 1; i <= dataArr.GetUpperBound(1); i++)
                dt.Columns.Add((string)dataArr[1, i]);
            
            dt.Columns.Add("Прогнозування");


            
            for (var i = 2; i <= dataArr.GetUpperBound(0); i++)
            {
                var dtRow = dt.NewRow();
                dtRow[0] = count++;
               
                for (var n = 1; n <= dataArr.GetUpperBound(1); n++)
                {
                    dtRow[n] = dataArr[i, n];
                }


                var row = UserList.Take(UserList.Count).Count(x => x.Value.Name == dtRow[1].ToString());


                var indexFac = FacList.IndexOf(dtRow[2].ToString()) + 1;


                int id;
                var user = new Users(dtRow[1].ToString(), indexFac);
                id = row == 0 ? DataWork.Adduser(user) : DataWork.GetIdUser(dtRow[1].ToString());

                var nu = RewList.IndexOf(dtRow[4].ToString());
                if (nu == -1) nu++;
                var y = YearsList.IndexOf(dtRow[7].ToString());
                if (y == -1) y++;
                var reward1 = new Rewards(id, "")
                {
                    Name = nu,
                    Year = y
                };

                nu = KPIList.IndexOf(dtRow[3].ToString());
                if (nu == -1) nu++;
                y = YearsList.IndexOf(dtRow[6].ToString());
                if (y == -1) y++;
                var reward2 = new Rewards(id, dtRow[5].ToString())
                {
                    Name = nu,
                    Year = y
                };

                DataWork.AddReward(reward1, reward2);
            }

            for (var i = 1; i <= DataWork.GetRewdNum(); i++)
            {
                var arr = DataWork.GetUsRewards(i);

                var dtRow = dt.NewRow();

                dtRow[0] = i.ToString();

                for (var j = 0; j < arr.Length; j++)
                {
                    dtRow[j + 1] = arr[j];
                }

                dt.Rows.Add(dtRow);
            }

            dataGridView1.DataSource = dt; 
            InitializeDataGrid();

        }


        private void addRewardBut_MouseClick(object sender, MouseEventArgs e)
        {
            var addRewardsForm = new AddRewardsForm();
            addRewardsForm.Show();
            Hide();
        }

        private void addNew_MouseClick(object sender, MouseEventArgs e)
        {
            var manualFillingForm = new ManualFillingForm();
            manualFillingForm.Show();
            Hide();
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {

            var startForm = new StartForm();
            startForm.TopMost = true;
            startForm.Show();
            startForm.TopMost = false;
            Hide();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var fullScreenForm = new FullScreenForm(dataGridView1);
            fullScreenForm.Show();
            Hide();
        }

        private void exportExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {//метод для експорту Excel файла
            Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);

            try
            {
                var worksheet = (Excel._Worksheet)workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                var cellRowIndex = 1;
                var cellColumnIndex = 1;

                for (var i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[cellRowIndex, cellColumnIndex] =
                        dataGridView1.Columns[i].HeaderText;
                    cellColumnIndex++;
                }

                cellColumnIndex = 1;
                cellRowIndex++;


                for (var i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (var j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] =
                            dataGridView1.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }

                    cellColumnIndex = 1;
                    cellRowIndex++;
                }


                var saveDialog = new SaveFileDialog();
                saveDialog.Filter = @"Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() != DialogResult.OK) return;
                workbook.SaveAs(saveDialog.FileName);
                MessageBox.Show(@"Export Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
            }
        }

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var source = new AutoCompleteStringCollection();
            for (var i = 0; i < dataGridView1.RowCount; i++)
            {
                source.Add(dataGridView1[searchComboBox.SelectedIndex, i].Value.ToString());
            }

            searchTextBox.AutoCompleteCustomSource = source;
        }


        


        private void badUserBut_MouseClick(object sender, MouseEventArgs e)
        {
            var badUserForms = new BadUsersForm();
            badUserForms.Show();
            Hide();
        }

        private void searchBut_MouseClick(object sender, MouseEventArgs e)
        {
            if(searchTextBox.Text.Replace(" ","") == "") return;
            var choice = searchTextBox.Text;
            var category = searchComboBox.Text;

            var categoryArray = new string[dataGridView1.ColumnCount];
            for (var i = 0; i < dataGridView1.ColumnCount; i++)
            {
                categoryArray[i] = dataGridView1.Columns[i].HeaderText;
            }

            switch (category)
            {
                case "№":
                    editDB(DataWork.FindNum(choice));
                    break;

                case "Прізвище, ім'я, по батькові співробітника":
                    editDB(DataWork.FindUser(DataWork.GetIdUser(choice)));
                    break;

                case "Факультет /ННІ":
                    editDB(DataWork.FindFac(FacList.IndexOf(choice) + 1));
                    break;

                case "Нагорода (Почесне звання, відзнака та грамота)":
                    editDB(DataWork.FindKPI(KPIList.IndexOf(choice)));
                    break;

                case "Державна нагорода":
                    editDB(DataWork.FindRew(RewList.IndexOf(choice)));
                    break;

                case "№ протоколу ВР КПІ ім. Ігоря Сікорського про відзначення":
                    editDB(DataWork.FindProt(choice));
                    break;

                case "Рік відзначення КПІ":
                    editDB(DataWork.FindYKPI(YearsList.IndexOf(choice)));
                    break;

                case "Рік призначення державою":
                    editDB(DataWork.FindYRew(YearsList.IndexOf(choice)));
                    break;
            }
            
            InitializeDataGrid();
        }


        private void editDB(List<string[]> list)
        {
            var dt = new DataTable();

            for (var i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dt.Columns.Add(dataGridView1.Columns[i].HeaderText);
            }


            for (var i = 1; i <= list.Count; i++)
            {
                var arr = list[i - 1];

                var dtRow = dt.NewRow();

                dtRow[0] = i.ToString();

                for (var j = 0; j < arr.Length; j++)
                {
                    dtRow[j + 1] = arr[j];
                }

                dt.Rows.Add(dtRow);
            }


            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt;
        }

        private void restartDefaultDB_MouseClick(object sender, MouseEventArgs e)
        {
            RealizeDefaultData();
            searchTextBox.Text = "";
        }

        private void clearDbBut_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                @"При натисканні очиститься уся база даних.
Ви впевнені?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                DataWork.ClearDB();
                var startForm = new StartForm();
                startForm.TopMost = true;
                startForm.Show();
                startForm.TopMost = false;
                Hide();
            }
            else
            {
                TopMost = true;
                TopMost = false;
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {git g
            Close();
        }
    }
}