using Program.UI;

namespace Program.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.clearDbBut = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.badUserBut = new Guna.UI2.WinForms.Guna2Button();
            this.addRewardBut = new Guna.UI2.WinForms.Guna2Button();
            this.addNew = new Guna.UI2.WinForms.Guna2Button();
            this.backBut = new Guna.UI2.WinForms.Guna2Button();
            this.searchBut = new Guna.UI2.WinForms.Guna2CircleButton();
            this.searchComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.restartDefaultDB = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(946, 537);
            this.dataGridView1.TabIndex = 19;
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
            this.dataGridViewTextBoxColumn1.HeaderText = "Прізвище, ім\'я, по батькові співробітника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.rewardsKpi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rewardsCountry
            // 
            this.rewardsCountry.FillWeight = 150F;
            this.rewardsCountry.HeaderText = "Державна нагорода";
            this.rewardsCountry.Name = "rewardsCountry";
            this.rewardsCountry.ReadOnly = true;
            this.rewardsCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.importToolStripMenuItem, this.exportToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 31);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.importToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.importToolStripMenuItem.Image = global::Program.Properties.Resources.import;
            this.importToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(136, 27);
            this.importToolStripMenuItem.Text = "Import Excel";
            this.importToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importExcelFileToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.exportToolStripMenuItem.Image = global::Program.Properties.Resources.export;
            this.exportToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(134, 27);
            this.exportToolStripMenuItem.Text = "Export Excel";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportExcelFileToolStripMenuItem_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.clearDbBut);
            this.guna2Panel1.Controls.Add(this.button1);
            this.guna2Panel1.Controls.Add(this.badUserBut);
            this.guna2Panel1.Controls.Add(this.addRewardBut);
            this.guna2Panel1.Controls.Add(this.addNew);
            this.guna2Panel1.Controls.Add(this.backBut);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(1002, 31);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(180, 722);
            this.guna2Panel1.TabIndex = 22;
            // 
            // clearDbBut
            // 
            this.clearDbBut.BorderColor = System.Drawing.Color.Red;
            this.clearDbBut.BorderThickness = 2;
            this.clearDbBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearDbBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearDbBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearDbBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearDbBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clearDbBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.clearDbBut.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.clearDbBut.ForeColor = System.Drawing.Color.Red;
            this.clearDbBut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(249)))));
            this.clearDbBut.Image = global::Program.Properties.Resources.clean;
            this.clearDbBut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.clearDbBut.ImageOffset = new System.Drawing.Point(4, 0);
            this.clearDbBut.ImageSize = new System.Drawing.Size(25, 25);
            this.clearDbBut.Location = new System.Drawing.Point(0, 642);
            this.clearDbBut.Name = "clearDbBut";
            this.clearDbBut.Size = new System.Drawing.Size(180, 80);
            this.clearDbBut.TabIndex = 8;
            this.clearDbBut.Text = "Очистити       базу даних";
            this.clearDbBut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.clearDbBut.TextOffset = new System.Drawing.Point(4, 0);
            this.clearDbBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearDbBut_MouseClick);
            // 
            // button1
            // 
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.button1.BorderThickness = 2;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(249)))));
            this.button1.Image = global::Program.Properties.Resources.resize;
            this.button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button1.ImageOffset = new System.Drawing.Point(8, 0);
            this.button1.Location = new System.Drawing.Point(0, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 83);
            this.button1.TabIndex = 7;
            this.button1.Text = "Таблиця у    більшому     розмірі";
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button1.TextOffset = new System.Drawing.Point(10, 0);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // badUserBut
            // 
            this.badUserBut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.badUserBut.BorderThickness = 2;
            this.badUserBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.badUserBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.badUserBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.badUserBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.badUserBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.badUserBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.badUserBut.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.badUserBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.badUserBut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(249)))));
            this.badUserBut.Image = global::Program.Properties.Resources.list;
            this.badUserBut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.badUserBut.ImageOffset = new System.Drawing.Point(8, 0);
            this.badUserBut.ImageSize = new System.Drawing.Size(25, 25);
            this.badUserBut.Location = new System.Drawing.Point(0, 178);
            this.badUserBut.Name = "badUserBut";
            this.badUserBut.Size = new System.Drawing.Size(180, 64);
            this.badUserBut.TabIndex = 3;
            this.badUserBut.Text = "Список    дефектів";
            this.badUserBut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.badUserBut.TextOffset = new System.Drawing.Point(10, 0);
            this.badUserBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.badUserBut_MouseClick);
            // 
            // addRewardBut
            // 
            this.addRewardBut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.addRewardBut.BorderThickness = 2;
            this.addRewardBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addRewardBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addRewardBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRewardBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addRewardBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRewardBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.addRewardBut.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRewardBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.addRewardBut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(249)))));
            this.addRewardBut.Image = global::Program.Properties.Resources.rewards;
            this.addRewardBut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addRewardBut.ImageOffset = new System.Drawing.Point(8, 0);
            this.addRewardBut.ImageSize = new System.Drawing.Size(25, 25);
            this.addRewardBut.Location = new System.Drawing.Point(0, 114);
            this.addRewardBut.Name = "addRewardBut";
            this.addRewardBut.Size = new System.Drawing.Size(180, 64);
            this.addRewardBut.TabIndex = 2;
            this.addRewardBut.Text = "Додати    нагороду";
            this.addRewardBut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addRewardBut.TextOffset = new System.Drawing.Point(10, 0);
            this.addRewardBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addRewardBut_MouseClick);
            // 
            // addNew
            // 
            this.addNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.addNew.BorderThickness = 2;
            this.addNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.addNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.addNew.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(249)))));
            this.addNew.Image = global::Program.Properties.Resources.add;
            this.addNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addNew.ImageOffset = new System.Drawing.Point(8, 0);
            this.addNew.Location = new System.Drawing.Point(0, 51);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(180, 63);
            this.addNew.TabIndex = 1;
            this.addNew.Text = "Додати";
            this.addNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addNew.TextOffset = new System.Drawing.Point(10, 0);
            this.addNew.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addNew_MouseClick);
            // 
            // backBut
            // 
            this.backBut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.backBut.BorderThickness = 2;
            this.backBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBut.Dock = System.Windows.Forms.DockStyle.Top;
            this.backBut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.backBut.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.backBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(55)))), ((int)(((byte)(167)))));
            this.backBut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(249)))));
            this.backBut.Image = global::Program.Properties.Resources.home;
            this.backBut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.backBut.ImageOffset = new System.Drawing.Point(8, 0);
            this.backBut.Location = new System.Drawing.Point(0, 0);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(180, 51);
            this.backBut.TabIndex = 0;
            this.backBut.Text = "На головну";
            this.backBut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.backBut.TextOffset = new System.Drawing.Point(10, 0);
            this.backBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBut_MouseClick);
            // 
            // searchBut
            // 
            this.searchBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBut.FillColor = System.Drawing.Color.SlateBlue;
            this.searchBut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBut.ForeColor = System.Drawing.Color.White;
            this.searchBut.Image = ((System.Drawing.Image)(resources.GetObject("searchBut.Image")));
            this.searchBut.ImageSize = new System.Drawing.Size(18, 18);
            this.searchBut.Location = new System.Drawing.Point(640, 115);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(52, 42);
            this.searchBut.TabIndex = 23;
            this.searchBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBut_MouseClick);
            // 
            // searchComboBox
            // 
            this.searchComboBox.BackColor = System.Drawing.Color.Transparent;
            this.searchComboBox.BorderColor = System.Drawing.Color.Plum;
            this.searchComboBox.BorderRadius = 20;
            this.searchComboBox.BorderThickness = 2;
            this.searchComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(162)))), ((int)(((byte)(229)))));
            this.searchComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchComboBox.ForeColor = System.Drawing.Color.White;
            this.searchComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchComboBox.ItemHeight = 36;
            this.searchComboBox.Location = new System.Drawing.Point(381, 115);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(253, 42);
            this.searchComboBox.TabIndex = 24;
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.searchComboBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchTextBox.AutoRoundedCorners = true;
            this.searchTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(21)))), ((int)(((byte)(122)))));
            this.searchTextBox.BorderRadius = 22;
            this.searchTextBox.BorderThickness = 2;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(162)))), ((int)(((byte)(229)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.searchTextBox.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Location = new System.Drawing.Point(323, 50);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.searchTextBox.PlaceholderText = "Пошук";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(369, 46);
            this.searchTextBox.TabIndex = 25;
            // 
            // restartDefaultDB
            // 
            this.restartDefaultDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.restartDefaultDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.restartDefaultDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.restartDefaultDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.restartDefaultDB.FillColor = System.Drawing.Color.SlateBlue;
            this.restartDefaultDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.restartDefaultDB.ForeColor = System.Drawing.Color.White;
            this.restartDefaultDB.Image = ((System.Drawing.Image)(resources.GetObject("restartDefaultDB.Image")));
            this.restartDefaultDB.ImageSize = new System.Drawing.Size(23, 23);
            this.restartDefaultDB.Location = new System.Drawing.Point(323, 115);
            this.restartDefaultDB.Name = "restartDefaultDB";
            this.restartDefaultDB.Size = new System.Drawing.Size(52, 42);
            this.restartDefaultDB.TabIndex = 26;
            this.restartDefaultDB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.restartDefaultDB_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.restartDefaultDB);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2CircleButton restartDefaultDB;

        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;

        private Guna.UI2.WinForms.Guna2ComboBox searchComboBox;

        private Guna.UI2.WinForms.Guna2Button clearDbBut;
        private Guna.UI2.WinForms.Guna2Button button1;

        private Guna.UI2.WinForms.Guna2CircleButton searchBut;

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button badUserBut;
        private Guna.UI2.WinForms.Guna2Button addRewardBut;
        private Guna.UI2.WinForms.Guna2Button addNew;
        private Guna.UI2.WinForms.Guna2Button backBut;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsKpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsKpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn prediction;

        #endregion
    }
}