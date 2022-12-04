using System.ComponentModel;

namespace Program.Forms
{
    partial class FullScreenForm
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
            this.backBut = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardsKpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardsCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsKpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prediction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.backBut.Location = new System.Drawing.Point(1236, 40);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(200, 60);
            this.backBut.TabIndex = 12;
            this.backBut.Text = "Назад";
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 129;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.number, this.fullName, this.facultet, this.rewardsKpi, this.rewardsCountry, this.numberProtocol, this.yearsKpi, this.yearsCountry, this.prediction });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(47, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1389, 663);
            this.dataGridView1.TabIndex = 13;
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
            // fullName
            // 
            this.fullName.FillWeight = 250F;
            this.fullName.HeaderText = "Призвіще, ім\'я, по батькові співробітника";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // facultet
            // 
            this.facultet.HeaderText = "Факультет /ННІ";
            this.facultet.Name = "facultet";
            this.facultet.ReadOnly = true;
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
            // numberProtocol
            // 
            this.numberProtocol.FillWeight = 200F;
            this.numberProtocol.HeaderText = "№ протоколу ВР КПІ ім. Ігоря Сікорського про відзначення";
            this.numberProtocol.Name = "numberProtocol";
            this.numberProtocol.ReadOnly = true;
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
            // FullScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBut);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FullScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn prediction;

        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultet;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsKpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsKpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsCountry;

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;

        private Guna.UI2.WinForms.Guna2Button backBut;

        private System.Windows.Forms.DataGridViewTextBoxColumn numberRow;

        #endregion
    }
}