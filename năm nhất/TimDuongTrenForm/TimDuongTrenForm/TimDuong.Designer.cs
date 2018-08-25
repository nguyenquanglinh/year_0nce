namespace TimDuongTrenForm
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
            this.cbbBd = new System.Windows.Forms.ComboBox();
            this.cbbKt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbBd
            // 
            this.cbbBd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBd.FormattingEnabled = true;
            this.cbbBd.Location = new System.Drawing.Point(202, 19);
            this.cbbBd.Name = "cbbBd";
            this.cbbBd.Size = new System.Drawing.Size(70, 21);
            this.cbbBd.TabIndex = 0;
            this.cbbBd.SelectedIndexChanged += new System.EventHandler(this.cbbBd_SelectedIndexChanged);
            // 
            // cbbKt
            // 
            this.cbbKt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKt.FormattingEnabled = true;
            this.cbbKt.Location = new System.Drawing.Point(202, 68);
            this.cbbKt.Name = "cbbKt";
            this.cbbKt.Size = new System.Drawing.Size(70, 21);
            this.cbbKt.TabIndex = 1;
            this.cbbKt.SelectedIndexChanged += new System.EventHandler(this.cbbKt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập điểm bắt đầu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập điểm kết thúc";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đường ngắn nhất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbKt);
            this.Controls.Add(this.cbbBd);
            this.Name = "TimDuong";
            this.Text = "TimDuong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbBd;
        private System.Windows.Forms.ComboBox cbbKt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}