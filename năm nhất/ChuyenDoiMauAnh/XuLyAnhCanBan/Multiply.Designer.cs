namespace XuLyAnhCanBan
{
    partial class Multiply
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
            this.cbbLuaChon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbLuaChon
            // 
            this.cbbLuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLuaChon.FormattingEnabled = true;
            this.cbbLuaChon.Items.AddRange(new object[] {
            "Null",
            "3X3(4)",
            "3x3(8)",
            "4x4",
            "5x5",
            "7x7",
            "9x9"});
            this.cbbLuaChon.Location = new System.Drawing.Point(131, 32);
            this.cbbLuaChon.Name = "cbbLuaChon";
            this.cbbLuaChon.Size = new System.Drawing.Size(98, 21);
            this.cbbLuaChon.TabIndex = 0;
            this.cbbLuaChon.SelectedIndexChanged += new System.EventHandler(this.cbbLuaChon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lựa chọn";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(131, 117);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Multiply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLuaChon);
            this.Name = "Multiply";
            this.Text = "Multiply";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbLuaChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
    }
}