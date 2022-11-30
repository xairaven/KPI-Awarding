using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Program.Forms
{
    partial class ChangeDataUploadForm
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
            this.excelBut = new System.Windows.Forms.Button();
            this.manuallyBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.RosyBrown;
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBut.Location = new System.Drawing.Point(995, 55);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(150, 50);
            this.backBut.TabIndex = 3;
            this.backBut.Text = "Назад";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
            // 
            // excelBut
            // 
            this.excelBut.BackColor = System.Drawing.Color.SpringGreen;
            this.excelBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excelBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelBut.Location = new System.Drawing.Point(184, 357);
            this.excelBut.Name = "excelBut";
            this.excelBut.Size = new System.Drawing.Size(300, 100);
            this.excelBut.TabIndex = 4;
            this.excelBut.Text = "Вибрати Excel файл";
            this.excelBut.UseVisualStyleBackColor = false;
            this.excelBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.excelBut_MouseClick);
            // 
            // manuallyBut
            // 
            this.manuallyBut.BackColor = System.Drawing.Color.SpringGreen;
            this.manuallyBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manuallyBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manuallyBut.Location = new System.Drawing.Point(684, 357);
            this.manuallyBut.Name = "manuallyBut";
            this.manuallyBut.Size = new System.Drawing.Size(300, 100);
            this.manuallyBut.TabIndex = 5;
            this.manuallyBut.Text = "Вписати дані вручну";
            this.manuallyBut.UseVisualStyleBackColor = false;
            this.manuallyBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manuallyBut_MouseClick);
            // 
            // ChangeDataUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.manuallyBut);
            this.Controls.Add(this.excelBut);
            this.Controls.Add(this.backBut);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ChangeDataUploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPI-Awarding";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button excelBut;
        private System.Windows.Forms.Button manuallyBut;

        #endregion
    }
}