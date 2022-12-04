using System.Drawing;
using System.Windows.Forms;
using Program.UI;

namespace Program.Forms
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.startBut = new ButtonDesign(300,100, Color.Coral, Color.Black, 30, 4, Color.Brown);
            this.devBut = new ButtonDesign(150, 50, Color.Coral, Color.Black, 15, 2, Color.Brown);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            //
            this.startBut.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBut.Location = new System.Drawing.Point(435, 257);
            this.startBut.Text = "Розпочати";
            this.startBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startBut_MouseClick);
            //
            // devBut
            // 
            this.devBut.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devBut.Location = new System.Drawing.Point(1002, 473);
            this.devBut.Text = "Розробники";
            this.devBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.devBut_MouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(278, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 121);
            this.label1.TabIndex = 2;
            this.label1.Text = "КПІ - Нагороди";
            this.label1.ForeColor = Color.Coral;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devBut);
            this.Controls.Add(this.startBut);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPI-Awarding";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button devBut;

        private System.Windows.Forms.Button startBut;

        #endregion
    }
}