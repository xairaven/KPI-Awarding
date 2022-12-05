using System.ComponentModel;
using System.Windows.Forms;
using Program.UI;

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
            this.dataDev = new Guna.UI2.WinForms.Guna2DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telegram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBut1 = new Program.UI.ButtonZoom();
            ((System.ComponentModel.ISupportInitialize)(this.dataDev)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDev
            // 
            this.dataDev.AllowUserToAddRows = false;
            this.dataDev.AllowUserToResizeColumns = false;
            this.dataDev.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataDev.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDev.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dataDev.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(96)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataDev.ColumnHeadersHeight = 40;
            this.dataDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataDev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.name, this.lastName, this.telegram, this.post });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDev.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDev.GridColor = System.Drawing.Color.DarkGray;
            this.dataDev.Location = new System.Drawing.Point(108, 173);
            this.dataDev.Name = "dataDev";
            this.dataDev.ReadOnly = true;
            this.dataDev.RowHeadersVisible = false;
            this.dataDev.RowTemplate.Height = 32;
            this.dataDev.Size = new System.Drawing.Size(928, 295);
            this.dataDev.TabIndex = 3;
            this.dataDev.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDev.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataDev.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataDev.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataDev.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataDev.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dataDev.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.dataDev.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RosyBrown;
            this.dataDev.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDev.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataDev.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataDev.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataDev.ThemeStyle.HeaderStyle.Height = 40;
            this.dataDev.ThemeStyle.ReadOnly = true;
            this.dataDev.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataDev.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataDev.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataDev.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataDev.ThemeStyle.RowsStyle.Height = 32;
            this.dataDev.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataDev.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // name
            // 
            this.name.FillWeight = 150F;
            this.name.HeaderText = "Ім\'я";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.FillWeight = 150F;
            this.lastName.HeaderText = "Прізвище";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // telegram
            // 
            this.telegram.FillWeight = 150F;
            this.telegram.HeaderText = "Телеграм";
            this.telegram.Name = "telegram";
            this.telegram.ReadOnly = true;
            // 
            // post
            // 
            this.post.FillWeight = 200F;
            this.post.HeaderText = "Посада";
            this.post.Name = "post";
            this.post.ReadOnly = true;
            // 
            // backBut1
            // 
            this.backBut1.BorderColor = System.Drawing.Color.Indigo;
            this.backBut1.BorderRadius = 15;
            this.backBut1.BorderThickness = 2;
            this.backBut1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBut1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBut1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBut1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBut1.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.backBut1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.backBut1.ForeColor = System.Drawing.Color.White;
            this.backBut1.Location = new System.Drawing.Point(923, 38);
            this.backBut1.Name = "backBut1";
            this.backBut1.Size = new System.Drawing.Size(200, 60);
            this.backBut1.TabIndex = 4;
            this.backBut1.Text = "Назад";
            this.backBut1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
            // 
            // DevelopersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.backBut1);
            this.Controls.Add(this.dataDev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "DevelopersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPI-Awarding";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DevelopersForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataDev)).EndInit();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Button backBut1;

        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn telegram;
        private System.Windows.Forms.DataGridViewTextBoxColumn post;

        private Guna.UI2.WinForms.Guna2DataGridView dataDev;

        #endregion
    }
}