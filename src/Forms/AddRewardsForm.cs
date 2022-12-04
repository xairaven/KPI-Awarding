using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Program.DataBase;

namespace Program.Forms
{
    public partial class AddRewardsForm : Form
    {
        private List<string[]> _list;
        public AddRewardsForm()
        {
            InitializeComponent();


             _list = DataWork.GetUsers();
            foreach (var a in _list)
            {
                var name = a[0].Split(' ')[0];
                var fac = a[1];
                personListBox.Items.Add(name +  " " + fac );
            }
        }

        private void backBut_MouseClick(object sender, MouseEventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
            
        }

        private void startBut_MouseClick(object sender, MouseEventArgs e)
        {

            label1.Text = personListBox.Text;

            if (personListBox.Text == "")
            {
                label1.Text = @"Оберіть співробітника";
                return;
            }
            if (KpiRadioButton.Checked)
            {
            
                if (rewardKpiComboBox.Text == "" || rewardKpiComboBox.Text == "-" || yearsKPIText.Text=="")
                {
                    label1.Text = @"Оберіть нагороду та рік призначення";
                    return;
                }
                if (rewardKpiComboBox.Text == @"почесне звання «Почесний доктор КПІ» (№ протоколу ВР КПІ)")
                {
                    if (protocolNumberText.Text=="")
                    {
                        label1.Text = @"Оберіть номер протоколу";
                        return;
                    }
                }
                        
            }else if (countryRadioButton.Checked)
            {
                if (rewardCountryComboBox.Text == "" || rewardCountryComboBox.Text == "-" || yearsStateText.Text=="")
                {
                    label1.Text = @"Оберіть нагороду та рік призначення";
                    return;
                } 
            }
            var index = personListBox.SelectedIndex;
            var a = _list[index];
            var id = DataWork.GetIdUser(a[0]);

            var nu = MainForm.RewList.IndexOf(rewardCountryComboBox.Text);
            if (nu == -1) nu++;
            var y = MainForm.YearsList.IndexOf(yearsStateText.Text);
            if (y == -1) y++;
            var reward1 = new Rewards(id," ")
            {
                Name = nu,
                Year = y
            };

            nu = MainForm.KPIList.IndexOf(rewardKpiComboBox.Text);
            if (nu == -1) nu++;
            y = MainForm.YearsList.IndexOf(yearsKPIText.Text);
            if (y == -1) y++;
            var reward2 = new Rewards(id,protocolNumberText.Text)
            {
                Name = nu,
                Year = y
            };

            DataWork.AddReward(reward1,reward2);
            
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
        
        private void countryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeVisibleCountry(true);
            ChangeVisibleKpi(false);
            rewardKpiComboBox.SelectedIndex = 0;
            yearsKPIText.Text = "";
            protocolNumberText.Text = "";
        }

        private void KpiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeVisibleCountry(false);
            rewardCountryComboBox.SelectedIndex = 0;
            yearsStateText.Text = "";
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
                protocolNumberText.Text = "";
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
                protocolNumberText.Text = "";

            }
        }


    }
}