using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Program.Forms
{
    public partial class ChangeDataUploadForm : Form
    {
        public ChangeDataUploadForm()
        {
            InitializeComponent();
        }

        private void manuallyBut_MouseClick(object sender, MouseEventArgs e)
        {
            var manualFillingForm = new ManualFillingForm();
            manualFillingForm.Show();
            Hide();
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            var startForm = new StartForm();
            startForm.Show();
            Hide();
        }

        private void excelBut_MouseClick(object sender, MouseEventArgs e)
        {

            var ofd = new OpenFileDialog();
            ofd.Multiselect =false;
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ Excel";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var xlFileName = ofd.FileName; //имя нашего Excel файла
            
            //рабоата с Excel

            var xlApp = new Excel.Application(); //создаём приложение Excel
            var xlWb = xlApp.Workbooks.Open(xlFileName); //открываем наш файл           
            var xlSht = (Excel.Worksheet)xlWb.ActiveSheet; //активный лист

            var iLastRow = xlSht.UsedRange.Rows.Count;
            var iLastCol = xlSht.UsedRange.Columns.Count;
            

            var rng = xlSht.Range["A1", xlSht.Cells[iLastRow, iLastCol]]; //пример записи диапазона ячеек в переменную Rng
            //Rng = xlSht.get_Range("A1", "D4"); //пример записи диапазона ячеек в переменную Rng
            
            
            var dataArr = (object[,])rng.Value; //чтение данных из ячеек в массив            
            //xlSht.get_Range("K1").get_Resize(dataArr.GetUpperBound(0), dataArr.GetUpperBound(1)).Value = dataArr; //выгрузка массива на лист
 
            //закрытие Excel
            xlWb.Close(true); //сохраняем и закрываем файл
            xlApp.Quit();
            ReleaseObject(xlSht);
            ReleaseObject(xlWb);
            ReleaseObject(xlApp);
 
            //заполняем DataTable для последующего заполнения dataGridView
            DataTable dt = new DataTable();
            DataRow dtRow;
            //добавляем столбцы в DataTable
            for (int i = 1; i <= dataArr.GetUpperBound(1); i++)
                dt.Columns.Add((string)dataArr[1, i]);            
            
            //цикл по строкам массива
            for (int i = 2; i <= dataArr.GetUpperBound(0); i++)
            {
                dtRow = dt.NewRow();
                //цикл по столбцам массива
                for (int n = 1; n <= dataArr.GetUpperBound(1); n++)
                {
                    dtRow[n-1] = dataArr[i, n];
                }
                dt.Rows.Add(dtRow);
            }

            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
            mainForm.dataGridView1.DataSource = dt; //заполняем dataGridView
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
    }
}