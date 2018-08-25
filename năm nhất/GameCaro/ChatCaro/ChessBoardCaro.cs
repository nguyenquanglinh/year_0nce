using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCaro
{

    public class ManagerPlayer
    {
        public ManagerPlayer(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
        }

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
    }

    public partial class ChessBoardCaro : UserControl
    {

        Button[,] arrChessBoard;

        ManagerPlayer ManagerPlayer;

        int playerNumber;

        int widthBoard;

        int heightBoard;

        Player playerCurrent;

        Player PlayerNew;

        int x;
        int y;


        public ChessBoardCaro()
        {
            InitializeComponent();

        }
        /// <summary>
        /// tạo bàn chơi mới
        /// </summary>
        /// <param name="heightBoard"></param>
        /// <param name="widthBoard"></param>
        /// <param name="mesterName"></param>
        /// <param name="guestName"></param>
        public void NewChessBoard(int heightBoard, int widthBoard, string mesterName, string guestName)
        {
            ManagerPlayer = new ManagerPlayer(new Player(mesterName, Image.FromFile("D:\\BaiTap1\\GameCaro\\ChatCaro\\Resources\\3.png")), new Player(guestName, Image.FromFile("D:\\BaiTap1\\GameCaro\\ChatCaro\\Resources\\1.png")));
            this.widthBoard = widthBoard / 20;
            this.heightBoard = heightBoard / 20;
            arrChessBoard = new Button[this.heightBoard, this.widthBoard];
            pnlChessBoard.Controls.Clear();
            pnlChessBoard.Enabled = true;
            pnlChessBoard.Controls.Clear();
            playerNumber = 1;
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
        List<Button> LayTheoHinhCheoPhụ(int x, int y)
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
        private void oTrong_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;
            PlayerNext(btn);
            PlayerNotifychanged();
            YouWin();
        }
        /// <summary>
        /// kiểm tra tất cả các trường hợp thắng
        /// </summary>
        private void YouWin()
        {
            if (WinCrossoverLeft(x, y) || WinCrossoverRight(x, y) || WinHorizantol(x, y) || WinVertical(x, y))
            {
                SomeoneWins();
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
            var dshangCheo = LayTheoHinhCheoPhụ(x, y);
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

        #region Thông tin người chơi hiện tại
        public string NamePlayerCurrent
        {
            get
            {
                return playerCurrent.NamePlayer;
            }
        }

        public Image PhotoPlayerCurrunt
        {
            get
            {
                return playerCurrent.PlayerPhoto;
            }
        }

        #endregion

        #region Thông tin người chơi tiếp theo
        public string NamePlayerNext
        {
            get
            {
                return PlayerNew.NamePlayer;
            }
        }

        public Image PhotoPlayerNext
        {
            get
            {
                return PlayerNew.PlayerPhoto;
            }
        }

        #endregion

       
        #region tất cả sự kiện
        //sự kiện kết thúc
        public event EventHandler ketThuc;
        //sự kiện lấy thông tin người chơi
        public event EventHandler ImformationPlayer;
        /// <summary>
        /// khi có sự kiện từ ngoài vào
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PlayerNotifyChangedChess(int x, int y)
        {
            var ss = arrChessBoard[x, y];
            oTrong_Click(ss, new EventArgs());
        }

        private void PlayerNotifychanged()
        {
            if (ImformationPlayer != null)
                ImformationPlayer(this, new EventArgs());
        }

        private void SomeoneWins()
        {
            if (ketThuc != null)
                ketThuc(this, new EventArgs());
        }

        #endregion

        /// <summary>
        /// thay đổi người chơi
        /// </summary>
        /// <param name="btn"></param>
        private void PlayerNext(Button btn)
        {
            if (playerNumber == 0)
            {
                playerCurrent = ManagerPlayer.Player1;
                PlayerNew = ManagerPlayer.Player2;
                btn.BackgroundImage = playerCurrent.PlayerPhoto;
                NotifyArr(btn);
               
            }
            else
            {
                playerCurrent = ManagerPlayer.Player2;
                btn.BackgroundImage = playerCurrent.PlayerPhoto;
                PlayerNew = ManagerPlayer.Player1;
                NotifyArr(btn);
            }
            playerNumber=playerNumber==1?0:1;

        }
        /// <summary>
        /// thêm thông tin tọa độ của btn
        /// </summary>
        /// <param name="btn"></param>
        private void NotifyArr(Button btn)
        {
            var ss = btn.Tag.ToString().Split(';');
            x = int.Parse(ss[0]);
            y = int.Parse(ss[1]);
        }
        /// <summary>
        /// kết thúc trò chơi
        /// </summary>
        public void EndGame()
        {
            pnlChessBoard.Enabled = false;
        }

    }
}
