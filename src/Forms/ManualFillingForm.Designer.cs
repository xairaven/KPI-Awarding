using System.ComponentModel;

namespace Program.Forms
{
    partial class ManualFillingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.rewardKpiLabel = new System.Windows.Forms.Label();
            this.rewardCountryLabel = new System.Windows.Forms.Label();
            this.yearsStateLabel = new System.Windows.Forms.Label();
            this.yearsKPILabel = new System.Windows.Forms.Label();
            this.protocolNumberLabel = new System.Windows.Forms.Label();
            this.KpiRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.backBut = new Guna.UI2.WinForms.Guna2Button();
            this.saveBut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lastNameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstNameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.middleNameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.facultyComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.yearsKPIText = new Guna.UI2.WinForms.Guna2TextBox();
            this.rewardKpiComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rewardCountryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.yearsStateText = new Guna.UI2.WinForms.Guna2TextBox();
            this.protocolNumberText = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(41, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(242, 36);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Прізвище:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(41, 165);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(242, 35);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "Ім\'я:";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameLabel.Location = new System.Drawing.Point(41, 277);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(242, 36);
            this.middleNameLabel.TabIndex = 7;
            this.middleNameLabel.Text = "По-батькові:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyLabel.Location = new System.Drawing.Point(41, 386);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(196, 33);
            this.facultyLabel.TabIndex = 8;
            this.facultyLabel.Text = "Факультет/ННІ:";
            // 
            // rewardKpiLabel
            // 
            this.rewardKpiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardKpiLabel.Location = new System.Drawing.Point(379, 165);
            this.rewardKpiLabel.Name = "rewardKpiLabel";
            this.rewardKpiLabel.Size = new System.Drawing.Size(241, 35);
            this.rewardKpiLabel.TabIndex = 12;
            this.rewardKpiLabel.Text = "Нагорода:";
            // 
            // rewardCountryLabel
            // 
            this.rewardCountryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardCountryLabel.Location = new System.Drawing.Point(720, 166);
            this.rewardCountryLabel.Name = "rewardCountryLabel";
            this.rewardCountryLabel.Size = new System.Drawing.Size(243, 35);
            this.rewardCountryLabel.TabIndex = 14;
            this.rewardCountryLabel.Text = "Державна нагорода:";
            this.rewardCountryLabel.Visible = false;
            // 
            // yearsStateLabel
            // 
            this.yearsStateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsStateLabel.Location = new System.Drawing.Point(720, 254);
            this.yearsStateLabel.Name = "yearsStateLabel";
            this.yearsStateLabel.Size = new System.Drawing.Size(243, 59);
            this.yearsStateLabel.TabIndex = 18;
            this.yearsStateLabel.Text = "Рік призначення державою:";
            this.yearsStateLabel.Visible = false;
            // 
            // yearsKPILabel
            // 
            this.yearsKPILabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsKPILabel.Location = new System.Drawing.Point(379, 277);
            this.yearsKPILabel.Name = "yearsKPILabel";
            this.yearsKPILabel.Size = new System.Drawing.Size(242, 34);
            this.yearsKPILabel.TabIndex = 17;
            this.yearsKPILabel.Text = "Рік відзначення КПІ:";
            // 
            // protocolNumberLabel
            // 
            this.protocolNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolNumberLabel.Location = new System.Drawing.Point(380, 386);
            this.protocolNumberLabel.Name = "protocolNumberLabel";
            this.protocolNumberLabel.Size = new System.Drawing.Size(240, 91);
            this.protocolNumberLabel.TabIndex = 16;
            this.protocolNumberLabel.Text = "№ протоколу ВР КПІ ім. Ігоря Сікорського про відзначення:";
            this.protocolNumberLabel.Visible = false;
            // 
            // KpiRadioButton
            // 
            this.KpiRadioButton.Checked = true;
            this.KpiRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KpiRadioButton.Location = new System.Drawing.Point(518, 73);
            this.KpiRadioButton.Name = "KpiRadioButton";
            this.KpiRadioButton.Size = new System.Drawing.Size(104, 24);
            this.KpiRadioButton.TabIndex = 24;
            this.KpiRadioButton.TabStop = true;
            this.KpiRadioButton.Text = "КПІ";
            this.KpiRadioButton.UseVisualStyleBackColor = true;
            this.KpiRadioButton.CheckedChanged += new System.EventHandler(this.KpiRadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(518, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(128, 24);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.Text = "Державна";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(379, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Нагорода:";
            // 
            // backBut
            // 
            this.backBut.BorderColor = System.Drawing.Color.Indigo;
            this.backBut.BorderRadius = 15;
            this.backBut.BorderThickness = 2;
            this.backBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBut.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.backBut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.backBut.ForeColor = System.Drawing.Color.White;
            this.backBut.Location = new System.Drawing.Point(948, 27);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(200, 60);
            this.backBut.TabIndex = 27;
            this.backBut.Text = "Назад";
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
            // 
            // saveBut
            // 
            this.saveBut.BorderColor = System.Drawing.Color.SeaGreen;
            this.saveBut.BorderRadius = 20;
            this.saveBut.BorderThickness = 2;
            this.saveBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBut.FillColor = System.Drawing.Color.LightGreen;
            this.saveBut.FillColor2 = System.Drawing.Color.MediumAquamarine;
            this.saveBut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBut.ForeColor = System.Drawing.Color.White;
            this.saveBut.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.saveBut.Location = new System.Drawing.Point(913, 456);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(235, 60);
            this.saveBut.TabIndex = 28;
            this.saveBut.Text = "Зберегти дані";
            this.saveBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveBut_MouseClick);
            // 
            // lastNameText
            // 
            this.lastNameText.BorderColor = System.Drawing.Color.GhostWhite;
            this.lastNameText.BorderRadius = 8;
            this.lastNameText.BorderThickness = 2;
            this.lastNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameText.DefaultText = "";
            this.lastNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(253)))));
            this.lastNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lastNameText.ForeColor = System.Drawing.Color.Black;
            this.lastNameText.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.lastNameText.Location = new System.Drawing.Point(41, 103);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.PasswordChar = '\0';
            this.lastNameText.PlaceholderText = "";
            this.lastNameText.SelectedText = "";
            this.lastNameText.Size = new System.Drawing.Size(242, 40);
            this.lastNameText.TabIndex = 29;
            // 
            // firstNameText
            // 
            this.firstNameText.BorderColor = System.Drawing.Color.GhostWhite;
            this.firstNameText.BorderRadius = 8;
            this.firstNameText.BorderThickness = 2;
            this.firstNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameText.DefaultText = "";
            this.firstNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(253)))));
            this.firstNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.firstNameText.ForeColor = System.Drawing.Color.Black;
            this.firstNameText.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.firstNameText.Location = new System.Drawing.Point(41, 204);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.PasswordChar = '\0';
            this.firstNameText.PlaceholderText = "";
            this.firstNameText.SelectedText = "";
            this.firstNameText.Size = new System.Drawing.Size(242, 40);
            this.firstNameText.TabIndex = 30;
            // 
            // middleNameText
            // 
            this.middleNameText.BorderColor = System.Drawing.Color.GhostWhite;
            this.middleNameText.BorderRadius = 8;
            this.middleNameText.BorderThickness = 2;
            this.middleNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.middleNameText.DefaultText = "";
            this.middleNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.middleNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.middleNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.middleNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.middleNameText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(253)))));
            this.middleNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.middleNameText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.middleNameText.ForeColor = System.Drawing.Color.Black;
            this.middleNameText.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.middleNameText.Location = new System.Drawing.Point(41, 317);
            this.middleNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.PasswordChar = '\0';
            this.middleNameText.PlaceholderText = "";
            this.middleNameText.SelectedText = "";
            this.middleNameText.Size = new System.Drawing.Size(242, 40);
            this.middleNameText.TabIndex = 31;
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.BackColor = System.Drawing.Color.Transparent;
            this.facultyComboBox.BorderColor = System.Drawing.Color.GhostWhite;
            this.facultyComboBox.BorderRadius = 8;
            this.facultyComboBox.BorderThickness = 2;
            this.facultyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.facultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.facultyComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.facultyComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.facultyComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.facultyComboBox.ForeColor = System.Drawing.Color.Black;
            this.facultyComboBox.ItemHeight = 22;
            this.facultyComboBox.Items.AddRange(new object[] { "IAT", "IATE", "ІЕЕ", "ІМЗ", "ІПСА", "ІТС", "ММІ", "ФТІ", "ІХФ", "ПБФ", "РТФ", "ФБМІ", "ФБТ", "ФЕА", "ФЕЛ", "ФІОТ", "ФЛ", "ФММ", "ФМФ", "ФПМ", "ФСП", "ХТФ", "ІСЗЗІ" });
            this.facultyComboBox.Location = new System.Drawing.Point(41, 422);
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(242, 28);
            this.facultyComboBox.TabIndex = 32;
            // 
            // yearsKPIText
            // 
            this.yearsKPIText.BorderColor = System.Drawing.Color.GhostWhite;
            this.yearsKPIText.BorderRadius = 8;
            this.yearsKPIText.BorderThickness = 2;
            this.yearsKPIText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yearsKPIText.DefaultText = "";
            this.yearsKPIText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yearsKPIText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yearsKPIText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yearsKPIText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yearsKPIText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(253)))));
            this.yearsKPIText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yearsKPIText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.yearsKPIText.ForeColor = System.Drawing.Color.Black;
            this.yearsKPIText.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.yearsKPIText.Location = new System.Drawing.Point(379, 317);
            this.yearsKPIText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearsKPIText.Name = "yearsKPIText";
            this.yearsKPIText.PasswordChar = '\0';
            this.yearsKPIText.PlaceholderText = "";
            this.yearsKPIText.SelectedText = "";
            this.yearsKPIText.Size = new System.Drawing.Size(242, 40);
            this.yearsKPIText.TabIndex = 33;
            // 
            // rewardKpiComboBox
            // 
            this.rewardKpiComboBox.BackColor = System.Drawing.Color.Transparent;
            this.rewardKpiComboBox.BorderColor = System.Drawing.Color.GhostWhite;
            this.rewardKpiComboBox.BorderRadius = 8;
            this.rewardKpiComboBox.BorderThickness = 2;
            this.rewardKpiComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rewardKpiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rewardKpiComboBox.DropDownWidth = 450;
            this.rewardKpiComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.rewardKpiComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rewardKpiComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rewardKpiComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rewardKpiComboBox.ForeColor = System.Drawing.Color.Black;
            this.rewardKpiComboBox.ItemHeight = 22;
            this.rewardKpiComboBox.Items.AddRange(new object[] { "Грамота Вченої ради", "Почесна грамота Вченої ради", "Почесна відзнака Вченої ради", "почесне звання «Заслужений викладач КПІ» ", "почесне звання «Заслужений професор КПІ» ", "почесне звання «Заслужений працівник КПІ»", "почесна відзнака «Видатний діяч КПІ»", "почесне звання «Почесний доктор КПІ» (№ протоколу ВР КПІ)", "почесна відзнака «За служіння та відданість КПІ» ", "почесна відзнака «За заслуги  перед КПІ» " });
            this.rewardKpiComboBox.Location = new System.Drawing.Point(379, 204);
            this.rewardKpiComboBox.Name = "rewardKpiComboBox";
            this.rewardKpiComboBox.Size = new System.Drawing.Size(243, 28);
            this.rewardKpiComboBox.TabIndex = 34;
            this.rewardKpiComboBox.SelectedIndexChanged += new System.EventHandler(this.rewardKpiComboBox_SelectedIndexChanged);
            // 
            // rewardCountryComboBox
            // 
            this.rewardCountryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.rewardCountryComboBox.BorderColor = System.Drawing.Color.GhostWhite;
            this.rewardCountryComboBox.BorderRadius = 8;
            this.rewardCountryComboBox.BorderThickness = 2;
            this.rewardCountryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rewardCountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rewardCountryComboBox.DropDownWidth = 450;
            this.rewardCountryComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.rewardCountryComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rewardCountryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rewardCountryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rewardCountryComboBox.ForeColor = System.Drawing.Color.Black;
            this.rewardCountryComboBox.ItemHeight = 22;
            this.rewardCountryComboBox.Items.AddRange(new object[] { "Подяка МОН України", "Грамота МОН України", "Почесна грамота МОН України", "нагрудний знак «Відмінник освіти»", "почесне звання «Заслужений діяч науки і техніки України»  ", "Подяка КМ України ", "Грамота КМ України " });
            this.rewardCountryComboBox.Location = new System.Drawing.Point(720, 204);
            this.rewardCountryComboBox.Name = "rewardCountryComboBox";
            this.rewardCountryComboBox.Size = new System.Drawing.Size(243, 28);
            this.rewardCountryComboBox.TabIndex = 35;
            this.rewardCountryComboBox.Visible = false;
            // 
            // yearsStateText
            // 
            this.yearsStateText.BorderColor = System.Drawing.Color.GhostWhite;
            this.yearsStateText.BorderRadius = 8;
            this.yearsStateText.BorderThickness = 2;
            this.yearsStateText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yearsStateText.DefaultText = "";
            this.yearsStateText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yearsStateText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yearsStateText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yearsStateText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yearsStateText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(253)))));
            this.yearsStateText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yearsStateText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.yearsStateText.ForeColor = System.Drawing.Color.Black;
            this.yearsStateText.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.yearsStateText.Location = new System.Drawing.Point(726, 317);
            this.yearsStateText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearsStateText.Name = "yearsStateText";
            this.yearsStateText.PasswordChar = '\0';
            this.yearsStateText.PlaceholderText = "";
            this.yearsStateText.SelectedText = "";
            this.yearsStateText.Size = new System.Drawing.Size(237, 40);
            this.yearsStateText.TabIndex = 36;
            this.yearsStateText.Visible = false;
            // 
            // protocolNumberText
            // 
            this.protocolNumberText.BorderColor = System.Drawing.Color.GhostWhite;
            this.protocolNumberText.BorderRadius = 8;
            this.protocolNumberText.BorderThickness = 2;
            this.protocolNumberText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.protocolNumberText.DefaultText = "";
            this.protocolNumberText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.protocolNumberText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.protocolNumberText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.protocolNumberText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.protocolNumberText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(184)))), ((int)(((byte)(253)))));
            this.protocolNumberText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.protocolNumberText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.protocolNumberText.ForeColor = System.Drawing.Color.Black;
            this.protocolNumberText.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.protocolNumberText.Location = new System.Drawing.Point(385, 481);
            this.protocolNumberText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.protocolNumberText.Name = "protocolNumberText";
            this.protocolNumberText.PasswordChar = '\0';
            this.protocolNumberText.PlaceholderText = "";
            this.protocolNumberText.SelectedText = "";
            this.protocolNumberText.Size = new System.Drawing.Size(236, 40);
            this.protocolNumberText.TabIndex = 37;
            this.protocolNumberText.Visible = false;
            // 
            // ManualFillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.protocolNumberText);
            this.Controls.Add(this.yearsStateText);
            this.Controls.Add(this.rewardCountryComboBox);
            this.Controls.Add(this.rewardKpiComboBox);
            this.Controls.Add(this.yearsKPIText);
            this.Controls.Add(this.facultyComboBox);
            this.Controls.Add(this.middleNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.KpiRadioButton);
            this.Controls.Add(this.yearsStateLabel);
            this.Controls.Add(this.yearsKPILabel);
            this.Controls.Add(this.protocolNumberLabel);
            this.Controls.Add(this.rewardCountryLabel);
            this.Controls.Add(this.rewardKpiLabel);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "ManualFillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPI-Awarding";
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2TextBox protocolNumberText;

        private Guna.UI2.WinForms.Guna2TextBox yearsStateText;

        private Guna.UI2.WinForms.Guna2ComboBox rewardCountryComboBox;

        private Guna.UI2.WinForms.Guna2ComboBox rewardKpiComboBox;

        private Guna.UI2.WinForms.Guna2TextBox yearsKPIText;

        private Guna.UI2.WinForms.Guna2ComboBox facultyComboBox;

        private Guna.UI2.WinForms.Guna2TextBox middleNameText;

        private Guna.UI2.WinForms.Guna2TextBox firstNameText;

        private Guna.UI2.WinForms.Guna2TextBox lastNameText;

        private Guna.UI2.WinForms.Guna2GradientButton saveBut;

        private Guna.UI2.WinForms.Guna2Button backBut;

        private System.Windows.Forms.RadioButton KpiRadioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label yearsStateLabel;
        private System.Windows.Forms.Label yearsKPILabel;
        private System.Windows.Forms.Label protocolNumberLabel;

        private System.Windows.Forms.Label rewardKpiLabel;
        private System.Windows.Forms.Label rewardCountryLabel;

        private System.Windows.Forms.Label facultyLabel;

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;

        private System.Windows.Forms.Label lastNameLabel;

        #endregion
    }
}