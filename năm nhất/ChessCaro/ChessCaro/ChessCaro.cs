using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessCaro
{
    public class ChessCaro
    {
        Panel Chessboard;

        Panel ChessBoard
        {
            get
            {
                return Chessboard;
            }
            set
            {
                Chessboard = value;
            }
        }

        TextBox playerText;

        public TextBox PlayerText
        {
            get { return playerText; }
            set { playerText = value; }
        }

        PictureBox imagePlayer;

        public PictureBox ImagePlayer
        {
            get { return imagePlayer; }
            set { imagePlayer = value; }
        }

        List<List<Button>> ListButon;

        public List<List<Button>> ListButon1
        {
            get { return ListButon; }
            set { ListButon = value; }
        }

        public ChessCaro(Panel chess, TextBox textPlayer, PictureBox imagePlayer)
        {
            this.ChessBoard = chess;
            this.Listplayer = new List<Player>();
            PlayerText = textPlayer;
            ImagePlayer = imagePlayer;
            Listplayer.Add(new Player("quang ", Image.FromFile(Application.StartupPath + "\\Resources\\1.png")));
            Listplayer.Add(new Player("linh", Image.FromFile(Application.StartupPath + "\\Resources\\3.png")));
            playerNewPerson = 0;
            changePlayer();
        }

        int playerNewPerson;

        public int PlayerNewPerson
        {
            get { return playerNewPerson; }
            set { playerNewPerson = value; }
        }

        int ox, oy;

        public bool Undo()
        {
            if (PlayTime.Count <= 0)

                return false;

            var point = PlayTime.Pop();

            var btn = ListButon[point.Point.Y][point.Point.X];

            btn.BackgroundImage = null;
            if (PlayTime.Count <= 0)
            {
                PlayerNewPerson = 0;
            }
            else
            {
                point = PlayTime.Peek();
                playerNewPerson = playerNewPerson == 1 ? 0 : 1;
            }

            changePlayer();
            return true;


        }

        private Stack<PlayInform> playTime;

        public Stack<PlayInform> PlayTime
        {
            get { return playTime; }
            set { playTime = value; }
        }

        public void NewChessBoard()
        {
            Chessboard.Enabled = true;
            Chessboard.Controls.Clear();
            ListButon = new List<List<Button>>();
            PlayTime = new Stack<PlayInform>();
            ox = 0;
            oy = 0;
            for (int i = 0; i < 20; i++)
            {
                ListButon.Add(new List<Button>());
                for (int j = 0; j < 24; j++)
                {
                    var x = new Button()
                    {
                        Width = 20,
                        Height = 20,
                        Location = new Point(ox + 3, oy),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    ox += 20;
                    x.Click += x_Click;
                    ChessBoard.Controls.Add(x);
                    ListButon[i].Add(x);
                }
                oy += 20;
                ox = 0;
            }
        }

        bool Win(Button x)
        {
            return WinHorizontal(x) || WinCrossover(x) || WinSub(x) || WinVertical(x);
        }

        bool WinHorizontal(Button x)//hang ngang
        {
            var point = GetLocation(x);
            int trai = 0, phai = 0;
            for (int i = point.X; i >= 0; i--)
            {

                if (ListButon[point.Y][i].BackgroundImage == x.BackgroundImage)
                    trai++;
                else break;
            }
            for (int i = point.X + 1; i < 24; i++)
            {
                if (ListButon[point.Y][i].BackgroundImage == x.BackgroundImage)
                    phai++;
                else break;
            }
            return trai + phai == 5;
        }

        bool WinVertical(Button x)//hang doc
        {
            int tren = 0, duoi = 0;
            var point = GetLocation(x);
            for (int i = point.Y - 1; i >= 0; i--)
            {
                if (ListButon[i][point.X].BackgroundImage == x.BackgroundImage)
                    tren++;
                else break;
            }
            for (int i = point.Y; i < 20; i++)
            {
                if (ListButon[i][point.X].BackgroundImage == x.BackgroundImage)
                    duoi++;
                else break;
            }

            return tren + duoi == 5;
        }

        bool WinCrossover(Button x)//hang cheo chinh
        {

            int tren = 0, duoi = 0;
            var point = GetLocation(x);
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i >= 0 && point.Y - i >= 0)

                    if (ListButon[point.Y - i][point.X - i].BackgroundImage == x.BackgroundImage)
                        tren++;
                    else break;
            }



            for (int i = 1; i < 24 - point.X; i++)
            {
                if (point.X + i < 24 && point.Y + i < 20)

                    if (ListButon[point.Y + i][point.X + i].BackgroundImage == x.BackgroundImage)
                        duoi++;
                    else break;

            }

            return tren + duoi == 5;
        }

        bool WinSub(Button x)//hang cheophu
        {

            int tren = 0, duoi = 0;
            var point = GetLocation(x);
            for (int i = 0; i < point.X; i++)
            {
                if (point.X + i < 24 && point.Y - i >= 0)
                {
                    if (ListButon[point.Y - i][point.X + i].BackgroundImage == x.BackgroundImage)
                        tren++;
                }
                else
                    break;
            }
            for (int i = 1; i < 24 - point.X; i++)
            {
                if (point.X - i >= 0 && point.Y + i < 20)
                {
                    if (ListButon[point.Y + i][point.X - i].BackgroundImage == x.BackgroundImage)
                        duoi++;
                }
                else break;
            }

            return tren + duoi == 5;
        }

        //event
        event EventHandler ketThuc;

        public event EventHandler KetThuc
        {
            add
            {
                ketThuc += value;
            }
            remove
            {
                ketThuc -= value;
            }
        }

        event EventHandler nguoiChoi;

        public event EventHandler NguoiChoi
        {
            add
            {
                nguoiChoi += value;
            }
            remove
            {
                nguoiChoi -= value;
            }
        }

        public void EndGame()
        {
            if (ketThuc != null)
            {
                ketThuc(this, new EventArgs());
                MessageBox.Show("you Win");
            }

        }

        List<Player> Listplayer;

        public Point GetLocation(Button x)
        {

            var n = Convert.ToInt32(x.Tag);
            int m = ListButon[n].IndexOf(x);
            var point = new Point(m, n);
            return point;
        }

        void x_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            PlayerNext(btn);
            PlayTime.Push(new PlayInform(GetLocation(btn), playerNewPerson));
            playerNewPerson = playerNewPerson == 1 ? 0 : 1;
            changePlayer();
            if (nguoiChoi != null)
                nguoiChoi(this, new EventArgs());
            if (Win(btn))
            {
                EndGame();
                return;
            }

        }

        private void changePlayer()
        {
            PlayerText.Text = Listplayer[playerNewPerson].Name;
            imagePlayer.Image = Listplayer[playerNewPerson].PlayerMark;
        }

        private void PlayerNext(Button x)
        {
            x.BackgroundImage = Listplayer[playerNewPerson].PlayerMark;

        }

    }
}
