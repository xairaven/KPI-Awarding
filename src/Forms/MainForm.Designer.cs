﻿using System.ComponentModel;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardKpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearKpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.importExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRewardBut = new System.Windows.Forms.Button();
            this.addNew = new System.Windows.Forms.Button();
            this.backBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.miniToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.fullName, this.facultet, this.rewardKpi, this.rewardCountry, this.numberProtocol, this.yearKpi, this.yearCountry });
            this.dataGridView1.Location = new System.Drawing.Point(38, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 342);
            this.dataGridView1.TabIndex = 0;
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
            // miniToolStrip
            // 
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.importExcelFileToolStripMenuItem });
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1182, 28);
            this.miniToolStrip.TabIndex = 5;
            this.miniToolStrip.Text = "menuStrip1";
            // 
            // importExcelFileToolStripMenuItem
            // 
            this.importExcelFileToolStripMenuItem.Name = "importExcelFileToolStripMenuItem";
            this.importExcelFileToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.importExcelFileToolStripMenuItem.Text = "Import ExcelFile";
            this.importExcelFileToolStripMenuItem.Click += new System.EventHandler(this.importExcelFileToolStripMenuItem_Click);
            // 
            // addRewardBut
            // 
            this.addRewardBut.BackColor = System.Drawing.Color.Lavender;
            this.addRewardBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRewardBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRewardBut.Location = new System.Drawing.Point(1005, 225);
            this.addRewardBut.Name = "addRewardBut";
            this.addRewardBut.Size = new System.Drawing.Size(150, 74);
            this.addRewardBut.TabIndex = 7;
            this.addRewardBut.Text = "Добавити нагороду";
            this.addRewardBut.UseVisualStyleBackColor = false;
            this.addRewardBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addRewardBut_MouseClick);
            // 
            // addNew
            // 
            this.addNew.BackColor = System.Drawing.Color.Lavender;
            this.addNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNew.Location = new System.Drawing.Point(1005, 315);
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
            this.button1.Location = new System.Drawing.Point(1005, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 74);
            this.button1.TabIndex = 10;
            this.button1.Text = "Повний екран";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.addRewardBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.miniToolStrip);
            this.MainMenuStrip = this.miniToolStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button backBut;

        private System.Windows.Forms.Button addNew;

        private System.Windows.Forms.DataGridViewTextBoxColumn rewardCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearKpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearCountry;

        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultet;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardKpi;

        private System.Windows.Forms.Button addRewardBut;

        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem importExcelFileToolStripMenuItem;

        public System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}