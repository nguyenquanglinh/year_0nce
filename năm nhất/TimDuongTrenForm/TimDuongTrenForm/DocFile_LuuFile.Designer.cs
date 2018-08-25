namespace TimDuongTrenForm
{
    partial class DocFile_LuuFile
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
            this.cbbFileDaLuu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.grbDocFile = new System.Windows.Forms.GroupBox();
            this.grbLuu = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDocFile.SuspendLayout();
            this.grbLuu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbFileDaLuu
            // 
            this.cbbFileDaLuu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFileDaLuu.Enabled = false;
            this.cbbFileDaLuu.FormattingEnabled = true;
            this.cbbFileDaLuu.Location = new System.Drawing.Point(130, 72);
            this.cbbFileDaLuu.Name = "cbbFileDaLuu";
            this.cbbFileDaLuu.Size = new System.Drawing.Size(122, 21);
            this.cbbFileDaLuu.TabIndex = 0;
            this.cbbFileDaLuu.SelectedValueChanged += new System.EventHandler(this.cbbFileDaLuu_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.MinimumSize = new System.Drawing.Size(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Các file đã lưu";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(132, 106);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "LuuFile";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Enabled = false;
            this.btnDoc.Location = new System.Drawing.Point(163, 121);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(75, 23);
            this.btnDoc.TabIndex = 3;
            this.btnDoc.Text = "Đọc File";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // grbDocFile
            // 
            this.grbDocFile.Controls.Add(this.button1);
            this.grbDocFile.Controls.Add(this.btnDoc);
            this.grbDocFile.Controls.Add(this.cbbFileDaLuu);
            this.grbDocFile.Controls.Add(this.label1);
            this.grbDocFile.Location = new System.Drawing.Point(2, 12);
            this.grbDocFile.Name = "grbDocFile";
            this.grbDocFile.Size = new System.Drawing.Size(278, 207);
            this.grbDocFile.TabIndex = 4;
            this.grbDocFile.TabStop = false;
            this.grbDocFile.Text = "Đọc File";
            // 
            // grbLuu
            // 
            this.grbLuu.Controls.Add(this.label2);
            this.grbLuu.Controls.Add(this.txtDinh);
            this.grbLuu.Controls.Add(this.btnLuu);
            this.grbLuu.Location = new System.Drawing.Point(279, 12);
            this.grbLuu.Name = "grbLuu";
            this.grbLuu.Size = new System.Drawing.Size(259, 207);
            this.grbLuu.TabIndex = 5;
            this.grbLuu.TabStop = false;
            this.grbLuu.Text = "Lưu file";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lấy tất cả các file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDinh
            // 
            this.txtDinh.Location = new System.Drawing.Point(143, 40);
            this.txtDinh.Name = "txtDinh";
            this.txtDinh.Size = new System.Drawing.Size(100, 20);
            this.txtDinh.TabIndex = 3;
            this.txtDinh.Text = "nhập tên File";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên File cần lưu";
            // 
            // DocFile_LuuFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 303);
            this.Controls.Add(this.grbLuu);
            this.Controls.Add(this.grbDocFile);
            this.Name = "DocFile_LuuFile";
            this.Text = "DocFile_LuuFile";
            this.grbDocFile.ResumeLayout(false);
            this.grbLuu.ResumeLayout(false);
            this.grbLuu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbFileDaLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.GroupBox grbDocFile;
        private System.Windows.Forms.GroupBox grbLuu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDinh;
    }
}