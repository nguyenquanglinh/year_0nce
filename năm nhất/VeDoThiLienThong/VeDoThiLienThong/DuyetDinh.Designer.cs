namespace VeDoThiLienThong
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDinh = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbbCacDinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhâp Đỉnh Cần Duyệt";
            // 
            // btnDinh
            // 
            this.btnDinh.Location = new System.Drawing.Point(168, 58);
            this.btnDinh.Name = "btnDinh";
            this.btnDinh.Size = new System.Drawing.Size(75, 23);
            this.btnDinh.TabIndex = 2;
            this.btnDinh.Text = "DuyetDinh";
            this.btnDinh.UseVisualStyleBackColor = true;
            this.btnDinh.Click += new System.EventHandler(this.btnDinh_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // cbbCacDinh
            // 
            this.cbbCacDinh.FormattingEnabled = true;
            this.cbbCacDinh.Location = new System.Drawing.Point(140, 12);
            this.cbbCacDinh.Name = "cbbCacDinh";
            this.cbbCacDinh.Size = new System.Drawing.Size(121, 21);
            this.cbbCacDinh.TabIndex = 3;
            this.cbbCacDinh.SelectedValueChanged += new System.EventHandler(this.cbbCacDinh_SelectedValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbbCacDinh);
            this.Controls.Add(this.btnDinh);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDinh;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.ComboBox cbbCacDinh;
    }
}