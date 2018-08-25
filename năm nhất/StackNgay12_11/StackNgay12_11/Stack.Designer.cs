namespace StackNgay12_11
{
    partial class Stack
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
            this.components = new System.ComponentModel.Container();
            this.groupNhap = new System.Windows.Forms.GroupBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.grorp1 = new System.Windows.Forms.GroupBox();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.group3 = new System.Windows.Forms.GroupBox();
            this.btnKq = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHangM1 = new System.Windows.Forms.TextBox();
            this.txtCotM2 = new System.Windows.Forms.TextBox();
            this.txtHangM2 = new System.Windows.Forms.TextBox();
            this.txtCotM1 = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupNhap
            // 
            this.groupNhap.Controls.Add(this.btnTao);
            this.groupNhap.Controls.Add(this.txtCot);
            this.groupNhap.Controls.Add(this.label2);
            this.groupNhap.Controls.Add(this.label1);
            this.groupNhap.Controls.Add(this.txtHang);
            this.groupNhap.Location = new System.Drawing.Point(0, 0);
            this.groupNhap.Name = "groupNhap";
            this.groupNhap.Size = new System.Drawing.Size(200, 100);
            this.groupNhap.TabIndex = 0;
            this.groupNhap.TabStop = false;
            this.groupNhap.Text = "Nhap thong tin";
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(145, 77);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(49, 23);
            this.btnTao.TabIndex = 4;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(86, 54);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(59, 20);
            this.txtCot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhap so cot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhap so hang ";
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(86, 19);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(59, 20);
            this.txtHang.TabIndex = 0;
            // 
            // grorp1
            // 
            this.grorp1.Location = new System.Drawing.Point(0, 106);
            this.grorp1.Name = "grorp1";
            this.grorp1.Size = new System.Drawing.Size(200, 201);
            this.grorp1.TabIndex = 1;
            this.grorp1.TabStop = false;
            this.grorp1.Text = "Mang 1";
            // 
            // group2
            // 
            this.group2.Location = new System.Drawing.Point(206, 106);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(200, 198);
            this.group2.TabIndex = 1;
            this.group2.TabStop = false;
            this.group2.Text = "Mang 2";
            // 
            // group3
            // 
            this.group3.Location = new System.Drawing.Point(413, 106);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(200, 198);
            this.group3.TabIndex = 2;
            this.group3.TabStop = false;
            this.group3.Text = "Kết Quả";
            // 
            // btnKq
            // 
            this.btnKq.Location = new System.Drawing.Point(252, 57);
            this.btnKq.Name = "btnKq";
            this.btnKq.Size = new System.Drawing.Size(75, 23);
            this.btnKq.TabIndex = 3;
            this.btnKq.Text = "Kết Quả";
            this.btnKq.UseVisualStyleBackColor = true;
            this.btnKq.Click += new System.EventHandler(this.btnKt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "X"});
            this.comboBox1.Location = new System.Drawing.Point(206, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "số hàng mảng1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "số cột mảng 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "số hàng mảng 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "số cột mảng 2";
            // 
            // txtHangM1
            // 
            this.txtHangM1.Location = new System.Drawing.Point(466, 26);
            this.txtHangM1.Name = "txtHangM1";
            this.txtHangM1.ReadOnly = true;
            this.txtHangM1.Size = new System.Drawing.Size(100, 20);
            this.txtHangM1.TabIndex = 9;
            this.txtHangM1.Text = "0";
            // 
            // txtCotM2
            // 
            this.txtCotM2.Location = new System.Drawing.Point(466, 86);
            this.txtCotM2.Name = "txtCotM2";
            this.txtCotM2.ReadOnly = true;
            this.txtCotM2.Size = new System.Drawing.Size(100, 20);
            this.txtCotM2.TabIndex = 10;
            this.txtCotM2.Text = "0";
            // 
            // txtHangM2
            // 
            this.txtHangM2.Location = new System.Drawing.Point(466, 65);
            this.txtHangM2.Name = "txtHangM2";
            this.txtHangM2.ReadOnly = true;
            this.txtHangM2.Size = new System.Drawing.Size(100, 20);
            this.txtHangM2.TabIndex = 11;
            this.txtHangM2.Text = "0";
            this.txtHangM2.Validating += new System.ComponentModel.CancelEventHandler(this.txtHangM2_Validating);
            // 
            // txtCotM1
            // 
            this.txtCotM1.Location = new System.Drawing.Point(466, 47);
            this.txtCotM1.Name = "txtCotM1";
            this.txtCotM1.ReadOnly = true;
            this.txtCotM1.Size = new System.Drawing.Size(100, 20);
            this.txtCotM1.TabIndex = 12;
            this.txtCotM1.Text = "0";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Stack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCotM1);
            this.Controls.Add(this.txtHangM2);
            this.Controls.Add(this.txtCotM2);
            this.Controls.Add(this.txtHangM1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnKq);
            this.Controls.Add(this.group3);
            this.Controls.Add(this.grorp1);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.groupNhap);
            this.Name = "Stack";
            this.Size = new System.Drawing.Size(618, 307);
            this.groupNhap.ResumeLayout(false);
            this.groupNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupNhap;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.GroupBox grorp1;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.Button btnKq;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHangM1;
        private System.Windows.Forms.TextBox txtCotM2;
        private System.Windows.Forms.TextBox txtHangM2;
        private System.Windows.Forms.TextBox txtCotM1;
        private System.Windows.Forms.ErrorProvider error;
    }
}
