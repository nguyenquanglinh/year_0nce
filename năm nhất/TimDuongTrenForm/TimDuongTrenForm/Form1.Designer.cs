namespace TimDuongTrenForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.btnTimDuong = new System.Windows.Forms.Button();
            this.btnThuTuDuyet = new System.Windows.Forms.Button();
            this.btnToMau = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docFileToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // docFileToolStripMenuItem
            // 
            this.docFileToolStripMenuItem.Name = "docFileToolStripMenuItem";
            this.docFileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.docFileToolStripMenuItem.Text = "Đọc file và lưu file";
            this.docFileToolStripMenuItem.Click += new System.EventHandler(this.docFileToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuongDan);
            this.groupBox1.Controls.Add(this.btnTimDuong);
            this.groupBox1.Controls.Add(this.btnThuTuDuyet);
            this.groupBox1.Controls.Add(this.btnToMau);
            this.groupBox1.Location = new System.Drawing.Point(376, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Điều khiển";
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Location = new System.Drawing.Point(105, 49);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(75, 23);
            this.btnHuongDan.TabIndex = 3;
            this.btnHuongDan.Text = "Hướng dẫn";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            // 
            // btnTimDuong
            // 
            this.btnTimDuong.Location = new System.Drawing.Point(7, 50);
            this.btnTimDuong.Name = "btnTimDuong";
            this.btnTimDuong.Size = new System.Drawing.Size(75, 23);
            this.btnTimDuong.TabIndex = 2;
            this.btnTimDuong.Text = "Thứ tự duyệt";
            this.btnTimDuong.UseVisualStyleBackColor = true;
            this.btnTimDuong.Click += new System.EventHandler(this.btnTimDuong_Click);
            // 
            // btnThuTuDuyet
            // 
            this.btnThuTuDuyet.Location = new System.Drawing.Point(105, 19);
            this.btnThuTuDuyet.Name = "btnThuTuDuyet";
            this.btnThuTuDuyet.Size = new System.Drawing.Size(75, 23);
            this.btnThuTuDuyet.TabIndex = 1;
            this.btnThuTuDuyet.Text = "Tìm đường";
            this.btnThuTuDuyet.UseVisualStyleBackColor = true;
            this.btnThuTuDuyet.Click += new System.EventHandler(this.btnThuTuDuyet_Click);
            // 
            // btnToMau
            // 
            this.btnToMau.Location = new System.Drawing.Point(7, 21);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(75, 23);
            this.btnToMau.TabIndex = 0;
            this.btnToMau.Text = "Tô màu";
            this.btnToMau.UseVisualStyleBackColor = true;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(576, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docFileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Button btnTimDuong;
        private System.Windows.Forms.Button btnThuTuDuyet;
        private System.Windows.Forms.Button btnToMau;



    }
}

