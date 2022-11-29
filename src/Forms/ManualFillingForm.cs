using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                "Якщо ви вийдете, ви втратите всі дані.\n Ви впевнені?", 
                "", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2, 
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                ChangeDataUploadForm changeDataUploadForm = new ChangeDataUploadForm();
                changeDataUploadForm.Show();
                Hide();
            }

        }
    }
 

}