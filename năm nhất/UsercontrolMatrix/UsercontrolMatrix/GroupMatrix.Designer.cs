namespace UsercontrolMatrix
{
    partial class GroupMatrix
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Location = new System.Drawing.Point(4, 4);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(239, 212);
            this.groupBoxMatrix.TabIndex = 0;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "New Matrix";
            this.groupBoxMatrix.Enter += new System.EventHandler(this.groupBoxMatrix_Enter);
            // 
            // GroupMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxMatrix);
            this.Name = "GroupMatrix";
            this.Size = new System.Drawing.Size(245, 216);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMatrix;
    }
}
