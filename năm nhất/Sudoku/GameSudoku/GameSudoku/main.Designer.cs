namespace GameSudoku
{
    partial class GameSudoku
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacCauHoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKtKq = new System.Windows.Forms.Button();
            this.chessboardSudoku3 = new ChessboardSudoku();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Giải sudoku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.newGameToolStripMenuItem.Text = "Game mới";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // cacCauHoi
            // 
            this.cacCauHoi.FormattingEnabled = true;
            this.cacCauHoi.Location = new System.Drawing.Point(519, 48);
            this.cacCauHoi.Name = "cacCauHoi";
            this.cacCauHoi.Size = new System.Drawing.Size(52, 21);
            this.cacCauHoi.TabIndex = 3;
            this.cacCauHoi.SelectedValueChanged += new System.EventHandler(this.cacCauHoi_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Các bàn chơi";
            // 
            // btnKtKq
            // 
            this.btnKtKq.Location = new System.Drawing.Point(519, 158);
            this.btnKtKq.Name = "btnKtKq";
            this.btnKtKq.Size = new System.Drawing.Size(75, 23);
            this.btnKtKq.TabIndex = 5;
            this.btnKtKq.Text = "Kiểm tra kết quả";
            this.btnKtKq.UseVisualStyleBackColor = true;
            this.btnKtKq.Click += new System.EventHandler(this.btnKtKq_Click);
            // 
            // chessboardSudoku3
            // 
            this.chessboardSudoku3.Location = new System.Drawing.Point(13, 28);
            this.chessboardSudoku3.Name = "chessboardSudoku3";
            this.chessboardSudoku3.Size = new System.Drawing.Size(514, 474);
            this.chessboardSudoku3.TabIndex = 6;
            // 
            // GameSudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 549);
            this.Controls.Add(this.chessboardSudoku3);
            this.Controls.Add(this.btnKtKq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cacCauHoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameSudoku";
            this.Text = "GameSudoku";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ComboBox cacCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKtKq;
        private ChessboardSudoku chessboardSudoku1;
        private ChessboardSudoku chessboardSudoku2;
        private ChessboardSudoku chessboardSudoku3;
    }
}

