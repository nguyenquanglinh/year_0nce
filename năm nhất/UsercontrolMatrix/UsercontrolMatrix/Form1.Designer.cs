namespace UsercontrolMatrix
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
            this.txtHang = new System.Windows.Forms.TextBox();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupMatrix3 = new UsercontrolMatrix.GroupMatrix();
            this.groupMatrix2 = new UsercontrolMatrix.GroupMatrix();
            this.groupMatrix1 = new UsercontrolMatrix.GroupMatrix();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(94, 17);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(100, 20);
            this.txtHang.TabIndex = 0;
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(94, 43);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(100, 20);
            this.txtCot.TabIndex = 1;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(125, 71);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 23);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCot);
            this.groupBox1.Controls.Add(this.btnTao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số cột";
            // 
            // btnKetQua
            // 
            this.btnKetQua.Enabled = false;
            this.btnKetQua.Location = new System.Drawing.Point(417, 55);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(78, 20);
            this.btnKetQua.TabIndex = 2;
            this.btnKetQua.Text = "Kết Quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(276, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupMatrix3
            // 
            this.groupMatrix3.Enabled = false;
            this.groupMatrix3.Location = new System.Drawing.Point(488, 151);
            this.groupMatrix3.Name = "groupMatrix3";
            this.groupMatrix3.Size = new System.Drawing.Size(254, 283);
            this.groupMatrix3.TabIndex = 2;
            // 
            // groupMatrix2
            // 
            this.groupMatrix2.Enabled = false;
            this.groupMatrix2.Location = new System.Drawing.Point(251, 151);
            this.groupMatrix2.Name = "groupMatrix2";
            this.groupMatrix2.Size = new System.Drawing.Size(244, 283);
            this.groupMatrix2.TabIndex = 1;
            // 
            // groupMatrix1
            // 
            this.groupMatrix1.Enabled = false;
            this.groupMatrix1.Location = new System.Drawing.Point(3, 151);
            this.groupMatrix1.Name = "groupMatrix1";
            this.groupMatrix1.Size = new System.Drawing.Size(242, 283);
            this.groupMatrix1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 453);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupMatrix3);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupMatrix2);
            this.Controls.Add(this.groupMatrix1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupMatrix groupMatrix1;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.Button btnTao;
        private GroupMatrix groupMatrix2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKetQua;
        private GroupMatrix groupMatrix3;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}

