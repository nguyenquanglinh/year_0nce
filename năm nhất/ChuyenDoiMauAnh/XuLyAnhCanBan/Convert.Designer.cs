namespace XuLyAnhCanBan
{
    partial class Convert
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbbCachXuLy = new System.Windows.Forms.ComboBox();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDemDiemAnh = new System.Windows.Forms.Button();
            this.btnSoSanh = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnSSNguoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(35, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(66, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbbCachXuLy
            // 
            this.cbbCachXuLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCachXuLy.FormattingEnabled = true;
            this.cbbCachXuLy.Items.AddRange(new object[] {
            "..................",
            "Mau=>xam",
            "Đảo ngược màu",
            "Lọc ảnh với T=",
            "Lọc ảnh trong [a,b]",
            "Nhân Chấm"});
            this.cbbCachXuLy.Location = new System.Drawing.Point(21, 44);
            this.cbbCachXuLy.Name = "cbbCachXuLy";
            this.cbbCachXuLy.Size = new System.Drawing.Size(94, 21);
            this.cbbCachXuLy.TabIndex = 2;
            this.cbbCachXuLy.SelectedIndexChanged += new System.EventHandler(this.cbbCachXuLy_SelectedIndexChanged);
            // 
            // btnXuLy
            // 
            this.btnXuLy.Location = new System.Drawing.Point(35, 71);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(66, 23);
            this.btnXuLy.TabIndex = 3;
            this.btnXuLy.Text = "XuLy";
            this.btnXuLy.UseVisualStyleBackColor = true;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(486, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 287);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnXuLy);
            this.groupBox1.Controls.Add(this.cbbCachXuLy);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(314, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "bảng điều khiển";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 106);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(314, 256);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 43);
            this.listBox1.TabIndex = 6;
            // 
            // btnDemDiemAnh
            // 
            this.btnDemDiemAnh.Location = new System.Drawing.Point(324, 153);
            this.btnDemDiemAnh.Name = "btnDemDiemAnh";
            this.btnDemDiemAnh.Size = new System.Drawing.Size(156, 23);
            this.btnDemDiemAnh.TabIndex = 7;
            this.btnDemDiemAnh.Text = "Đếm số chấm đen trên ảnh";
            this.btnDemDiemAnh.UseVisualStyleBackColor = true;
            this.btnDemDiemAnh.Click += new System.EventHandler(this.btnDemDiemAnh_Click);
            // 
            // btnSoSanh
            // 
            this.btnSoSanh.Location = new System.Drawing.Point(324, 183);
            this.btnSoSanh.Name = "btnSoSanh";
            this.btnSoSanh.Size = new System.Drawing.Size(146, 23);
            this.btnSoSanh.TabIndex = 8;
            this.btnSoSanh.Text = "So Sanh Anh chữ";
            this.btnSoSanh.UseVisualStyleBackColor = true;
            this.btnSoSanh.Click += new System.EventHandler(this.btnSoSanh_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(324, 212);
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(100, 20);
            this.txtText.TabIndex = 9;
            // 
            // btnSSNguoi
            // 
            this.btnSSNguoi.Location = new System.Drawing.Point(324, 227);
            this.btnSSNguoi.Name = "btnSSNguoi";
            this.btnSSNguoi.Size = new System.Drawing.Size(146, 23);
            this.btnSSNguoi.TabIndex = 10;
            this.btnSSNguoi.Text = "So Sanh Anh Nguoi";
            this.btnSSNguoi.UseVisualStyleBackColor = true;
            // 
            // Convert
            // 
            this.AcceptButton = this.btnXuLy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 327);
            this.Controls.Add(this.btnSSNguoi);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnSoSanh);
            this.Controls.Add(this.btnDemDiemAnh);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Convert";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbbCachXuLy;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDemDiemAnh;
        private System.Windows.Forms.Button btnSoSanh;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnSSNguoi;
    }
}

