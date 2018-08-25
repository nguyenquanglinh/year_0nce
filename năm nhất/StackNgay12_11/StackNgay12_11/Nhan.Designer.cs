namespace StackNgay12_11
{
    partial class Nhan
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
            this.txtCot = new System.Windows.Forms.TextBox();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxTao = new System.Windows.Forms.GroupBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.groupBoxThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(73, 48);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(65, 20);
            this.txtCot.TabIndex = 0;
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(73, 25);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(65, 20);
            this.txtHang.TabIndex = 1;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.button1);
            this.groupBoxThongTin.Controls.Add(this.label2);
            this.groupBoxThongTin.Controls.Add(this.label1);
            this.groupBoxThongTin.Controls.Add(this.txtHang);
            this.groupBoxThongTin.Controls.Add(this.txtCot);
            this.groupBoxThongTin.Location = new System.Drawing.Point(13, 13);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(190, 100);
            this.groupBoxThongTin.TabIndex = 2;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Nhập số hàng số cột";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "số hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "số cột";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tạo Mảng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxTao
            // 
            this.groupBoxTao.Enabled = false;
            this.groupBoxTao.Location = new System.Drawing.Point(-8, 119);
            this.groupBoxTao.Name = "groupBoxTao";
            this.groupBoxTao.Size = new System.Drawing.Size(292, 148);
            this.groupBoxTao.TabIndex = 3;
            this.groupBoxTao.TabStop = false;
            this.groupBoxTao.Text = "Mảng được tạo";
            // 
            // btnTong
            // 
            this.btnTong.Enabled = false;
            this.btnTong.Location = new System.Drawing.Point(210, 24);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(62, 23);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(210, 53);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(62, 20);
            this.txtTong.TabIndex = 5;
            // 
            // Nhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.groupBoxTao);
            this.Controls.Add(this.groupBoxThongTin);
            this.Name = "Nhan";
            this.Text = "Nhan";
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTao;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.TextBox txtTong;
    }
}