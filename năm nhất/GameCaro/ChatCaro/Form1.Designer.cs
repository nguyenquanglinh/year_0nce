namespace ChatCaro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStart = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtTiepTheo = new System.Windows.Forms.TextBox();
            this.prbTime = new System.Windows.Forms.ProgressBar();
            this.btnTiepTheo = new System.Windows.Forms.Button();
            this.txtHienTai = new System.Windows.Forms.TextBox();
            this.btnHienTai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chessBoardCaro1 = new ChatCaro.ChessBoardCaro();
            this.menuStart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStart
            // 
            this.menuStart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStart.Location = new System.Drawing.Point(0, 0);
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(714, 24);
            this.menuStart.TabIndex = 11;
            this.menuStart.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbThongTin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(508, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 433);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtTiepTheo);
            this.grbThongTin.Controls.Add(this.prbTime);
            this.grbThongTin.Controls.Add(this.btnTiepTheo);
            this.grbThongTin.Controls.Add(this.txtHienTai);
            this.grbThongTin.Controls.Add(this.btnHienTai);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Location = new System.Drawing.Point(1, 28);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(206, 115);
            this.grbThongTin.TabIndex = 14;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // txtTiepTheo
            // 
            this.txtTiepTheo.Location = new System.Drawing.Point(61, 51);
            this.txtTiepTheo.Name = "txtTiepTheo";
            this.txtTiepTheo.ReadOnly = true;
            this.txtTiepTheo.Size = new System.Drawing.Size(83, 20);
            this.txtTiepTheo.TabIndex = 5;
            // 
            // prbTime
            // 
            this.prbTime.Location = new System.Drawing.Point(90, 82);
            this.prbTime.Name = "prbTime";
            this.prbTime.Size = new System.Drawing.Size(100, 23);
            this.prbTime.TabIndex = 9;
            // 
            // btnTiepTheo
            // 
            this.btnTiepTheo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTiepTheo.Enabled = false;
            this.btnTiepTheo.Location = new System.Drawing.Point(169, 51);
            this.btnTiepTheo.Name = "btnTiepTheo";
            this.btnTiepTheo.Size = new System.Drawing.Size(25, 25);
            this.btnTiepTheo.TabIndex = 4;
            this.btnTiepTheo.UseVisualStyleBackColor = true;
            // 
            // txtHienTai
            // 
            this.txtHienTai.Location = new System.Drawing.Point(61, 13);
            this.txtHienTai.Name = "txtHienTai";
            this.txtHienTai.ReadOnly = true;
            this.txtHienTai.Size = new System.Drawing.Size(83, 20);
            this.txtHienTai.TabIndex = 3;
            // 
            // btnHienTai
            // 
            this.btnHienTai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHienTai.Enabled = false;
            this.btnHienTai.Location = new System.Drawing.Point(169, 13);
            this.btnHienTai.Name = "btnHienTai";
            this.btnHienTai.Size = new System.Drawing.Size(25, 25);
            this.btnHienTai.TabIndex = 2;
            this.btnHienTai.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tiếp theo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hiện tại :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chessBoardCaro1
            // 
            this.chessBoardCaro1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.chessBoardCaro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chessBoardCaro1.Location = new System.Drawing.Point(0, 24);
            this.chessBoardCaro1.Name = "chessBoardCaro1";
            this.chessBoardCaro1.Size = new System.Drawing.Size(714, 433);
            this.chessBoardCaro1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chessBoardCaro1);
            this.Controls.Add(this.menuStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_AutoSizeChanged);
            this.menuStart.ResumeLayout(false);
            this.menuStart.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStart;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ChessBoardCaro chessBoardCaro1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ProgressBar prbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtTiepTheo;
        private System.Windows.Forms.Button btnTiepTheo;
        private System.Windows.Forms.TextBox txtHienTai;
        private System.Windows.Forms.Button btnHienTai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}

