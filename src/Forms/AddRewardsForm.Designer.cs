using System.ComponentModel;

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
            this.backBut = new System.Windows.Forms.Button();
            this.startBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.countryRadioButton = new System.Windows.Forms.RadioButton();
            this.KpiRadioButton = new System.Windows.Forms.RadioButton();
            this.yearsStateText = new System.Windows.Forms.TextBox();
            this.yearsKPIText = new System.Windows.Forms.TextBox();
            this.yearsStateLabel = new System.Windows.Forms.Label();
            this.yearsKPILabel = new System.Windows.Forms.Label();
            this.protocolNumberLabel = new System.Windows.Forms.Label();
            this.protocolNumberText = new System.Windows.Forms.TextBox();
            this.rewardCountryLabel = new System.Windows.Forms.Label();
            this.rewardCountryComboBox = new System.Windows.Forms.ComboBox();
            this.rewardKpiLabel = new System.Windows.Forms.Label();
            this.rewardKpiComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // personListBox
            // 
            this.personListBox.BackColor = System.Drawing.Color.BlueViolet;
            this.personListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personListBox.ForeColor = System.Drawing.Color.Lime;
            this.personListBox.FormattingEnabled = true;
            this.personListBox.ItemHeight = 29;
            this.personListBox.Location = new System.Drawing.Point(12, 26);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(333, 493);
            this.personListBox.TabIndex = 45;
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.Lavender;
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBut.Location = new System.Drawing.Point(1009, 26);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(150, 50);
            this.backBut.TabIndex = 46;
            this.backBut.Text = "Назад";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
            // 
            // startBut
            // 
            this.startBut.BackColor = System.Drawing.Color.SpringGreen;
            this.startBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBut.Location = new System.Drawing.Point(826, 395);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(300, 100);
            this.startBut.TabIndex = 47;
            this.startBut.Text = "Додати";
            this.startBut.UseVisualStyleBackColor = false;
            this.startBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startBut_MouseClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(449, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 60;
            this.label3.Text = "Нагорода:";
            // 
            // countryRadioButton
            // 
            this.countryRadioButton.Location = new System.Drawing.Point(588, 130);
            this.countryRadioButton.Name = "countryRadioButton";
            this.countryRadioButton.Size = new System.Drawing.Size(104, 24);
            this.countryRadioButton.TabIndex = 59;
            this.countryRadioButton.Text = "Державна";
            this.countryRadioButton.UseVisualStyleBackColor = true;
            this.countryRadioButton.CheckedChanged += new System.EventHandler(this.countryRadioButton_CheckedChanged);
            // 
            // KpiRadioButton
            // 
            this.KpiRadioButton.Checked = true;
            this.KpiRadioButton.Location = new System.Drawing.Point(588, 100);
            this.KpiRadioButton.Name = "KpiRadioButton";
            this.KpiRadioButton.Size = new System.Drawing.Size(104, 24);
            this.KpiRadioButton.TabIndex = 58;
            this.KpiRadioButton.TabStop = true;
            this.KpiRadioButton.Text = "КПІ";
            this.KpiRadioButton.UseVisualStyleBackColor = true;
            this.KpiRadioButton.CheckedChanged += new System.EventHandler(this.KpiRadioButton_CheckedChanged);
            // 
            // yearsStateText
            // 
            this.yearsStateText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsStateText.Location = new System.Drawing.Point(826, 295);
            this.yearsStateText.Name = "yearsStateText";
            this.yearsStateText.Size = new System.Drawing.Size(273, 30);
            this.yearsStateText.TabIndex = 57;
            this.yearsStateText.Visible = false;
            // 
            // yearsKPIText
            // 
            this.yearsKPIText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsKPIText.Location = new System.Drawing.Point(449, 296);
            this.yearsKPIText.Name = "yearsKPIText";
            this.yearsKPIText.Size = new System.Drawing.Size(273, 30);
            this.yearsKPIText.TabIndex = 56;
            // 
            // yearsStateLabel
            // 
            this.yearsStateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsStateLabel.Location = new System.Drawing.Point(826, 267);
            this.yearsStateLabel.Name = "yearsStateLabel";
            this.yearsStateLabel.Size = new System.Drawing.Size(273, 26);
            this.yearsStateLabel.TabIndex = 55;
            this.yearsStateLabel.Text = "Рік призначення державою:";
            this.yearsStateLabel.Visible = false;
            // 
            // yearsKPILabel
            // 
            this.yearsKPILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsKPILabel.Location = new System.Drawing.Point(449, 267);
            this.yearsKPILabel.Name = "yearsKPILabel";
            this.yearsKPILabel.Size = new System.Drawing.Size(211, 26);
            this.yearsKPILabel.TabIndex = 54;
            this.yearsKPILabel.Text = "Рік відзначення КПІ:";
            // 
            // protocolNumberLabel
            // 
            this.protocolNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolNumberLabel.Location = new System.Drawing.Point(449, 349);
            this.protocolNumberLabel.Name = "protocolNumberLabel";
            this.protocolNumberLabel.Size = new System.Drawing.Size(273, 59);
            this.protocolNumberLabel.TabIndex = 53;
            this.protocolNumberLabel.Text = "№ протоколу ВР КПІ ім. Ігоря Сікорського про відзначення:";
            this.protocolNumberLabel.Visible = false;
            // 
            // protocolNumberText
            // 
            this.protocolNumberText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolNumberText.Location = new System.Drawing.Point(449, 411);
            this.protocolNumberText.Name = "protocolNumberText";
            this.protocolNumberText.Size = new System.Drawing.Size(273, 30);
            this.protocolNumberText.TabIndex = 52;
            this.protocolNumberText.Visible = false;
            // 
            // rewardCountryLabel
            // 
            this.rewardCountryLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardCountryLabel.Location = new System.Drawing.Point(826, 188);
            this.rewardCountryLabel.Name = "rewardCountryLabel";
            this.rewardCountryLabel.Size = new System.Drawing.Size(196, 26);
            this.rewardCountryLabel.TabIndex = 51;
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
            this.rewardCountryComboBox.Location = new System.Drawing.Point(826, 217);
            this.rewardCountryComboBox.Name = "rewardCountryComboBox";
            this.rewardCountryComboBox.Size = new System.Drawing.Size(273, 30);
            this.rewardCountryComboBox.TabIndex = 50;
            this.rewardCountryComboBox.Visible = false;
            // 
            // rewardKpiLabel
            // 
            this.rewardKpiLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardKpiLabel.Location = new System.Drawing.Point(449, 188);
            this.rewardKpiLabel.Name = "rewardKpiLabel";
            this.rewardKpiLabel.Size = new System.Drawing.Size(196, 26);
            this.rewardKpiLabel.TabIndex = 49;
            this.rewardKpiLabel.Text = "Нагорода:";
            // 
            // rewardKpiComboBox
            // 
            this.rewardKpiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rewardKpiComboBox.DropDownWidth = 450;
            this.rewardKpiComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rewardKpiComboBox.FormattingEnabled = true;
            this.rewardKpiComboBox.Items.AddRange(new object[] { "", "Грамота Вченої ради", "Почесна грамота Вченої ради", "Почесна відзнака Вченої ради", "почесне звання «Заслужений викладач КПІ» ", "почесне звання «Заслужений професор КПІ» ", "почесне звання «Заслужений працівник КПІ»", "почесна відзнака «Видатний діяч КПІ»", "почесне звання «Почесний доктор КПІ» (№ протоколу ВР КПІ)", "почесна відзнака «За служіння та відданість КПІ» ", "почесна відзнака «За заслуги  перед КПІ» " });
            this.rewardKpiComboBox.Location = new System.Drawing.Point(449, 217);
            this.rewardKpiComboBox.Name = "rewardKpiComboBox";
            this.rewardKpiComboBox.Size = new System.Drawing.Size(273, 30);
            this.rewardKpiComboBox.TabIndex = 48;
            this.rewardKpiComboBox.SelectedIndexChanged += new System.EventHandler(this.rewardKpiComboBox_SelectedIndexChanged);
            // 
            // AddRewardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countryRadioButton);
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
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.personListBox);
            this.Name = "AddRewardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRewardsForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton countryRadioButton;
        private System.Windows.Forms.RadioButton KpiRadioButton;
        private System.Windows.Forms.TextBox yearsStateText;
        private System.Windows.Forms.TextBox yearsKPIText;
        private System.Windows.Forms.Label yearsStateLabel;
        private System.Windows.Forms.Label yearsKPILabel;
        private System.Windows.Forms.Label protocolNumberLabel;
        private System.Windows.Forms.TextBox protocolNumberText;
        private System.Windows.Forms.Label rewardCountryLabel;
        private System.Windows.Forms.ComboBox rewardCountryComboBox;
        private System.Windows.Forms.Label rewardKpiLabel;
        private System.Windows.Forms.ComboBox rewardKpiComboBox;

        private System.Windows.Forms.Button startBut;

        private System.Windows.Forms.Button backBut;

        private System.Windows.Forms.ListBox personListBox;

        #endregion
    }
}