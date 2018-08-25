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
    public partial class BoardCaro : UserControl
    {
        public BoardCaro()
        {
            InitializeComponent();
        }
        bool wait;
        /// <summary>
        /// Nếu wait = true thì ko đánh khi ngươi dùng click
        /// </summary>
        public bool Wait { get { return wait; } set { wait = value; } }
        #region Biến toàn cục
        Button[,] arrChessBoard;

        public int widthBoard { get; set; }

        public int heightBoard { get; set; }

        #endregion

        #region tất cả sự kiện
        //sự kiện kết thúc
        public event EventHandler ketThuc;

        //sự kiện lấy thông tin người chơi
        public event EventHandler PlayerClick;

        /// khi có sự kiện từ ngoài vào
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void GesterClick(string chuoi, Player player)
        {
            var location = GetLoaction(chuoi);
            var ss = arrChessBoard[location.X, location.Y];
            oTrong_Click_Not_Send(ss, player);
        }




        //sự kiện từ trong ra
        private void MasterClick()
        {
            if (PlayerClick != null)
                PlayerClick(this, new EventArgs());
        }

        private void SomeoneWins()
        {
            if (ketThuc != null)
                ketThuc(this, new EventArgs());
        }

        #endregion

        #region bàn cờ
        /// <summary>
        /// tạo bàn chơi mới
        /// </summary>
        /// <param name="heightBoard"></param>
        /// <param name="widthBoard"></param>
        /// <param name="mesterName"></param>
        /// <param name="guestName"></param>
        public void NewChessBoard(int heightBoard, int widthBoard, Player player)
        {
            this.Player = player;
            this.widthBoard = widthBoard / 20;
            this.heightBoard = heightBoard / 20;
            arrChessBoard = new Button[this.heightBoard, this.widthBoard];
            pnlChessBoard.Controls.Clear();
            this.Enabled = true;
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
        /// <summary>
        /// tìm ra người thắng cuộc
        /// </summary>
        /// <param name="dsButtonCanKiemTRa"></param>
        /// <param name="btn"></param>
        /// <returns></returns>
        bool FindTheWiner(List<Button> dsButtonCanKiemTRa, Button btn)
        {
            int dem = 0;
            for (int i = 0; i < dsButtonCanKiemTRa.Count; i++)
            {
                if (btn.BackgroundImage == dsButtonCanKiemTRa[i].BackgroundImage)
                {
                    dem++;
                    if (dem == 5)
                        return true;
                }
                else
                    dem = 0;
            }
            return false;
        }
        /// <summary>
        /// lấy tất cả cac button theo hàng ngang
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        List<Button> LayTheoHangNgang(int x)
        {
            var ret = new List<Button>();
            for (int i = 0; i < widthBoard; i++)
                ret.Add(arrChessBoard[x, i]);
            return ret;
        }
        /// <summary>
        /// lấy tất cả các button theo hình chéo chính
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        List<Button> LayTheoHinhCheoChinh(int x, int y)
        {
            var ret = new List<Button>();
            ret.Add(arrChessBoard[x, y]);
            var a = x + 1;
            var b = y + 1;
            //lấy theo đường đi lên
            while (a < heightBoard && b < widthBoard)
            {
                ret.Add(arrChessBoard[a, b]);
                a++;
                b++;
            }
            a = x - 1;
            b = y - 1;
            //lấy theo đường đi xuống
            ret.Add(arrChessBoard[x, y]);
            while (a >= 0 && b >= 0)
            {
                ret.Add(arrChessBoard[a, b]);
                a--;
                b--;
            }
            return ret;
        }
        /// <summary>
        /// lấy tất cả các button theo hình chéo phụ
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        List<Button> LayTheoHinhCheoPhu(int x, int y)
        {
            var ret = new List<Button>();
            ret.Add(arrChessBoard[x, y]);
            var a = x + 1;
            var b = y - 1;
            while (a < heightBoard && b >= 0)
            {
                ret.Add(arrChessBoard[a, b]);
                a++;
                b--;
            }
            a = x - 1;
            b = y + 1;
            ret.Add(arrChessBoard[x, y]);
            while (a >= 0 && b < widthBoard)
            {
                ret.Add(arrChessBoard[a, b]);
                a--;
                b++;
            }
            return ret;
        }
        /// <summary>
        /// lấy tất cả các button theo hàng dọc
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        List<Button> LayTheoHangDoc(int y)
        {
            var ret = new List<Button>();
            for (int i = 0; i < heightBoard; i++)
                ret.Add(arrChessBoard[i, y]);
            return ret;
        }

        /// <summary>
        /// sự kiện click vào ô trống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oTrong_Click_Not_Send(object sender, Player player)
        {
            var btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;
            if (Wait)
            {
                return;
            }

            stringLocation = btn.Tag.ToString();
            btn.BackgroundImage = player.PlayerPhoto;
            YouWin(player.NamePlayer);
        }

        /// <summary>
        /// sự kiện click vào ô trống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oTrong_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;
            if (Wait)
            {
                return;
            }

            stringLocation = btn.Tag.ToString();

            btn.BackgroundImage = Player.PlayerPhoto;
            MasterClick();
            YouWin(Player.NamePlayer);
        }
        /// <summary>
        /// kiểm tra tất cả các trường hợp thắng
        /// </summary>
        /// 
        private void YouWin(string name)
        {
            var location = GetLoaction(stringLocation);
            if (WinCrossoverLeft(location.X, location.Y) || WinCrossoverRight(location.X, location.Y) || WinHorizantol(location.X, location.Y) || WinVertical(location.X, location.Y))
            {
                SomeoneWins();
                MessageBox.Show(name + ": is winer");
                EndGame();
            }
        }
        /// <summary>
        /// thắng theo hàng chéo phụ
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool WinCrossoverLeft(int x, int y)
        {
            var dshangCheo = LayTheoHinhCheoPhu(x, y);
            return FindTheWiner(dshangCheo, arrChessBoard[x, y]);
        }

        /// <summary>
        /// thắng theo hình chéo phụ
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool WinCrossoverRight(int x, int y)
        {
            var dsCheoPhai = LayTheoHinhCheoChinh(x, y);
            return FindTheWiner(dsCheoPhai, arrChessBoard[x, y]);
        }
        /// <summary>
        /// thắng theo chiều ngang
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool WinHorizantol(int x, int y)
        {
            var dsHangNgang = LayTheoHangNgang(x);
            return FindTheWiner(dsHangNgang, arrChessBoard[x, y]);
        }
        /// <summary>
        /// thắng theo chiều dọc
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool WinVertical(int x, int y)
        {
            var dsHangDoc = LayTheoHangDoc(y);
            return FindTheWiner(dsHangDoc, arrChessBoard[x, y]);
        }
        #endregion

        //#region Thông tin người chơi hiện tại

        //string stringLoaction;
        //private bool laX;

        //public string stringLocation
        //{
        //    get
        //    {
        //        return stringLoaction;
        //    }
        //}
        //public string NamePlayerCurrent
        //{
        //    get
        //    {
        //        return playerCurrent.NamePlayer;
        //    }
        //}

        //public Image PhotoPlayerCurrunt
        //{
        //    get
        //    {
        //        return playerCurrent.PlayerPhoto;
        //    }
        //}

        //#endregion

        //#region Thông tin người chơi tiếp theo
        //public string NamePlayerNext
        //{
        //    get
        //    {
        //        return PlayerNew.NamePlayer;
        //    }
        //}

        //public Image PhotoPlayerNext
        //{
        //    get
        //    {
        //        return PlayerNew.PlayerPhoto;
        //    }
        //}

        //#endregion

        #region Thay đổi người chơi

        /// <summary>
        /// thêm thông tin tọa độ của btn
        /// </summary>
        /// <param name="btn"></param>
        private Location GetLoaction(string stringLocation)
        {
            var chuoi = stringLocation.Split(';');
            var x = int.Parse(chuoi[0]);
            var y = int.Parse(chuoi[1]);
            return new Location(x, y);
        }

        /// <summary>
        /// kết thúc trò chơi
        /// </summary>

        public void EndGame()
        {
            this.Enabled = false;
        }

        #endregion

        public Player Player { get; set; }


        public string stringLocation { get; set; }

    }
    public class Location
    {
        public Location(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
