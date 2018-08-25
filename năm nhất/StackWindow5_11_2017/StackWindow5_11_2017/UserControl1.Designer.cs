namespace StackWindow5_11_2017
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrupNhap = new System.Windows.Forms.GroupBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.grup1 = new System.Windows.Forms.GroupBox();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GrupNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrupNhap
            // 
            this.GrupNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrupNhap.Controls.Add(this.groupBox1);
            this.GrupNhap.Controls.Add(this.btnXuat);
            this.GrupNhap.Controls.Add(this.grup1);
            this.GrupNhap.Controls.Add(this.txtCot);
            this.GrupNhap.Controls.Add(this.txtHang);
            this.GrupNhap.Controls.Add(this.label2);
            this.GrupNhap.Controls.Add(this.label1);
            this.GrupNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrupNhap.Location = new System.Drawing.Point(0, 0);
            this.GrupNhap.Name = "GrupNhap";
            this.GrupNhap.Size = new System.Drawing.Size(264, 226);
            this.GrupNhap.TabIndex = 0;
            this.GrupNhap.TabStop = false;
            this.GrupNhap.Text = "NhapThongTin";
            this.GrupNhap.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(170, 16);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuat";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // grup1
            // 
            this.grup1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grup1.Location = new System.Drawing.Point(7, 75);
            this.grup1.Name = "grup1";
            this.grup1.Size = new System.Drawing.Size(95, 151);
            this.grup1.TabIndex = 4;
            this.grup1.TabStop = false;
            this.grup1.Text = "Mảng được tạo";
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(94, 55);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(58, 20);
            this.txtCot.TabIndex = 3;
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(94, 16);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(58, 20);
            this.txtHang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số cột";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(109, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrupNhap);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(264, 226);
            this.GrupNhap.ResumeLayout(false);
            this.GrupNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupNhap;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grup1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
