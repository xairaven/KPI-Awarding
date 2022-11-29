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
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.facultyComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.middleNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.yearsStateText = new System.Windows.Forms.TextBox();
            this.yearsKPIText = new System.Windows.Forms.TextBox();
            this.yearsStateLabel = new System.Windows.Forms.Label();
            this.yearsKPILabel = new System.Windows.Forms.Label();
            this.protocolNumberLabel = new System.Windows.Forms.Label();
            this.protocolNumberText = new System.Windows.Forms.TextBox();
            this.backBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameText.Location = new System.Drawing.Point(41, 137);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(180, 30);
            this.lastNameText.TabIndex = 0;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(41, 108);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(180, 26);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Прізвище:";
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyComboBox.FormattingEnabled = true;
            this.facultyComboBox.Items.AddRange(new object[] { "IAT", "IATE", "ІЕЕ", "ІМЗ", "ІПСА", "ІТС", "ММІ", "ФТІ", "ІХФ", "ПБФ", "РТФ", "ФБМІ", "ФБТ", "ФЕА", "ФЕЛ", "ФІОТ", "ФЛ", "ФММ", "ФМФ", "ФПМ", "ФСП", "ХТФ", "ІСЗЗІ" });
            this.facultyComboBox.Location = new System.Drawing.Point(343, 137);
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(196, 30);
            this.facultyComboBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(41, 186);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(180, 26);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "Ім\'я:";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameLabel.Location = new System.Drawing.Point(41, 265);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(180, 26);
            this.middleNameLabel.TabIndex = 7;
            this.middleNameLabel.Text = "По-батькові:";
            // 
            // facultyLabel
            // 
            this.facultyLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyLabel.Location = new System.Drawing.Point(343, 108);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(196, 26);
            this.facultyLabel.TabIndex = 8;
            this.facultyLabel.Text = "Факультет/ННІ:";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameText.Location = new System.Drawing.Point(41, 215);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(180, 30);
            this.firstNameText.TabIndex = 9;
            // 
            // middleNameText
            // 
            this.middleNameText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameText.Location = new System.Drawing.Point(41, 294);
            this.middleNameText.Name = "middleNameText";
            this.middleNameText.Size = new System.Drawing.Size(180, 30);
            this.middleNameText.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(343, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Нагорода:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 450;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "Грамота Вченої ради", "Почесна грамота Вченої ради", "Почесна відзнака Вченої ради", "почесне звання «Заслужений викладач КПІ» ", "почесне звання «Заслужений професор КПІ» ", "почесне звання «Заслужений працівник КПІ»", "почесна відзнака «Видатний діяч КПІ»", "почесне звання «Почесний доктор КПІ» (№ протоколу ВР КПІ)", "почесна відзнака «За служіння та відданість КПІ» ", "почесна відзнака «За заслуги  перед КПІ» " });
            this.comboBox1.Location = new System.Drawing.Point(343, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 30);
            this.comboBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(343, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Державна нагорода:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownWidth = 450;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] { "Подяка МОН України", "Грамота МОН України", "Почесна грамота МОН України", "нагрудний знак «Відмінник освіти»", "почесне звання «Заслужений діяч науки і техніки України»  ", "Подяка КМ України ", "Грамота КМ України " });
            this.comboBox2.Location = new System.Drawing.Point(343, 294);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 30);
            this.comboBox2.TabIndex = 13;
            // 
            // yearsStateText
            // 
            this.yearsStateText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsStateText.Location = new System.Drawing.Point(684, 294);
            this.yearsStateText.Name = "yearsStateText";
            this.yearsStateText.Size = new System.Drawing.Size(273, 30);
            this.yearsStateText.TabIndex = 20;
            // 
            // yearsKPIText
            // 
            this.yearsKPIText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsKPIText.Location = new System.Drawing.Point(684, 215);
            this.yearsKPIText.Name = "yearsKPIText";
            this.yearsKPIText.Size = new System.Drawing.Size(273, 30);
            this.yearsKPIText.TabIndex = 19;
            // 
            // yearsStateLabel
            // 
            this.yearsStateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsStateLabel.Location = new System.Drawing.Point(684, 265);
            this.yearsStateLabel.Name = "yearsStateLabel";
            this.yearsStateLabel.Size = new System.Drawing.Size(273, 26);
            this.yearsStateLabel.TabIndex = 18;
            this.yearsStateLabel.Text = "Рік призначення державою:";
            // 
            // yearsKPILabel
            // 
            this.yearsKPILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsKPILabel.Location = new System.Drawing.Point(684, 186);
            this.yearsKPILabel.Name = "yearsKPILabel";
            this.yearsKPILabel.Size = new System.Drawing.Size(211, 26);
            this.yearsKPILabel.TabIndex = 17;
            this.yearsKPILabel.Text = "Рік відзначення КПІ:";
            // 
            // protocolNumberLabel
            // 
            this.protocolNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolNumberLabel.Location = new System.Drawing.Point(684, 75);
            this.protocolNumberLabel.Name = "protocolNumberLabel";
            this.protocolNumberLabel.Size = new System.Drawing.Size(273, 59);
            this.protocolNumberLabel.TabIndex = 16;
            this.protocolNumberLabel.Text = "№ протоколу ВР КПІ ім. Ігоря Сікорського про відзначення:";
            // 
            // protocolNumberText
            // 
            this.protocolNumberText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.protocolNumberText.Location = new System.Drawing.Point(684, 137);
            this.protocolNumberText.Name = "protocolNumberText";
            this.protocolNumberText.Size = new System.Drawing.Size(273, 30);
            this.protocolNumberText.TabIndex = 15;
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.Lavender;
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBut.Location = new System.Drawing.Point(1005, 17);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(150, 50);
            this.backBut.TabIndex = 21;
            this.backBut.Text = "Назад";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(41, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 100);
            this.button1.TabIndex = 22;
            this.button1.Text = "Зберегти дані";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SpringGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(855, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 100);
            this.button3.TabIndex = 24;
            this.button3.Text = "Далі";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ManualFillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.yearsStateText);
            this.Controls.Add(this.yearsKPIText);
            this.Controls.Add(this.yearsStateLabel);
            this.Controls.Add(this.yearsKPILabel);
            this.Controls.Add(this.protocolNumberLabel);
            this.Controls.Add(this.protocolNumberText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.middleNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.facultyComboBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Name = "ManualFillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManualFillingForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox yearsStateText;
        private System.Windows.Forms.TextBox yearsKPIText;
        private System.Windows.Forms.Label yearsStateLabel;
        private System.Windows.Forms.Label yearsKPILabel;
        private System.Windows.Forms.Label protocolNumberLabel;
        private System.Windows.Forms.TextBox protocolNumberText;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox middleNameText;

        private System.Windows.Forms.Label facultyLabel;

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;

        private System.Windows.Forms.ComboBox facultyComboBox;

        private System.Windows.Forms.Label lastNameLabel;

        private System.Windows.Forms.TextBox lastNameText;

        #endregion
    }
}