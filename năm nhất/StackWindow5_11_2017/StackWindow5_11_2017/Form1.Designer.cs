namespace StackWindow5_11_2017
{
    partial class Abc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.grbMang1 = new System.Windows.Forms.GroupBox();
            this.grbMang2 = new System.Windows.Forms.GroupBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTest = new System.Windows.Forms.Button();
            this.KtTest = new System.Windows.Forms.Button();
            this.userControl11 = new StackWindow5_11_2017.UserControl1();
            this.userControl12 = new StackWindow5_11_2017.UserControl1();
            this.grbThongTin.SuspendLayout();
            this.grbMang1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số cột";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hàng ";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtCot);
            this.grbThongTin.Controls.Add(this.txtHang);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Location = new System.Drawing.Point(2, 29);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(158, 108);
            this.grbThongTin.TabIndex = 2;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Điền thông tin ";
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(62, 60);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(58, 20);
            this.txtCot.TabIndex = 3;
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(62, 36);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(58, 20);
            this.txtHang.TabIndex = 2;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(198, 52);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 3;
            this.btnXuat.Text = "Tạo bảng";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // grbMang1
            // 
            this.grbMang1.Controls.Add(this.userControl12);
            this.grbMang1.Location = new System.Drawing.Point(2, 143);
            this.grbMang1.Name = "grbMang1";
            this.grbMang1.Size = new System.Drawing.Size(271, 209);
            this.grbMang1.TabIndex = 4;
            this.grbMang1.TabStop = false;
            this.grbMang1.Text = "Điền giá trị cho mảng 1";
            // 
            // grbMang2
            // 
            this.grbMang2.Location = new System.Drawing.Point(280, 143);
            this.grbMang2.Name = "grbMang2";
            this.grbMang2.Size = new System.Drawing.Size(253, 209);
            this.grbMang2.TabIndex = 5;
            this.grbMang2.TabStop = false;
            this.grbMang2.Text = "Điền giá trị mang 2";
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(331, 52);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnKetQua.TabIndex = 6;
            this.btnKetQua.Text = "Hiển thị kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // grbKetQua
            // 
            this.grbKetQua.Location = new System.Drawing.Point(539, 152);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(251, 209);
            this.grbKetQua.TabIndex = 7;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(482, 52);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // KtTest
            // 
            this.KtTest.Location = new System.Drawing.Point(660, 51);
            this.KtTest.Name = "KtTest";
            this.KtTest.Size = new System.Drawing.Size(75, 23);
            this.KtTest.TabIndex = 9;
            this.KtTest.Text = "Kiểm ta test";
            this.KtTest.UseVisualStyleBackColor = true;
            this.KtTest.Click += new System.EventHandler(this.KtTest_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(526, 89);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(486, 230);
            this.userControl11.TabIndex = 10;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(91, 51);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(264, 150);
            this.userControl12.TabIndex = 11;
            // 
            // Abc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 356);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.KtTest);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.grbKetQua);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.grbMang2);
            this.Controls.Add(this.grbMang1);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.grbThongTin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Abc_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbMang1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.GroupBox grbMang1;
        private System.Windows.Forms.GroupBox grbMang2;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button KtTest;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
    }
}

