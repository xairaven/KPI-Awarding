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
            this.startBut = new System.Windows.Forms.Button();
            this.devBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBut
            // 
            this.startBut.BackColor = System.Drawing.Color.SpringGreen;
            this.startBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBut.Location = new System.Drawing.Point(435, 257);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(300, 100);
            this.startBut.TabIndex = 0;
            this.startBut.Text = "Розпочати";
            this.startBut.UseVisualStyleBackColor = false;
            this.startBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startBut_MouseClick);
            // 
            // devBut
            // 
            this.devBut.BackColor = System.Drawing.Color.Lavender;
            this.devBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.devBut.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devBut.Location = new System.Drawing.Point(1002, 473);
            this.devBut.Name = "devBut";
            this.devBut.Size = new System.Drawing.Size(150, 50);
            this.devBut.TabIndex = 1;
            this.devBut.Text = "Розробники";
            this.devBut.UseVisualStyleBackColor = false;
            this.devBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.devBut_MouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(248, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 121);
            this.label1.TabIndex = 2;
            this.label1.Text = "КПІ - Нагороди";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devBut);
            this.Controls.Add(this.startBut);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button devBut;

        private System.Windows.Forms.Button startBut;

        #endregion
    }
}