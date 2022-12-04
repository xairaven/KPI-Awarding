using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Program.DataBase;
using Excel = Microsoft.Office.Interop.Excel;

namespace Program.Forms
{
    public partial class MainForm : Form
    {
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


        
        
        private void InitializeDataGrid()
        {
            dataGridView1.Columns[0].FillWeight = 30;
            dataGridView1.Columns[1].FillWeight = 130;
            dataGridView1.Columns[2].FillWeight = 100;
            dataGridView1.Columns[3].FillWeight = 110;
            dataGridView1.Columns[4].FillWeight = 110;
            dataGridView1.Columns[5].FillWeight = 130;
            dataGridView1.Columns[6].FillWeight = 120;
            dataGridView1.Columns[7].FillWeight = 120;
           dataGridView1.Columns[8].FillWeight = 130;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        
        }


        private void RealizeDefaultData()
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

        public static Dictionary<int, Users> UserList;
        public static List<string> FacList = DataWork.GetFacs();
        public static List<string> RewList = DataWork.GetRews();
        public static List<string> KPIList = DataWork.GetKPI();
        public static List<string> YearsList = DataWork.GetYears();

        private void importExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            var xlFileName = ofd.FileName; //имя нашего Excel файла

            //рабоата с Excel

            var xlApp = new Excel.Application(); //создаём приложение Excel
            var xlWb = xlApp.Workbooks.Open(xlFileName); //открываем наш файл           
            var xlSht = (Excel.Worksheet)xlWb.ActiveSheet; //активный лист

            var iLastRow = xlSht.UsedRange.Rows.Count;
            var iLastCol = xlSht.UsedRange.Columns.Count;


            var rng = xlSht.Range["A1",
                xlSht.Cells[iLastRow, iLastCol]]; //пример записи диапазона ячеек в переменную Rng


            var dataArr = (object[,])rng.Value; //чтение данных из ячеек в массив            

            //закрытие Excel
            xlWb.Close(true); //сохраняем и закрываем файл
            xlApp.Quit();
            ReleaseObject(xlSht);
            ReleaseObject(xlWb);
            ReleaseObject(xlApp);

            //заполняем DataTable для последующего заполнения dataGridView
            var dt = new DataTable();

            dt.Columns.Add("№");
            var count = 1;
            //добавляем столбцы в DataTable
            for (var i = 1; i <= dataArr.GetUpperBound(1); i++)
                dt.Columns.Add((string)dataArr[1, i]);
            
            dt.Columns.Add("Прогнозування");


            //цикл по строкам массива
            for (var i = 2; i <= dataArr.GetUpperBound(0); i++)
            {
                var dtRow = dt.NewRow();
                dtRow[0] = count++;
                //цикл по столбцам массива
                for (var n = 1; n <= dataArr.GetUpperBound(1); n++)
                {
                    dtRow[n] = dataArr[i, n];
                }


                var row = UserList.Take(UserList.Count).Count(x => x.Value.Name == dtRow[1].ToString());


                int indexFac = FacList.IndexOf(dtRow[2].ToString()) + 1;


                int id;
                if (row == 0)
                {
                    Users user = new Users(dtRow[1].ToString(), indexFac);
                    id = DataWork.Adduser(user);
                }
                else
                {
                    id = DataWork.GetIdUser(dtRow[1].ToString());
                }

                int nu, y;
                nu = RewList.IndexOf(dtRow[4].ToString());
                if (nu == -1) nu++;
                y = YearsList.IndexOf(dtRow[7].ToString());
                if (y == -1) y++;
                var reward1 = new Rewards(id, "");
                reward1.Name = nu;
                reward1.Year = y;

                nu = KPIList.IndexOf(dtRow[3].ToString());
                if (nu == -1) nu++;
                y = YearsList.IndexOf(dtRow[6].ToString());
                if (y == -1) y++;
                var reward2 = new Rewards(id, dtRow[5].ToString());
                reward2.Name = nu;
                reward2.Year = y;

                DataWork.AddReward(reward1, reward2);
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

            dataGridView1.DataSource = dt; //заполняем dataGridView
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
        {
            Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);

            try
            {
                var worksheet = (Excel._Worksheet)workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                var cellRowIndex = 1;
                var cellColumnIndex = 1;

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
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
            string choise = searchTextBox.Text;
            string category = searchComboBox.Text;

            string[] categoreArray = new string[dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                categoreArray[i] = dataGridView1.Columns[i].HeaderText;
            }

            switch (category)
            {
                case "№":
                    editDB(DataWork.FindNum(choise));
                    break;

                case "Прізвище, ім'я, по батькові співробітника":
                    editDB(DataWork.FindUser(DataWork.GetIdUser(choise)));
                    break;

                case "Факультет /ННІ":
                    editDB(DataWork.FindFac(FacList.IndexOf(choise) + 1));
                    break;

                case "Нагорода (Почесне звання, відзнака та грамота)":
                    editDB(DataWork.FindKPI(KPIList.IndexOf(choise)));
                    break;

                case "Державна нагорода":
                    editDB(DataWork.FindRew(RewList.IndexOf(choise)));
                    break;

                case "№ протоколу ВР КПІ ім. Ігоря Сікорського про відзначення":
                    editDB(DataWork.FindProt(choise));
                    break;

                case "Рік відзначення КПІ":
                    editDB(DataWork.FindYKPI(YearsList.IndexOf(choise)));
                    break;

                case "Рік призначення державою":
                    editDB(DataWork.FindYRew(YearsList.IndexOf(choise)));
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


            for (int i = 1; i <= list.Count; i++)
            {
                string[] arr = list[i - 1];

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
        }

        private void restartDefaultDB_MouseClick(object sender, MouseEventArgs e)
        {
            RealizeDefaultData();
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
    }
}