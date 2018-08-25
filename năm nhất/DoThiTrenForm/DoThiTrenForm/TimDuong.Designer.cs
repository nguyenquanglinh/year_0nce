namespace DoThiTrenForm
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
            this.cbbBatDau = new System.Windows.Forms.ComboBox();
            this.cbbKetThuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbBatDau
            // 
            this.cbbBatDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBatDau.FormattingEnabled = true;
            this.cbbBatDau.Location = new System.Drawing.Point(163, 22);
            this.cbbBatDau.Name = "cbbBatDau";
            this.cbbBatDau.Size = new System.Drawing.Size(121, 21);
            this.cbbBatDau.TabIndex = 0;
            this.cbbBatDau.SelectedValueChanged += new System.EventHandler(this.cbbBatDau_SelectedValueChanged);
            // 
            // cbbKetThuc
            // 
            this.cbbKetThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKetThuc.FormattingEnabled = true;
            this.cbbKetThuc.Location = new System.Drawing.Point(163, 67);
            this.cbbKetThuc.Name = "cbbKetThuc";
            this.cbbKetThuc.Size = new System.Drawing.Size(121, 21);
            this.cbbKetThuc.TabIndex = 1;
            this.cbbKetThuc.SelectedIndexChanged += new System.EventHandler(this.cbbKetThuc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Điểm bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm kết thúc";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(96, 119);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm Đường";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // TimDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 167);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbKetThuc);
            this.Controls.Add(this.cbbBatDau);
            this.Name = "TimDuong";
            this.Text = "TimDuong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbBatDau;
        private System.Windows.Forms.ComboBox cbbKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
    }
}