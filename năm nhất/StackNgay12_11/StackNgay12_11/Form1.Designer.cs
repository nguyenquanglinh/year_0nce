namespace StackNgay12_11
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
            this.stack2 = new StackNgay12_11.Stack();
            this.SuspendLayout();
            // 
            // stack2
            // 
            this.stack2.Location = new System.Drawing.Point(36, 31);
            this.stack2.Name = "stack2";
            this.stack2.Size = new System.Drawing.Size(634, 307);
            this.stack2.TabIndex = 1;
            this.stack2.Load += new System.EventHandler(this.stack2_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 360);
            this.Controls.Add(this.stack2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Stack stack2;

    }
}

