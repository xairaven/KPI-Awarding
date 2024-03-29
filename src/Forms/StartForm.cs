﻿using System.Windows.Forms;

namespace Program.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        
        private void devBut_MouseClick(object sender, MouseEventArgs e)
        {
            var developersForm = new DevelopersForm();
            developersForm.Show();
            Hide();
        }

        private void startBut_MouseClick(object sender, MouseEventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }
    }
}