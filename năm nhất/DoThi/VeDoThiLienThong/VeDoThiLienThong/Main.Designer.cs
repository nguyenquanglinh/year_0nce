namespace VeDoThiLienThong
{
    partial class DoThiLienThongAbc
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
            this.đồThịMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group = new System.Windows.Forms.GroupBox();
            this.btnTimDuong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTt = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đồThịMớiToolStripMenuItem,
            this.quayLạiToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // đồThịMớiToolStripMenuItem
            // 
            this.đồThịMớiToolStripMenuItem.Name = "đồThịMớiToolStripMenuItem";
            this.đồThịMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.đồThịMớiToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.đồThịMớiToolStripMenuItem.Text = "New Graph";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quayLạiToolStripMenuItem.Text = "Undo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // group
            // 
            this.group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.group.Controls.Add(this.btnTimDuong);
            this.group.Controls.Add(this.button1);
            this.group.Controls.Add(this.button2);
            this.group.Controls.Add(this.btnTt);
            this.group.Controls.Add(this.btnLuu);
            this.group.Location = new System.Drawing.Point(0, 334);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(756, 81);
            this.group.TabIndex = 1;
            this.group.TabStop = false;
            this.group.Text = "Bảng điều khiển";
            // 
            // btnTimDuong
            // 
            this.btnTimDuong.Enabled = false;
            this.btnTimDuong.Location = new System.Drawing.Point(509, 40);
            this.btnTimDuong.Name = "btnTimDuong";
            this.btnTimDuong.Size = new System.Drawing.Size(75, 23);
            this.btnTimDuong.TabIndex = 9;
            this.btnTimDuong.Text = "Tìm Đường";
            this.btnTimDuong.UseVisualStyleBackColor = true;
            this.btnTimDuong.Click += new System.EventHandler(this.btnTimDuong_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Đọc file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tô Màu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTt
            // 
            this.btnTt.Location = new System.Drawing.Point(357, 40);
            this.btnTt.Name = "btnTt";
            this.btnTt.Size = new System.Drawing.Size(79, 23);
            this.btnTt.TabIndex = 3;
            this.btnTt.Text = "Thứ tự duyệt";
            this.btnTt.UseVisualStyleBackColor = true;
            this.btnTt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(12, 40);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu file";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DoThiLienThongAbc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 409);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.group);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoThiLienThongAbc";
            this.Text = "Đồ thị liên thông";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DoThiLienThong_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.group.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đồThịMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTimDuong;
        private System.Windows.Forms.Button button3;

         












    }
}

