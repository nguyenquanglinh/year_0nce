namespace ChatForm
{
    partial class MayKhach
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.KhungChat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.prbTime = new System.Windows.Forms.ProgressBar();
            this.txtHienTai = new System.Windows.Forms.TextBox();
            this.btnHienTai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendFileBig = new System.Windows.Forms.Button();
            this.cbbPlayerName = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boardCaro1 = new ChatForm.BoardCaro();
            this.menuStrip1.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(82, 148);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(118, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // KhungChat
            // 
            this.KhungChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KhungChat.Location = new System.Drawing.Point(62, 250);
            this.KhungChat.Name = "KhungChat";
            this.KhungChat.ReadOnly = true;
            this.KhungChat.Size = new System.Drawing.Size(138, 58);
            this.KhungChat.TabIndex = 3;
            this.KhungChat.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserName :";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(150, 340);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(50, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(24, 184);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(65, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(62, 302);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(138, 20);
            this.txtMessage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "YouName :";
            // 
            // btnSendFile
            // 
            this.btnSendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendFile.Location = new System.Drawing.Point(82, 340);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(56, 23);
            this.btnSendFile.TabIndex = 7;
            this.btnSendFile.Text = "SendFile";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click_1);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.prbTime);
            this.grbThongTin.Controls.Add(this.txtHienTai);
            this.grbThongTin.Controls.Add(this.btnHienTai);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Location = new System.Drawing.Point(1, 28);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(206, 115);
            this.grbThongTin.TabIndex = 14;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // prbTime
            // 
            this.prbTime.Location = new System.Drawing.Point(81, 55);
            this.prbTime.Name = "prbTime";
            this.prbTime.Size = new System.Drawing.Size(112, 23);
            this.prbTime.TabIndex = 9;
            // 
            // txtHienTai
            // 
            this.txtHienTai.Location = new System.Drawing.Point(81, 19);
            this.txtHienTai.Name = "txtHienTai";
            this.txtHienTai.ReadOnly = true;
            this.txtHienTai.Size = new System.Drawing.Size(83, 20);
            this.txtHienTai.TabIndex = 3;
            // 
            // btnHienTai
            // 
            this.btnHienTai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHienTai.Enabled = false;
            this.btnHienTai.Image = global::ChatForm.Properties.Resources._3;
            this.btnHienTai.Location = new System.Drawing.Point(170, 19);
            this.btnHienTai.Name = "btnHienTai";
            this.btnHienTai.Size = new System.Drawing.Size(23, 19);
            this.btnHienTai.TabIndex = 2;
            this.btnHienTai.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lượt chơi :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendFileBig);
            this.groupBox1.Controls.Add(this.cbbPlayerName);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.grbThongTin);
            this.groupBox1.Controls.Add(this.btnSendFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.KhungChat);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(553, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 369);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // btnSendFileBig
            // 
            this.btnSendFileBig.Location = new System.Drawing.Point(6, 340);
            this.btnSendFileBig.Name = "btnSendFileBig";
            this.btnSendFileBig.Size = new System.Drawing.Size(75, 23);
            this.btnSendFileBig.TabIndex = 18;
            this.btnSendFileBig.Text = "SendFileBig";
            this.btnSendFileBig.UseVisualStyleBackColor = true;
            this.btnSendFileBig.Click += new System.EventHandler(this.btnSendFileBig_Click);
            // 
            // cbbPlayerName
            // 
            this.cbbPlayerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPlayerName.FormattingEnabled = true;
            this.cbbPlayerName.Location = new System.Drawing.Point(82, 214);
            this.cbbPlayerName.Name = "cbbPlayerName";
            this.cbbPlayerName.Size = new System.Drawing.Size(118, 21);
            this.cbbPlayerName.TabIndex = 17;
            this.cbbPlayerName.SelectedIndexChanged += new System.EventHandler(this.cbbPlayerName_SelectedIndexChanged);
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(106, 184);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "FindPlayer";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Timer :";
            // 
            // boardCaro1
            // 
            this.boardCaro1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.boardCaro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardCaro1.heightBoard = 0;
            this.boardCaro1.Location = new System.Drawing.Point(0, 24);
            this.boardCaro1.Name = "boardCaro1";
            this.boardCaro1.Player = null;
            this.boardCaro1.Size = new System.Drawing.Size(759, 369);
            this.boardCaro1.stringLocation = null;
            this.boardCaro1.TabIndex = 19;
            this.boardCaro1.Wait = false;
            this.boardCaro1.widthBoard = 0;
            // 
            // MayKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boardCaro1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MayKhach";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MayKhach_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private BoardCaro boardCaro1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.RichTextBox KhungChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.ProgressBar prbTime;
        private System.Windows.Forms.TextBox txtHienTai;
        private System.Windows.Forms.Button btnHienTai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbbPlayerName;
        private System.Windows.Forms.Button btnSendFileBig;
        private System.Windows.Forms.Label label3;
    }
}

