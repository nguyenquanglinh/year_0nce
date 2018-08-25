using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatForm
{
    public partial class BanCaro : UserControl
    {
        public BanCaro()
        {
            InitializeComponent();
        }
        Button[,] arrChessBoard;
        public void NewChessBoard(int heightBoard, int widthBoard, Player mesterPlayer, Player guestPlayer)
        {
            this.widthBoard = widthBoard / 20;
            this.heightBoard = heightBoard / 20;
            arrChessBoard = new Button[this.heightBoard, this.widthBoard];
            pnlChessBoard.Controls.Clear();
            pnlChessBoard.Enabled = true;
            pnlChessBoard.Controls.Clear();
            int ox = 0;
            int oy = 0;
            for (int i = 0; i < this.heightBoard; i++)
            {
                for (int j = 0; j < this.widthBoard; j++)
                {
                    arrChessBoard[i, j] = new Button()
                    {
                        Width = 20,
                        Height = 20,
                        Location = new Point(ox, oy),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString() + ";" + j.ToString(),
                    };
                    arrChessBoard[i, j].Click += oTrong_Click;
                    ox += 20;
                    pnlChessBoard.Controls.Add(arrChessBoard[i, j]);
                }
                oy += 20;
                ox = 0;
            }
        }

        private void oTrong_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;
            stringLoaction = btn.Tag.ToString();
            MasterClick();
            YouWin();
        }
        string stringLoaction;
        private void YouWin()
        {
            var location = GetLoaction(stringLoaction);
            if (WinCrossoverLeft(location.X, location.Y) || WinCrossoverRight(location.X, location.Y) || WinHorizantol(location.X, location.Y) || WinVertical(location.X, location.Y))
            {
                SomeoneWins();
                EndGame();
            }
        }

        private object GetLoaction(string stringLoaction)
        {
            var chuoi = stringLocation.Split(';');
            var x = int.Parse(chuoi[0]);
            var y = int.Parse(chuoi[1]);
            return new Location(x, y);
        }
        public event EventHandler PlayerClick;

        private void MasterClick()
        {
            if (PlayerClick != null)
                PlayerClick(this, new EventArgs());
        }



        public int widthBoard { get; set; }

        public int heightBoard { get; set; }
    }
}
