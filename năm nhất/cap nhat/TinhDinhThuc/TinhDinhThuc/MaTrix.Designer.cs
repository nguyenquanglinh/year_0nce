namespace TinhDinhThuc
{
    partial class MaTrix
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
            this.grbMatrix = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grbMatrix
            // 
            this.grbMatrix.Location = new System.Drawing.Point(0, 3);
            this.grbMatrix.Name = "grbMatrix";
            this.grbMatrix.Size = new System.Drawing.Size(231, 201);
            this.grbMatrix.TabIndex = 0;
            this.grbMatrix.TabStop = false;
            this.grbMatrix.Text = "Mảng được tạo";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbMatrix);
            this.Name = "MaTrix";
            this.Size = new System.Drawing.Size(236, 204);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMatrix;
    }
}
