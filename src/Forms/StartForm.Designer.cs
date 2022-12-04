using System.ComponentModel;

namespace Program.Forms
{
    partial class StartForm
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
            this.startBut = new Program.UI.GradientZoom();
            this.backBut = new Program.UI.ButtonZoom();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBut
            // 
            this.startBut.BorderColor = System.Drawing.Color.SeaGreen;
            this.startBut.BorderRadius = 20;
            this.startBut.BorderThickness = 2;
            this.startBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startBut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startBut.FillColor = System.Drawing.Color.LightGreen;
            this.startBut.FillColor2 = System.Drawing.Color.MediumAquamarine;
            this.startBut.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBut.ForeColor = System.Drawing.Color.White;
            this.startBut.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.startBut.Location = new System.Drawing.Point(404, 302);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(320, 120);
            this.startBut.TabIndex = 70;
            this.startBut.Text = "Розпочати";
            this.startBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startBut_MouseClick);
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
            this.backBut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBut.ForeColor = System.Drawing.Color.White;
            this.backBut.Location = new System.Drawing.Point(973, 477);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(173, 48);
            this.backBut.TabIndex = 71;
            this.backBut.Text = "Розробники";
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.devBut_MouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(96)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(257, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 143);
            this.label1.TabIndex = 72;
            this.label1.Text = "КПІ-нагороди";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.startBut);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPI-Awarding";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private Program.UI.ButtonZoom backBut;

        private Program.UI.GradientZoom startBut;

        #endregion
    }
}