namespace TinhSoLonBieuThucTrungTo
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
            this.txtBtTrungTo = new System.Windows.Forms.TextBox();
            this.txtbtHauTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRessulst = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập biểu thức trung tố :";
            // 
            // txtBtTrungTo
            // 
            this.txtBtTrungTo.Location = new System.Drawing.Point(145, 31);
            this.txtBtTrungTo.Name = "txtBtTrungTo";
            this.txtBtTrungTo.Size = new System.Drawing.Size(127, 20);
            this.txtBtTrungTo.TabIndex = 1;
            // 
            // txtbtHauTo
            // 
            this.txtbtHauTo.Location = new System.Drawing.Point(145, 71);
            this.txtbtHauTo.Name = "txtbtHauTo";
            this.txtbtHauTo.Size = new System.Drawing.Size(127, 20);
            this.txtbtHauTo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "kết quả  biểu thức hậu tố :";
            // 
            // btnRessulst
            // 
            this.btnRessulst.Location = new System.Drawing.Point(160, 110);
            this.btnRessulst.Name = "btnRessulst";
            this.btnRessulst.Size = new System.Drawing.Size(75, 23);
            this.btnRessulst.TabIndex = 4;
            this.btnRessulst.Text = "Kết quả";
            this.btnRessulst.UseVisualStyleBackColor = true;
            this.btnRessulst.Click += new System.EventHandler(this.btnRessulst_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu file";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(81, 172);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Đọc file";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRessulst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbtHauTo);
            this.Controls.Add(this.txtBtTrungTo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBtTrungTo;
        private System.Windows.Forms.TextBox txtbtHauTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRessulst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;

    }
}

