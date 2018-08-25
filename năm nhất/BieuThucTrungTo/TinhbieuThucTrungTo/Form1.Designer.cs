namespace TinhbieuThucTrungTo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrungTo = new System.Windows.Forms.TextBox();
            this.txttienTo = new System.Windows.Forms.TextBox();
            this.btnhauTo = new System.Windows.Forms.Button();
            this.btnKq = new System.Windows.Forms.Button();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.MaximumSize = new System.Drawing.Size(160, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập biểu thức trung tố";
            // 
            // txtTrungTo
            // 
            this.txtTrungTo.Location = new System.Drawing.Point(148, 22);
            this.txtTrungTo.Name = "txtTrungTo";
            this.txtTrungTo.Size = new System.Drawing.Size(124, 20);
            this.txtTrungTo.TabIndex = 1;
            // 
            // txttienTo
            // 
            this.txttienTo.Location = new System.Drawing.Point(147, 85);
            this.txttienTo.Name = "txttienTo";
            this.txttienTo.ReadOnly = true;
            this.txttienTo.Size = new System.Drawing.Size(124, 20);
            this.txttienTo.TabIndex = 3;
            // 
            // btnhauTo
            // 
            this.btnhauTo.Location = new System.Drawing.Point(28, 82);
            this.btnhauTo.Name = "btnhauTo";
            this.btnhauTo.Size = new System.Drawing.Size(75, 23);
            this.btnhauTo.TabIndex = 4;
            this.btnhauTo.Text = "Hậu tố";
            this.btnhauTo.UseVisualStyleBackColor = true;
            this.btnhauTo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKq
            // 
            this.btnKq.Location = new System.Drawing.Point(28, 153);
            this.btnKq.Name = "btnKq";
            this.btnKq.Size = new System.Drawing.Size(75, 23);
            this.btnKq.TabIndex = 5;
            this.btnKq.Text = "Kết quả ";
            this.btnKq.UseVisualStyleBackColor = true;
            this.btnKq.Click += new System.EventHandler(this.btnKq_Click);
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(148, 156);
            this.txtKq.Name = "txtKq";
            this.txtKq.ReadOnly = true;
            this.txtKq.Size = new System.Drawing.Size(73, 20);
            this.txtKq.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.btnKq);
            this.Controls.Add(this.btnhauTo);
            this.Controls.Add(this.txttienTo);
            this.Controls.Add(this.txtTrungTo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrungTo;
        private System.Windows.Forms.TextBox txttienTo;
        private System.Windows.Forms.Button btnhauTo;
        private System.Windows.Forms.Button btnKq;
        private System.Windows.Forms.TextBox txtKq;
    }
}

