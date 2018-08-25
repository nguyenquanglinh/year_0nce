namespace VeDoThiLienThong
{
    partial class TimDuong
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
            this.btnTimDuong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDuongMin = new System.Windows.Forms.Button();
            this.cbbBD = new System.Windows.Forms.ComboBox();
            this.cbbKT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTimDuong
            // 
            this.btnTimDuong.Location = new System.Drawing.Point(54, 79);
            this.btnTimDuong.Name = "btnTimDuong";
            this.btnTimDuong.Size = new System.Drawing.Size(75, 23);
            this.btnTimDuong.TabIndex = 0;
            this.btnTimDuong.Text = "Có đường đi";
            this.btnTimDuong.UseVisualStyleBackColor = true;
            this.btnTimDuong.Click += new System.EventHandler(this.btnTimDuong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập điểm bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập điểm kết thúc";
            // 
            // btnDuongMin
            // 
            this.btnDuongMin.Location = new System.Drawing.Point(158, 79);
            this.btnDuongMin.Name = "btnDuongMin";
            this.btnDuongMin.Size = new System.Drawing.Size(75, 23);
            this.btnDuongMin.TabIndex = 5;
            this.btnDuongMin.Text = "Đường ngắn nhất";
            this.btnDuongMin.UseVisualStyleBackColor = true;
            this.btnDuongMin.Click += new System.EventHandler(this.btnDuongMin_Click);
            // 
            // cbbBD
            // 
            this.cbbBD.FormattingEnabled = true;
            this.cbbBD.Location = new System.Drawing.Point(158, 13);
            this.cbbBD.Name = "cbbBD";
            this.cbbBD.Size = new System.Drawing.Size(121, 21);
            this.cbbBD.TabIndex = 6;
            this.cbbBD.SelectedIndexChanged += new System.EventHandler(this.cbbBD_SelectedIndexChanged);
            // 
            // cbbKT
            // 
            this.cbbKT.FormattingEnabled = true;
            this.cbbKT.Location = new System.Drawing.Point(158, 43);
            this.cbbKT.Name = "cbbKT";
            this.cbbKT.Size = new System.Drawing.Size(121, 21);
            this.cbbKT.TabIndex = 7;
            this.cbbKT.SelectedIndexChanged += new System.EventHandler(this.cbbKT_SelectedIndexChanged);
            // 
            // TimDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbbKT);
            this.Controls.Add(this.cbbBD);
            this.Controls.Add(this.btnDuongMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimDuong);
            this.Name = "TimDuong";
            this.Text = "TimDuong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimDuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDuongMin;
        private System.Windows.Forms.ComboBox cbbBD;
        private System.Windows.Forms.ComboBox cbbKT;
    }
}