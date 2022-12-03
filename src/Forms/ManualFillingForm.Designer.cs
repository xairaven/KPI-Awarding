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
            this.facultyComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.rewardKpiLabel = new System.Windows.Forms.Label();
            this.rewardKpiComboBox = new System.Windows.Forms.ComboBox();
            this.rewardCountryLabel = new System.Windows.Forms.Label();
            this.rewardCountryComboBox = new System.Windows.Forms.ComboBox();
            this.yearsStateText = new System.Windows.Forms.TextBox();
            this.yearsKPIText = new System.Windows.Forms.TextBox();
            this.yearsStateLabel = new System.Windows.Forms.Label();
            this.yearsKPILabel = new System.Windows.Forms.Label();
            this.protocolNumberLabel = new System.Windows.Forms.Label();
            this.protocolNumberText = new System.Windows.Forms.TextBox();
            this.KpiRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.backBut = new Guna.UI2.WinForms.Guna2Button();
            this.saveBut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lastNameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstNameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.middleNameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(41, 74);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(242, 36);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Прізвище:";
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyComboBox.FormattingEnabled = true;
            this.facultyComboBox.Items.AddRange(new object[] { "", "IAT", "IATE", "ІЕЕ", "ІМЗ", "ІПСА", "ІТС", "ММІ", "ФТІ", "ІХФ", "ПБФ", "РТФ", "ФБМІ", "ФБТ", "ФЕА", "ФЕЛ", "ФІОТ", "ФЛ", "ФММ", "ФМФ", "ФПМ", "ФСП", "ХТФ", "ІСЗЗІ" });
            this.facultyComboBox.Location = new System.Drawing.Point(41, 456);
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(196, 30);
            this.facultyComboBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(41, 176);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(242, 36);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "Ім\'я:";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameLabel.Location = new System.Drawing.Point(41, 295);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(242, 36);
            this.middleNameLabel.TabIndex = 7;
            this.middleNameLabel.Text = "По-батькові:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyLabel.Location = new System.Drawing.Point(41, 427);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(196, 26);
            this.facultyLabel.TabIndex = 8;
            this.facultyLabel.Text = "Факультет/ННІ:";
            // 
            // rewardKpiLabel
            // 
            this.rewardKpiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardKpiLabel.Location = new System.Drawing.Point(343, 186);
            this.rewardKpiLabel.Name = "rewardKpiLabel";
            this.rewardKpiLabel.Size = new System.Drawing.Size(196, 26);
            this.rewardKpiLabel.TabIndex = 12;
            this.rewardKpiLabel.Text = "Нагорода:";
            // 
            // rewardKpiComboBox
            // 
            this.rewardKpiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rewardKpiComboBox.DropDownWidth = 450;
            this.rewardKpiComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardKpiComboBox.FormattingEnabled = true;
            this.rewardKpiComboBox.Items.AddRange(new object[] { "", "Грамота Вченої ради", "Почесна грамота Вченої ради", "Почесна відзнака Вченої ради", "почесне звання «Заслужений викладач КПІ» ", "почесне звання «Заслужений професор КПІ» ", "почесне звання «Заслужений працівник КПІ»", "почесна відзнака «Видатний діяч КПІ»", "почесне звання «Почесний доктор КПІ» (№ протоколу ВР КПІ)", "почесна відзнака «За служіння та відданість КПІ» ", "почесна відзнака «За заслуги  перед КПІ» " });
            this.rewardKpiComboBox.Location = new System.Drawing.Point(343, 215);
            this.rewardKpiComboBox.Name = "rewardKpiComboBox";
            this.rewardKpiComboBox.Size = new System.Drawing.Size(273, 30);
            this.rewardKpiComboBox.TabIndex = 11;
            this.rewardKpiComboBox.SelectedIndexChanged += new System.EventHandler(this.rewardKpiComboBox_SelectedIndexChanged);
            // 
            // rewardCountryLabel
            // 
            this.rewardCountryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardCountryLabel.Location = new System.Drawing.Point(720, 186);
            this.rewardCountryLabel.Name = "rewardCountryLabel";
            this.rewardCountryLabel.Size = new System.Drawing.Size(273, 26);
            this.rewardCountryLabel.TabIndex = 14;
            this.rewardCountryLabel.Text = "Державна нагорода:";
            this.rewardCountryLabel.Visible = false;
            // 
            // rewardCountryComboBox
            // 
            this.rewardCountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rewardCountryComboBox.DropDownWidth = 450;
            this.rewardCountryComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardCountryComboBox.FormattingEnabled = true;
            this.rewardCountryComboBox.Items.AddRange(new object[] { "", "Подяка МОН України", "Грамота МОН України", "Почесна грамота МОН України", "нагрудний знак «Відмінник освіти»", "почесне звання «Заслужений діяч науки і техніки України»  ", "Подяка КМ України ", "Грамота КМ України " });
            this.rewardCountryComboBox.Location = new System.Drawing.Point(720, 215);
            this.rewardCountryComboBox.Name = "rewardCountryComboBox";
            this.rewardCountryComboBox.Size = new System.Drawing.Size(273, 30);
            this.rewardCountryComboBox.TabIndex = 13;
            this.rewardCountryComboBox.Visible = false;
            // 
            // yearsStateText
            // 
            this.yearsStateText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsStateText.Location = new System.Drawing.Point(720, 345);
            this.yearsStateText.Name = "yearsStateText";
            this.yearsStateText.Size = new System.Drawing.Size(273, 30);
            this.yearsStateText.TabIndex = 20;
            this.yearsStateText.Visible = false;
            // 
            // yearsKPIText
            // 
            this.yearsKPIText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsKPIText.Location = new System.Drawing.Point(343, 294);
            this.yearsKPIText.Name = "yearsKPIText";
            this.yearsKPIText.Size = new System.Drawing.Size(273, 30);
            this.yearsKPIText.TabIndex = 19;
            // 
            // yearsStateLabel
            // 
            this.yearsStateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsStateLabel.Location = new System.Drawing.Point(720, 265);
            this.yearsStateLabel.Name = "yearsStateLabel";
            this.yearsStateLabel.Size = new System.Drawing.Size(273, 59);
            this.yearsStateLabel.TabIndex = 18;
            this.yearsStateLabel.Text = "Рік призначення державою:";
            this.yearsStateLabel.Visible = false;
            // 
            // yearsKPILabel
            // 
            this.yearsKPILabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsKPILabel.Location = new System.Drawing.Point(343, 265);
            this.yearsKPILabel.Name = "yearsKPILabel";
            this.yearsKPILabel.Size = new System.Drawing.Size(211, 26);
            this.yearsKPILabel.TabIndex = 17;
            this.yearsKPILabel.Text = "Рік відзначення КПІ:";
            // 
            // protocolNumberLabel
            // 
            this.protocolNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolNumberLabel.Location = new System.Drawing.Point(343, 347);
            this.protocolNumberLabel.Name = "protocolNumberLabel";
            this.protocolNumberLabel.Size = new System.Drawing.Size(273, 93);
            this.protocolNumberLabel.TabIndex = 16;
            this.protocolNumberLabel.Text = "№ протоколу ВР КПІ ім. Ігоря Сікорського про відзначення:";
            this.protocolNumberLabel.Visible = false;
            // 
            // protocolNumberText
            // 
            this.protocolNumberText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolNumberText.Location = new System.Drawing.Point(328, 456);
            this.protocolNumberText.Name = "protocolNumberText";
            this.protocolNumberText.Size = new System.Drawing.Size(273, 30);
            this.protocolNumberText.TabIndex = 15;
            this.protocolNumberText.Visible = false;
            // 
            // KpiRadioButton
            // 
            this.KpiRadioButton.Checked = true;
            this.KpiRadioButton.Location = new System.Drawing.Point(482, 98);
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
            this.radioButton2.Location = new System.Drawing.Point(482, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.Text = "Державна";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(343, 108);
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
            this.lastNameText.Location = new System.Drawing.Point(41, 114);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.PasswordChar = '\0';
            this.lastNameText.PlaceholderText = "";
            this.lastNameText.SelectedText = "";
            this.lastNameText.Size = new System.Drawing.Size(242, 44);
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
            this.firstNameText.Location = new System.Drawing.Point(41, 215);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.PasswordChar = '\0';
            this.firstNameText.PlaceholderText = "";
            this.firstNameText.SelectedText = "";
            this.firstNameText.Size = new System.Drawing.Size(242, 44);
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
            this.middleNameText.Location = new System.Drawing.Point(41, 335);
            this.middleNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.PasswordChar = '\0';
            this.middleNameText.PlaceholderText = "";
            this.middleNameText.SelectedText = "";
            this.middleNameText.Size = new System.Drawing.Size(242, 44);
            this.middleNameText.TabIndex = 31;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.GhostWhite;
            this.guna2ComboBox1.BorderRadius = 8;
            this.guna2ComboBox1.BorderThickness = 2;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox1.ItemHeight = 38;
            this.guna2ComboBox1.Items.AddRange(new object[] { "IAT", "IATE", "ІЕЕ", "ІМЗ", "ІПСА", "ІТС", "ММІ", "ФТІ", "ІХФ", "ПБФ", "РТФ", "ФБМІ", "ФБТ", "ФЕА", "ФЕЛ", "ФІОТ", "ФЛ", "ФММ", "ФМФ", "ФПМ", "ФСП", "ХТФ", "ІСЗЗІ" });
            this.guna2ComboBox1.Location = new System.Drawing.Point(312, 27);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(242, 44);
            this.guna2ComboBox1.TabIndex = 32;
            // 
            // ManualFillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.middleNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.KpiRadioButton);
            this.Controls.Add(this.yearsStateText);
            this.Controls.Add(this.yearsKPIText);
            this.Controls.Add(this.yearsStateLabel);
            this.Controls.Add(this.yearsKPILabel);
            this.Controls.Add(this.protocolNumberLabel);
            this.Controls.Add(this.protocolNumberText);
            this.Controls.Add(this.rewardCountryLabel);
            this.Controls.Add(this.rewardCountryComboBox);
            this.Controls.Add(this.rewardKpiLabel);
            this.Controls.Add(this.rewardKpiComboBox);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.facultyComboBox);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "ManualFillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPI-Awarding";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;

        private Guna.UI2.WinForms.Guna2TextBox middleNameText;

        private Guna.UI2.WinForms.Guna2TextBox firstNameText;

        private Guna.UI2.WinForms.Guna2TextBox lastNameText;

        private Guna.UI2.WinForms.Guna2GradientButton saveBut;

        private Guna.UI2.WinForms.Guna2Button backBut;

        private System.Windows.Forms.RadioButton KpiRadioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox yearsStateText;
        private System.Windows.Forms.TextBox yearsKPIText;
        private System.Windows.Forms.Label yearsStateLabel;
        private System.Windows.Forms.Label yearsKPILabel;
        private System.Windows.Forms.Label protocolNumberLabel;
        private System.Windows.Forms.TextBox protocolNumberText;

        private System.Windows.Forms.Label rewardKpiLabel;
        private System.Windows.Forms.ComboBox rewardKpiComboBox;
        private System.Windows.Forms.Label rewardCountryLabel;
        private System.Windows.Forms.ComboBox rewardCountryComboBox;

        private System.Windows.Forms.Label facultyLabel;

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;

        private System.Windows.Forms.ComboBox facultyComboBox;

        private System.Windows.Forms.Label lastNameLabel;

        #endregion
    }
}