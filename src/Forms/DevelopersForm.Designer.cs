using System.ComponentModel;

namespace Program.Forms
{
    partial class DevelopersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevelopersForm));
            this.dataDev = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telegram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDev)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDev
            // 
            this.dataDev.AllowUserToResizeColumns = false;
            this.dataDev.AllowUserToResizeRows = false;
            this.dataDev.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDev.ColumnHeadersHeight = 30;
            this.dataDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataDev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.firstName, this.lastName, this.telegram, this.post });
            this.dataDev.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDev.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDev.EnableHeadersVisualStyles = false;
            this.dataDev.Location = new System.Drawing.Point(141, 171);
            this.dataDev.Name = "dataDev";
            this.dataDev.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDev.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataDev.RowTemplate.Height = 24;
            this.dataDev.Size = new System.Drawing.Size(909, 261);
            this.dataDev.TabIndex = 0;
            // 
            // firstName
            // 
            this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.firstName.HeaderText = "Ім\'я";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 150;
            // 
            // lastName
            // 
            this.lastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lastName.HeaderText = "Прізвище";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Width = 150;
            // 
            // telegram
            // 
            this.telegram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telegram.HeaderText = "Телеграм";
            this.telegram.Name = "telegram";
            this.telegram.ReadOnly = true;
            this.telegram.Width = 150;
            // 
            // post
            // 
            this.post.HeaderText = "Посада";
            this.post.Name = "post";
            this.post.ReadOnly = true;
            this.post.Width = 180;
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.Lavender;
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBut.Location = new System.Drawing.Point(985, 41);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(150, 50);
            this.backBut.TabIndex = 2;
            this.backBut.Text = "Назад";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
            // 
            // DevelopersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.dataDev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "DevelopersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPI-Awarding";
            ((System.ComponentModel.ISupportInitialize)(this.dataDev)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn post;

        private System.Windows.Forms.Button backBut;

        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;

        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn telegram;

        private System.Windows.Forms.DataGridView dataDev;

        #endregion
    }
}