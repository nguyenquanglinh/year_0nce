namespace DoThiTrenForm
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
            this.cbbThuatToan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThuTuDuyet = new System.Windows.Forms.Button();
            this.btnTimDuong = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbThuatToan
            // 
            this.cbbThuatToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbThuatToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThuatToan.FormattingEnabled = true;
            this.cbbThuatToan.Items.AddRange(new object[] {
            "dfs",
            "bfs"});
            this.cbbThuatToan.Location = new System.Drawing.Point(617, 258);
            this.cbbThuatToan.Name = "cbbThuatToan";
            this.cbbThuatToan.Size = new System.Drawing.Size(85, 21);
            this.cbbThuatToan.TabIndex = 0;
            this.cbbThuatToan.SelectedIndexChanged += new System.EventHandler(this.cbbThuatToan_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnThuTuDuyet);
            this.groupBox1.Controls.Add(this.btnTimDuong);
            this.groupBox1.Location = new System.Drawing.Point(515, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng điều khiển";
            // 
            // btnThuTuDuyet
            // 
            this.btnThuTuDuyet.Location = new System.Drawing.Point(112, 30);
            this.btnThuTuDuyet.Name = "btnThuTuDuyet";
            this.btnThuTuDuyet.Size = new System.Drawing.Size(75, 23);
            this.btnThuTuDuyet.TabIndex = 3;
            this.btnThuTuDuyet.Text = "Thứ tự duyệt";
            this.btnThuTuDuyet.UseVisualStyleBackColor = true;
            this.btnThuTuDuyet.Click += new System.EventHandler(this.btnThuTuDuyet_Click);
            // 
            // btnTimDuong
            // 
            this.btnTimDuong.Location = new System.Drawing.Point(8, 30);
            this.btnTimDuong.Name = "btnTimDuong";
            this.btnTimDuong.Size = new System.Drawing.Size(75, 23);
            this.btnTimDuong.TabIndex = 2;
            this.btnTimDuong.Text = "Tìm đường";
            this.btnTimDuong.UseVisualStyleBackColor = true;
            this.btnTimDuong.Click += new System.EventHandler(this.btnTimDuong_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(517, 370);
            this.panel.TabIndex = 3;
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 389);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbThuatToan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "main";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbThuatToan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThuTuDuyet;
        private System.Windows.Forms.Button btnTimDuong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
    }
}

