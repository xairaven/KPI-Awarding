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

            string fullName = $"{lastNameText.Text} {firstNameText.Text} {middleNameText.Text}";

            var row = MainForm.UserList.Take(MainForm.UserList.Count).Count(x => x.Value.Name == fullName);


            int indexFac = MainForm.FacList.IndexOf(facultyComboBox.Text)+1;

            int id;
            if (row == 0)
            {
                Users user = new Users(fullName, indexFac);
                id = DataWork.Adduser(user);
            }
            else
            {
                id = DataWork.GetIdUser(fullName);
            }

            int nu, y;
            nu = MainForm.RewList.IndexOf(rewardCountryComboBox.Text);
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

            DataWork.AddReward(reward1, reward2);
 


            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
       
    

    private void backBut_MouseClick(object sender, MouseEventArgs e)
    {
        MainForm mainForm = new MainForm();
        mainForm.Show();
        Hide();
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
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