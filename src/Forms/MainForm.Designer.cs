using System.ComponentModel;

namespace Program.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.importExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRewardBut = new System.Windows.Forms.Button();
            this.addNew = new System.Windows.Forms.Button();
            this.backBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBut = new System.Windows.Forms.Button();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.badUserBut = new System.Windows.Forms.Button();
            this.restartDefaultDB = new System.Windows.Forms.Button();
            this.clearDbBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardsKpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardsCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsKpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prediction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miniToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.importExcelFileToolStripMenuItem, this.exportExcelFileToolStripMenuItem });
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.miniToolStrip.Size = new System.Drawing.Size(1182, 27);
            this.miniToolStrip.TabIndex = 0;
            this.miniToolStrip.TabStop = true;
            this.miniToolStrip.Text = "miniToolStrip";
            // 
            // importExcelFileToolStripMenuItem
            // 
            this.importExcelFileToolStripMenuItem.Name = "importExcelFileToolStripMenuItem";
            this.importExcelFileToolStripMenuItem.Size = new System.Drawing.Size(127, 23);
            this.importExcelFileToolStripMenuItem.Text = "Import ExcelFile";
            this.importExcelFileToolStripMenuItem.Click += new System.EventHandler(this.importExcelFileToolStripMenuItem_Click);
            // 
            // exportExcelFileToolStripMenuItem
            // 
            this.exportExcelFileToolStripMenuItem.Name = "exportExcelFileToolStripMenuItem";
            this.exportExcelFileToolStripMenuItem.Size = new System.Drawing.Size(125, 23);
            this.exportExcelFileToolStripMenuItem.Text = "Export ExcelFile";
            this.exportExcelFileToolStripMenuItem.Click += new System.EventHandler(this.exportExcelFileToolStripMenuItem_Click);
            // 
            // addRewardBut
            // 
            this.addRewardBut.BackColor = System.Drawing.Color.Lavender;
            this.addRewardBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRewardBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRewardBut.Location = new System.Drawing.Point(1005, 173);
            this.addRewardBut.Name = "addRewardBut";
            this.addRewardBut.Size = new System.Drawing.Size(150, 74);
            this.addRewardBut.TabIndex = 7;
            this.addRewardBut.Text = "Додати нагороду";
            this.addRewardBut.UseVisualStyleBackColor = false;
            this.addRewardBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addRewardBut_MouseClick);
            // 
            // addNew
            // 
            this.addNew.BackColor = System.Drawing.Color.Lavender;
            this.addNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNew.Location = new System.Drawing.Point(1005, 311);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(150, 74);
            this.addNew.TabIndex = 8;
            this.addNew.Text = "Додати";
            this.addNew.UseVisualStyleBackColor = false;
            this.addNew.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addNew_MouseClick);
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.Lavender;
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBut.Location = new System.Drawing.Point(1005, 54);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(150, 50);
            this.backBut.TabIndex = 9;
            this.backBut.Text = "Назад";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1005, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 74);
            this.button1.TabIndex = 10;
            this.button1.Text = "Повний екран";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(37, 54);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(332, 34);
            this.searchTextBox.TabIndex = 11;
            // 
            // searchBut
            // 
            this.searchBut.Location = new System.Drawing.Point(258, 105);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(111, 30);
            this.searchBut.TabIndex = 13;
            this.searchBut.Text = "Пошук";
            this.searchBut.UseVisualStyleBackColor = true;
            this.searchBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBut_MouseClick);
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.DropDownWidth = 420;
            this.searchComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(37, 105);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(190, 30);
            this.searchComboBox.TabIndex = 14;
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.searchComboBox_SelectedIndexChanged);
            // 
            // badUserBut
            // 
            this.badUserBut.BackColor = System.Drawing.Color.Lavender;
            this.badUserBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.badUserBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.badUserBut.Location = new System.Drawing.Point(1005, 563);
            this.badUserBut.Name = "badUserBut";
            this.badUserBut.Size = new System.Drawing.Size(150, 74);
            this.badUserBut.TabIndex = 15;
            this.badUserBut.Text = "Bad users";
            this.badUserBut.UseVisualStyleBackColor = false;
            this.badUserBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.badUserBut_MouseClick);
            // 
            // restartDefaultDB
            // 
            this.restartDefaultDB.BackColor = System.Drawing.Color.Lavender;
            this.restartDefaultDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartDefaultDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartDefaultDB.Location = new System.Drawing.Point(791, 54);
            this.restartDefaultDB.Name = "restartDefaultDB";
            this.restartDefaultDB.Size = new System.Drawing.Size(150, 81);
            this.restartDefaultDB.TabIndex = 16;
            this.restartDefaultDB.Text = "Повернутися до початкової таблиці";
            this.restartDefaultDB.UseVisualStyleBackColor = false;
            this.restartDefaultDB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.restartDefaultDB_MouseClick);
            // 
            // clearDbBut
            // 
            this.clearDbBut.BackColor = System.Drawing.Color.Red;
            this.clearDbBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearDbBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearDbBut.Location = new System.Drawing.Point(583, 50);
            this.clearDbBut.Name = "clearDbBut";
            this.clearDbBut.Size = new System.Drawing.Size(150, 88);
            this.clearDbBut.TabIndex = 17;
            this.clearDbBut.Text = "Очистити базу даних";
            this.clearDbBut.UseVisualStyleBackColor = false;
            this.clearDbBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearDbBut_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(96)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 129;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.number, this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.rewardsKpi, this.rewardsCountry, this.dataGridViewTextBoxColumn3, this.yearsKpi, this.yearsCountry, this.prediction });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(37, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(946, 537);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Transparent;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 129;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 30;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.FillWeight = 30F;
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 250F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Призвіще, ім\'я, по батькові співробітника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Факультет /ННІ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // rewardsKpi
            // 
            this.rewardsKpi.FillWeight = 150F;
            this.rewardsKpi.HeaderText = "Нагорода (Почесне звання, відзнака та грамота)";
            this.rewardsKpi.Name = "rewardsKpi";
            this.rewardsKpi.ReadOnly = true;
            // 
            // rewardsCountry
            // 
            this.rewardsCountry.FillWeight = 150F;
            this.rewardsCountry.HeaderText = "Державна нагорода";
            this.rewardsCountry.Name = "rewardsCountry";
            this.rewardsCountry.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "№ протоколу ВР КПІ ім. Ігоря Сікорського про відзначення";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // yearsKpi
            // 
            this.yearsKpi.FillWeight = 200F;
            this.yearsKpi.HeaderText = "Рік відзначення КПІ";
            this.yearsKpi.Name = "yearsKpi";
            this.yearsKpi.ReadOnly = true;
            // 
            // yearsCountry
            // 
            this.yearsCountry.FillWeight = 200F;
            this.yearsCountry.HeaderText = "Рік призначення державою";
            this.yearsCountry.Name = "yearsCountry";
            this.yearsCountry.ReadOnly = true;
            // 
            // prediction
            // 
            this.prediction.HeaderText = "Прогнозування";
            this.prediction.Name = "prediction";
            this.prediction.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearDbBut);
            this.Controls.Add(this.restartDefaultDB);
            this.Controls.Add(this.badUserBut);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.addRewardBut);
            this.Controls.Add(this.miniToolStrip);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsKpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsKpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn prediction;

        private System.Windows.Forms.Button clearDbBut;

        private System.Windows.Forms.Button restartDefaultDB;

        private System.Windows.Forms.Button searchBut;

        private System.Windows.Forms.Button badUserBut;
        private System.Windows.Forms.ComboBox searchComboBox;

        private System.Windows.Forms.ToolStripMenuItem exportExcelFileToolStripMenuItem;

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button іу;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button backBut;

        private System.Windows.Forms.Button addNew;

        private System.Windows.Forms.Button addRewardBut;

        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem importExcelFileToolStripMenuItem;

        #endregion
    }
}