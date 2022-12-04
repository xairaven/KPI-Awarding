using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Program.DataBase;

namespace Program.Forms
{
    public partial class ManualFillingForm : Form
    {
        public ManualFillingForm()
        {
            InitializeComponent();
        }

        private void saveBut_MouseClick(object sender, MouseEventArgs e)
        {

            if (lastNameText.Text == "" || firstNameText.Text == "" || middleNameText.Text == "")
            {
                label1.Text = @"Впишіть прізвище, ім'я та по-батькові співробітника";
            }
            else
            {
                string fullName = $"{lastNameText.Text} {firstNameText.Text} {middleNameText.Text}";
                if (facultyComboBox.Text == "")
                {
                    label1.Text = @"Оберіть факультет";
                }
                else
                {
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
                        
                    }else if (radioButton2.Checked)
                    {
                        if (rewardCountryComboBox.Text == "" || rewardCountryComboBox.Text == "-" || yearsStateText.Text=="")
                        {
                            label1.Text = @"Оберіть нагороду та рік призначення";
                            return;
                        } 
                    }

                    var row = MainForm.UserList.Take(MainForm.UserList.Count).Count(x => x.Value.Name == fullName);


                    var indexFac = MainForm.FacList.IndexOf(facultyComboBox.Text)+1;

                    var user = new Users(fullName, indexFac);
                    var id = row == 0 ? DataWork.Adduser(user) : DataWork.GetIdUser(fullName);

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

                    DataWork.AddReward(reward1, reward2);
                    
                    var mainForm = new MainForm();
                    mainForm.Show();
                    Hide();
                }
            }
            
           
        }
       
    

    private void backBut_MouseClick(object sender, MouseEventArgs e)
    {
        var mainForm = new MainForm();
        mainForm.Show();
        Hide();
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
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