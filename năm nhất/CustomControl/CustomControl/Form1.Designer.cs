namespace CustomControl
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
            this.regexTextBox1 = new CustomControl.RegexTextBox();
            this.inputField1 = new CustomControl.InputField();
            this.SuspendLayout();
            // 
            // regexTextBox1
            // 
            this.regexTextBox1.Location = new System.Drawing.Point(235, 171);
            this.regexTextBox1.Name = "regexTextBox1";
            this.regexTextBox1.RegexString = "^[-+]?\\d*$";
            this.regexTextBox1.Size = new System.Drawing.Size(100, 20);
            this.regexTextBox1.TabIndex = 2;
            // 
            // inputField1
            // 
            this.inputField1.CustomText = "Số dòng:";
            this.inputField1.Location = new System.Drawing.Point(35, 23);
            this.inputField1.Name = "inputField1";
            this.inputField1.Size = new System.Drawing.Size(242, 65);
            this.inputField1.TabIndex = 0;
            this.inputField1.Load += new System.EventHandler(this.inputField1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 360);
            this.Controls.Add(this.regexTextBox1);
            this.Controls.Add(this.inputField1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InputField inputField1;
        private RegexTextBox regexTextBox1;
    }
}

