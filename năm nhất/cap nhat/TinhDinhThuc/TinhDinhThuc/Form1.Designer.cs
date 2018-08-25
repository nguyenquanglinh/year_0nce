namespace TinhDinhThuc
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
            this.grbNhap = new System.Windows.Forms.GroupBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.maTrix1 = new TinhDinhThuc.MaTrix();
            this.cbxLuachon = new System.Windows.Forms.ComboBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNhap
            // 
            this.grbNhap.Controls.Add(this.btnTao);
            this.grbNhap.Controls.Add(this.txtCot);
            this.grbNhap.Controls.Add(this.txtHang);
            this.grbNhap.Controls.Add(this.label2);
            this.grbNhap.Controls.Add(this.label1);
            this.grbNhap.Location = new System.Drawing.Point(-3, 1);
            this.grbNhap.Name = "grbNhap";
            this.grbNhap.Size = new System.Drawing.Size(200, 100);
            this.grbNhap.TabIndex = 0;
            this.grbNhap.TabStop = false;
            this.grbNhap.Text = "Nhập thông tin";
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(147, 71);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(47, 23);
            this.btnTao.TabIndex = 4;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(94, 39);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(100, 20);
            this.txtCot.TabIndex = 3;
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(94, 13);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(100, 20);
            this.txtHang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số cột";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số hàng";
            // 
            // btnTinh
            // 
            this.btnTinh.Enabled = false;
            this.btnTinh.Location = new System.Drawing.Point(203, 101);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(63, 23);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // maTrix1
            // 
            this.maTrix1.Location = new System.Drawing.Point(7, 125);
            this.maTrix1.Name = "maTrix1";
            this.maTrix1.Size = new System.Drawing.Size(282, 145);
            this.maTrix1.TabIndex = 6;
            // 
            // cbxLuachon
            // 
            this.cbxLuachon.FormattingEnabled = true;
            this.cbxLuachon.Items.AddRange(new object[] {
            "Tính định thức",
            "Biến đổi sơ cấp hàng",
            "Rank "});
            this.cbxLuachon.Location = new System.Drawing.Point(225, 14);
            this.cbxLuachon.Name = "cbxLuachon";
            this.cbxLuachon.Size = new System.Drawing.Size(79, 21);
            this.cbxLuachon.TabIndex = 7;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(225, 57);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(79, 20);
            this.txtKq.TabIndex = 8;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.cbxLuachon);
            this.Controls.Add(this.maTrix1);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.grbNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbNhap.ResumeLayout(false);
            this.grbNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNhap;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinh;
        private MaTrix maTrix1;
        private System.Windows.Forms.ComboBox cbxLuachon;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.ErrorProvider error;
    }
}

