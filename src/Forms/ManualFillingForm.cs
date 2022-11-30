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


        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                @"Якщо ви вийдете, ви втратите всі дані.
Ви впевнені?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                var changeDataUploadForm = new ChangeDataUploadForm();
                changeDataUploadForm.TopMost = true;
                changeDataUploadForm.Show();
                changeDataUploadForm.TopMost = false;

                Hide();
            }
            else
            {
                TopMost = true;
                TopMost = false;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
            StartForm.MainForm.dataGridView1.Rows.Add($"{firstNameText.Text} {lastNameText.Text} {middleNameText.Text}",
                facultyComboBox.Text, rewardKpiComboBox.Text, rewardCountryComboBox.Text, protocolNumberText.Text,
                yearsKPIText.Text, yearsStateText.Text);
            StartForm.MainForm.Show();
            Hide();

        }

        private void backBut_MouseClick_1(object sender, MouseEventArgs e)
        {
            StartForm.MainForm.Show();
            Hide();
        }
    }
}