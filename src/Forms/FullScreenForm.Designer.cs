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
            this.backBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardKpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearKpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.Lavender;
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBut.Location = new System.Drawing.Point(1231, 41);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(150, 50);
            this.backBut.TabIndex = 10;
            this.backBut.Text = "Назад";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.fullName, this.facultet, this.rewardKpi, this.rewardCountry, this.numberProtocol, this.yearKpi, this.yearCountry });
            this.dataGridView1.Location = new System.Drawing.Point(50, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1331, 714);
            this.dataGridView1.TabIndex = 11;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Призвіще, ім\'я, по батькові співробітника";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // facultet
            // 
            this.facultet.HeaderText = "Факультет/ННІ";
            this.facultet.Name = "facultet";
            this.facultet.ReadOnly = true;
            // 
            // rewardKpi
            // 
            this.rewardKpi.HeaderText = "Нагорода (Почесне звання, відзнака та грамота)";
            this.rewardKpi.Name = "rewardKpi";
            this.rewardKpi.ReadOnly = true;
            // 
            // rewardCountry
            // 
            this.rewardCountry.HeaderText = "Державна нагорода";
            this.rewardCountry.Name = "rewardCountry";
            this.rewardCountry.ReadOnly = true;
            // 
            // numberProtocol
            // 
            this.numberProtocol.HeaderText = "№ протоколу ВР КПІ ім. Ігоря Сікорського про відзначення";
            this.numberProtocol.Name = "numberProtocol";
            this.numberProtocol.ReadOnly = true;
            // 
            // yearKpi
            // 
            this.yearKpi.HeaderText = "Рік відзначення КПІ";
            this.yearKpi.Name = "yearKpi";
            this.yearKpi.ReadOnly = true;
            // 
            // yearCountry
            // 
            this.yearCountry.HeaderText = "Рік призначення державою";
            this.yearCountry.Name = "yearCountry";
            this.yearCountry.ReadOnly = true;
            // 
            // FullScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1422, 853);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBut);
            this.Name = "FullScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn numberRow;

        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultet;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardKpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearKpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearCountry;

        private System.Windows.Forms.Button backBut;

        public System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}