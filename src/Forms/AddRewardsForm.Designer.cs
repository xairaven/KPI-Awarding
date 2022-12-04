using System.ComponentModel;
using Program.UI;

namespace Program.Forms
{
    partial class AddRewardsForm
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
            this.personListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearsStateLabel = new System.Windows.Forms.Label();
            this.yearsKPILabel = new System.Windows.Forms.Label();
            this.protocolNumberLabel = new System.Windows.Forms.Label();
            this.rewardCountryLabel = new System.Windows.Forms.Label();
            this.rewardKpiLabel = new System.Windows.Forms.Label();
            this.rewardKpiComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.yearsKPIText = new Guna.UI2.WinForms.Guna2TextBox();
            this.protocolNumberText = new Guna.UI2.WinForms.Guna2TextBox();
            this.rewardCountryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.yearsStateText = new Guna.UI2.WinForms.Guna2TextBox();
            this.countryRadioButton = new System.Windows.Forms.RadioButton();
            this.KpiRadioButton = new System.Windows.Forms.RadioButton();
            this.backBut = new ButtonZoom();
            this.startBut = new GradientZoom();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personListBox
            // 
            this.personListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(100)))), ((int)(((byte)(207)))));
            this.personListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personListBox.ForeColor = System.Drawing.Color.MintCream;
            this.personListBox.FormattingEnabled = true;
            this.personListBox.ItemHeight = 28;
            this.personListBox.Location = new System.Drawing.Point(38, 27);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(333, 476);
            this.personListBox.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(472, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 60;
            this.label3.Text = "Нагорода:";
            // 
            // yearsStateLabel
            // 
            this.yearsStateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.yearsStateLabel.Location = new System.Drawing.Point(883, 267);
            this.yearsStateLabel.Name = "yearsStateLabel";
            this.yearsStateLabel.Size = new System.Drawing.Size(243, 59);
            this.yearsStateLabel.TabIndex = 55;
            this.yearsStateLabel.Text = "Рік призначення державою:";
            this.yearsStateLabel.Visible = false;
            // 
            // yearsKPILabel
            // 
            this.yearsKPILabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.yearsKPILabel.Location = new System.Drawing.Point(472, 267);
            this.yearsKPILabel.Name = "yearsKPILabel";
            this.yearsKPILabel.Size = new System.Drawing.Size(243, 26);
            this.yearsKPILabel.TabIndex = 54;
            this.yearsKPILabel.Text = "Рік відзначення КПІ:";
            // 
            // protocolNumberLabel
            // 
            this.protocolNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.protocolNumberLabel.Location = new System.Drawing.Point(472, 349);
            this.protocolNumberLabel.Name = "protocolNumberLabel";
            this.protocolNumberLabel.Size = new System.Drawing.Size(236, 90);
            this.protocolNumberLabel.TabIndex = 53;
            this.protocolNumberLabel.Text = "№ протоколу ВР КПІ ім. Ігоря Сікорського про відзначення:";
            this.protocolNumberLabel.Visible = false;
            // 
            // rewardCountryLabel
            // 
            this.rewardCountryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rewardCountryLabel.Location = new System.Drawing.Point(883, 188);
            this.rewardCountryLabel.Name = "rewardCountryLabel";
            this.rewardCountryLabel.Size = new System.Drawing.Size(243, 26);
            this.rewardCountryLabel.TabIndex = 51;
            this.rewardCountryLabel.Text = "Державна нагорода:";
            this.rewardCountryLabel.Visible = false;
            // 
            // rewardKpiLabel
            // 
            this.rewardKpiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rewardKpiLabel.Location = new System.Drawing.Point(472, 188);
            this.rewardKpiLabel.Name = "rewardKpiLabel";
            this.rewardKpiLabel.Size = new System.Drawing.Size(236, 26);
            this.rewardKpiLabel.TabIndex = 49;
            this.rewardKpiLabel.Text = "Нагорода:";
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
            this.rewardKpiComboBox.Items.AddRange(new object[] { "-", "Грамота Вченої ради", "Почесна грамота Вченої ради", "Почесна відзнака Вченої ради", "почесне звання «Заслужений викладач КПІ» ", "почесне звання «Заслужений професор КПІ» ", "почесне звання «Заслужений працівник КПІ»", "почесна відзнака «Видатний діяч КПІ»", "почесне звання «Почесний доктор КПІ» (№ протоколу ВР КПІ)", "почесна відзнака «За служіння та відданість КПІ» ", "почесна відзнака «За заслуги  перед КПІ» " });
            this.rewardKpiComboBox.Location = new System.Drawing.Point(472, 219);
            this.rewardKpiComboBox.Name = "rewardKpiComboBox";
            this.rewardKpiComboBox.Size = new System.Drawing.Size(243, 28);
            this.rewardKpiComboBox.TabIndex = 61;
            this.rewardKpiComboBox.SelectedIndexChanged += new System.EventHandler(this.rewardKpiComboBox_SelectedIndexChanged);
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
            this.yearsKPIText.Location = new System.Drawing.Point(472, 305);
            this.yearsKPIText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearsKPIText.Name = "yearsKPIText";
            this.yearsKPIText.PasswordChar = '\0';
            this.yearsKPIText.PlaceholderText = "";
            this.yearsKPIText.SelectedText = "";
            this.yearsKPIText.Size = new System.Drawing.Size(242, 40);
            this.yearsKPIText.TabIndex = 62;
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
            this.protocolNumberText.Location = new System.Drawing.Point(472, 443);
            this.protocolNumberText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.protocolNumberText.Name = "protocolNumberText";
            this.protocolNumberText.PasswordChar = '\0';
            this.protocolNumberText.PlaceholderText = "";
            this.protocolNumberText.SelectedText = "";
            this.protocolNumberText.Size = new System.Drawing.Size(236, 40);
            this.protocolNumberText.TabIndex = 63;
            this.protocolNumberText.Visible = false;
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
            this.rewardCountryComboBox.Items.AddRange(new object[] { "-", "Подяка МОН України", "Грамота МОН України", "Почесна грамота МОН України", "нагрудний знак «Відмінник освіти»", "почесне звання «Заслужений діяч науки і техніки України»  ", "Подяка КМ України ", "Грамота КМ України " });
            this.rewardCountryComboBox.Location = new System.Drawing.Point(883, 219);
            this.rewardCountryComboBox.Name = "rewardCountryComboBox";
            this.rewardCountryComboBox.Size = new System.Drawing.Size(243, 28);
            this.rewardCountryComboBox.TabIndex = 64;
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
            this.yearsStateText.Location = new System.Drawing.Point(889, 330);
            this.yearsStateText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearsStateText.Name = "yearsStateText";
            this.yearsStateText.PasswordChar = '\0';
            this.yearsStateText.PlaceholderText = "";
            this.yearsStateText.SelectedText = "";
            this.yearsStateText.Size = new System.Drawing.Size(237, 40);
            this.yearsStateText.TabIndex = 65;
            this.yearsStateText.Visible = false;
            // 
            // countryRadioButton
            // 
            this.countryRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryRadioButton.Location = new System.Drawing.Point(611, 144);
            this.countryRadioButton.Name = "countryRadioButton";
            this.countryRadioButton.Size = new System.Drawing.Size(124, 24);
            this.countryRadioButton.TabIndex = 67;
            this.countryRadioButton.Text = "Державна";
            this.countryRadioButton.UseVisualStyleBackColor = true;
            this.countryRadioButton.CheckedChanged += new System.EventHandler(this.countryRadioButton_CheckedChanged);
            // 
            // KpiRadioButton
            // 
            this.KpiRadioButton.Checked = true;
            this.KpiRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KpiRadioButton.Location = new System.Drawing.Point(611, 114);
            this.KpiRadioButton.Name = "KpiRadioButton";
            this.KpiRadioButton.Size = new System.Drawing.Size(124, 24);
            this.KpiRadioButton.TabIndex = 66;
            this.KpiRadioButton.TabStop = true;
            this.KpiRadioButton.Text = "КПІ";
            this.KpiRadioButton.UseVisualStyleBackColor = true;
            this.KpiRadioButton.CheckedChanged += new System.EventHandler(this.KpiRadioButton_CheckedChanged);
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
            this.backBut.Location = new System.Drawing.Point(926, 26);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(200, 60);
            this.backBut.TabIndex = 68;
            this.backBut.Text = "Назад";
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
            // 
            // startBut
            // 
            this.startBut.BorderColor = System.Drawing.Color.SeaGreen;
            this.startBut.BorderRadius = 20;
            this.startBut.BorderThickness = 2;
            this.startBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startBut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startBut.FillColor = System.Drawing.Color.LightGreen;
            this.startBut.FillColor2 = System.Drawing.Color.MediumAquamarine;
            this.startBut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBut.ForeColor = System.Drawing.Color.White;
            this.startBut.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.startBut.Location = new System.Drawing.Point(891, 443);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(235, 60);
            this.startBut.TabIndex = 69;
            this.startBut.Text = "Зберегти";
            this.startBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startBut_MouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(460, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 65);
            this.label1.TabIndex = 70;
            // 
            // AddRewardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.countryRadioButton);
            this.Controls.Add(this.KpiRadioButton);
            this.Controls.Add(this.yearsStateText);
            this.Controls.Add(this.rewardCountryComboBox);
            this.Controls.Add(this.protocolNumberText);
            this.Controls.Add(this.yearsKPIText);
            this.Controls.Add(this.rewardKpiComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearsStateLabel);
            this.Controls.Add(this.yearsKPILabel);
            this.Controls.Add(this.protocolNumberLabel);
            this.Controls.Add(this.rewardCountryLabel);
            this.Controls.Add(this.rewardKpiLabel);
            this.Controls.Add(this.personListBox);
            this.Name = "AddRewardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRewardsForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private Guna.UI2.WinForms.Guna2GradientButton startBut;

        private Guna.UI2.WinForms.Guna2Button backBut;

        private System.Windows.Forms.RadioButton countryRadioButton;
        private System.Windows.Forms.RadioButton KpiRadioButton;

        private Guna.UI2.WinForms.Guna2TextBox yearsStateText;

        private Guna.UI2.WinForms.Guna2ComboBox rewardCountryComboBox;

        private Guna.UI2.WinForms.Guna2TextBox protocolNumberText;

        private Guna.UI2.WinForms.Guna2TextBox yearsKPIText;

        private Guna.UI2.WinForms.Guna2ComboBox rewardKpiComboBox;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label yearsStateLabel;
        private System.Windows.Forms.Label yearsKPILabel;
        private System.Windows.Forms.Label protocolNumberLabel;
        private System.Windows.Forms.Label rewardCountryLabel;
        private System.Windows.Forms.Label rewardKpiLabel;

        private System.Windows.Forms.ListBox personListBox;

        #endregion
    }
}