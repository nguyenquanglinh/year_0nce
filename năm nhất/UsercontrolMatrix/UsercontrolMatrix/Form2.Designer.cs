namespace UsercontrolMatrix
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthang = new System.Windows.Forms.TextBox();
            this.txtcot = new System.Windows.Forms.TextBox();
            this.btntao = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.groupMatrix1 = new UsercontrolMatrix.GroupMatrix();
            this.btnTong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "số hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "số cột";
            // 
            // txthang
            // 
            this.txthang.Location = new System.Drawing.Point(113, 6);
            this.txthang.Name = "txthang";
            this.txthang.Size = new System.Drawing.Size(100, 20);
            this.txthang.TabIndex = 2;
            // 
            // txtcot
            // 
            this.txtcot.Location = new System.Drawing.Point(113, 40);
            this.txtcot.Name = "txtcot";
            this.txtcot.Size = new System.Drawing.Size(100, 20);
            this.txtcot.TabIndex = 3;
            // 
            // btntao
            // 
            this.btntao.Location = new System.Drawing.Point(102, 88);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(75, 23);
            this.btntao.TabIndex = 4;
            this.btntao.Text = "tạo";
            this.btntao.UseVisualStyleBackColor = true;
            this.btntao.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(113, 118);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 20);
            this.txtTong.TabIndex = 5;
            // 
            // groupMatrix1
            // 
            this.groupMatrix1.Location = new System.Drawing.Point(13, 138);
            this.groupMatrix1.Name = "groupMatrix1";
            this.groupMatrix1.Size = new System.Drawing.Size(245, 216);
            this.groupMatrix1.TabIndex = 6;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(12, 88);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(75, 23);
            this.btnTong.TabIndex = 7;
            this.btnTong.Text = "tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 375);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.groupMatrix1);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btntao);
            this.Controls.Add(this.txtcot);
            this.Controls.Add(this.txthang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthang;
        private System.Windows.Forms.TextBox txtcot;
        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.TextBox txtTong;
        private GroupMatrix groupMatrix1;
        private System.Windows.Forms.Button btnTong;
    }
}