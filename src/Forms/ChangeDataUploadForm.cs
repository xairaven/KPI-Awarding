using System.IO;
using System.Windows.Forms;

namespace Program.Forms
{
    public partial class ChangeDataUploadForm : Form
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;
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
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.xlsx";
            openFile1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            
            if (openFile1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFile1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFile1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

        


        }
    }
}