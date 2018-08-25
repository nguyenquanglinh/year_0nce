namespace Sever
{
    partial class MayChu
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.KhungChat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // KhungChat
            // 
            this.KhungChat.Location = new System.Drawing.Point(3, 34);
            this.KhungChat.Name = "KhungChat";
            this.KhungChat.Size = new System.Drawing.Size(279, 189);
            this.KhungChat.TabIndex = 4;
            this.KhungChat.UseCompatibleStateImageBehavior = false;
            this.KhungChat.View = System.Windows.Forms.View.Tile;
            // 
            // MayChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.KhungChat);
            this.Name = "MayChu";
            this.Text = "Máy chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MayChu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListView KhungChat;
    }
}

