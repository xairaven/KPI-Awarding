using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Program.DataBase;

namespace Program.Forms
{
    public partial class AddRewardsForm : Form
    {
        private List<string[]> list;
        public AddRewardsForm()
        {
            InitializeComponent();


             list = DataWork.GetUsers();
            for (var i = 0; i < list.Count; i++)
            {
                string[] a = list[i];
                string name = a[0].Split(' ')[0];
                string fac = a[1];
                personListBox.Items.Add(name +  " " + fac );
            }
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
            
        }

        private void startBut_MouseClick(object sender, MouseEventArgs e)
        {
            
            // var dt = new DataTable();
            //
            // for (var i = 0; i < MainForm.dataGridView1.Columns.Count; i++)
            // {
            //     dt.Columns.Add(MainForm.dataGridView1.Columns[i].Name);
            // }
            //
            // for (var i = 0; i < MainForm.dataGridView1.Rows.Count; i++)
            // {
            //     var dtRow = dt.NewRow();
            //
            //     for (var j = 0; j < MainForm.dataGridView1.Columns.Count; j++)
            //     {
            //         dtRow[j] = MainForm.dataGridView1[j, i].Value;
            //     }
            //
            //     dt.Rows.Add(dtRow);
            // }
            //
            // dt.Rows.Add(MainForm.dataGridView1.Rows.Count+1,MainForm.dataGridView1[1, personListBox.SelectedIndex].Value,
            //     MainForm.dataGridView1[2, personListBox.SelectedIndex].Value, rewardKpiComboBox.Text,
            //     rewardCountryComboBox.Text, protocolNumberText.Text,
            //     yearsKPIText.Text, yearsStateText.Text);
            //
            //
            //
            // MainForm.dataGridView1.Columns.Clear();
            // MainForm.dataGridView1.DataSource = dt;

            int index = personListBox.SelectedIndex;
            string[] a = list[index];
            int id = DataWork.GetIdUser(a[0]);
            
            int nu, y;
            nu=MainForm.RewList.IndexOf(rewardCountryComboBox.Text);
            if (nu == -1) nu++;
            y = MainForm.YearsList.IndexOf(yearsStateText.Text);
            if (y == -1) y++;
            var reward1 = new Rewards(id);
            reward1.Name = nu;
            reward1.Year = y;
                
            nu = MainForm.KPIList.IndexOf(rewardKpiComboBox.Text);
            if (nu == -1) nu++;
            y = MainForm.YearsList.IndexOf(yearsKPIText.Text);
            if (y == -1) y++;
            var reward2 = new Rewards(id);
            reward2.Name = nu;
            reward2.Year = y;

            DataWork.AddReward(reward1,reward2);
            
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
        
        private void countryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeVisibleCountry(true);
            ChangeVisibleKpi(false);
        }

        private void KpiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeVisibleCountry(false);
            ChangeVisibleKpi(true);
        }

        private void ChangeVisibleCountry(bool boolean)
        {
            rewardCountryLabel.Visible = boolean;
            rewardCountryComboBox.Visible = boolean;
            yearsStateLabel.Visible = boolean;
            yearsStateText.Visible = boolean;
        }

        private void ChangeVisibleKpi(bool boolean)
        {
            rewardKpiLabel.Visible = boolean;
            rewardKpiComboBox.Visible = boolean;
            yearsKPILabel.Visible = boolean;
            yearsKPIText.Visible = boolean;
            if (rewardKpiComboBox.Text.Equals("почесне звання «Почесний доктор КПІ» (№ протоколу ВР КПІ)") && boolean)
            {
                protocolNumberLabel.Visible = true;
                protocolNumberText.Visible = true;
            }
            else
            {
                protocolNumberLabel.Visible = false;
                protocolNumberText.Visible = false;
            }
        }

        private void rewardKpiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rewardKpiComboBox.Text.Equals("почесне звання «Почесний доктор КПІ» (№ протоколу ВР КПІ)"))
            {
                protocolNumberLabel.Visible = true;
                protocolNumberText.Visible = true;
            }
            else
            {
                protocolNumberLabel.Visible = false;
                protocolNumberText.Visible = false;
            }
        }


    }
}