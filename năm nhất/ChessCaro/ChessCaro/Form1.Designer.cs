namespace ChessCaro
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLan = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.ptbPlayer = new System.Windows.Forms.PictureBox();
            this.prbTime = new System.Windows.Forms.ProgressBar();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcbAvatar = new System.Windows.Forms.PictureBox();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStart = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlayer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
            this.menuStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnLan);
            this.panel3.Controls.Add(this.txtIP);
            this.panel3.Controls.Add(this.ptbPlayer);
            this.panel3.Controls.Add(this.prbTime);
            this.panel3.Controls.Add(this.txtPlayer);
            this.panel3.Location = new System.Drawing.Point(509, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 116);
            this.panel3.TabIndex = 5;
            // 
            // btnLan
            // 
            this.btnLan.Location = new System.Drawing.Point(96, 74);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(75, 23);
            this.btnLan.TabIndex = 4;
            this.btnLan.Text = "Kết Nối\r\n";
            this.btnLan.UseVisualStyleBackColor = true;
            this.btnLan.Click += new System.EventHandler(this.btnLan_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(0, 48);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 3;
            // 
            // ptbPlayer
            // 
            this.ptbPlayer.Image = global::ChessCaro.Properties.Resources.ad1;
            this.ptbPlayer.Location = new System.Drawing.Point(112, 1);
            this.ptbPlayer.Name = "ptbPlayer";
            this.ptbPlayer.Size = new System.Drawing.Size(63, 50);
            this.ptbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPlayer.TabIndex = 2;
            this.ptbPlayer.TabStop = false;
            // 
            // prbTime
            // 
            this.prbTime.Location = new System.Drawing.Point(0, 27);
            this.prbTime.Name = "prbTime";
            this.prbTime.Size = new System.Drawing.Size(100, 23);
            this.prbTime.TabIndex = 1;
            this.prbTime.Click += new System.EventHandler(this.prbTime_Click);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(0, 1);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pcbAvatar);
            this.panel2.Location = new System.Drawing.Point(506, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 145);
            this.panel2.TabIndex = 4;
            // 
            // pcbAvatar
            // 
            this.pcbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbAvatar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pcbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbAvatar.Image = global::ChessCaro.Properties.Resources.ad;
            this.pcbAvatar.Location = new System.Drawing.Point(3, -1);
            this.pcbAvatar.Name = "pcbAvatar";
            this.pcbAvatar.Size = new System.Drawing.Size(170, 143);
            this.pcbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAvatar.TabIndex = 0;
            this.pcbAvatar.TabStop = false;
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlChessBoard.Location = new System.Drawing.Point(0, 24);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(509, 405);
            this.pnlChessBoard.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStart
            // 
            this.menuStart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStart.Location = new System.Drawing.Point(0, 0);
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(682, 24);
            this.menuStart.TabIndex = 6;
            this.menuStart.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 462);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStart);
            this.MainMenuStrip = this.menuStart;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlayer)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
            this.menuStart.ResumeLayout(false);
            this.menuStart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLan;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox ptbPlayer;
        private System.Windows.Forms.ProgressBar prbTime;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcbAvatar;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStart;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}

