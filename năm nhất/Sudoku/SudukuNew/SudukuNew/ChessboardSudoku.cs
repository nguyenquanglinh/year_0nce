using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudukuNew
{
    public partial class ChessboardSudoku : UserControl
    {
        int[,] arrGoc = new int[9, 9] { { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 } };

        TextBox[,] Arr;

        public int[,] arrDung { get; set; }
        private Dictionary<int, Color> colorDic = new Dictionary<int, Color>{
            {1, Color.Red},
            {2, Color.Beige},
            {3, Color.Bisque},
            {4, Color.BlueViolet},
            {5, Color.DarkGreen},
            {6, Color.AliceBlue},
            {7, Color.CadetBlue},
            {8, Color.DeepSkyBlue},
            {0, Color.Goldenrod} 
        };
        public ChessboardSudoku()
        {
            InitializeComponent();
            NewChessBoard();
        }


        public void NewChessBoard()
        {
            Arr = new TextBox[9, 9];
            panel1.Enabled = true;
            panel1.Controls.Clear();
            int ox = 0;
            int oy = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    Arr[i, j] = new TextBox()
                    {
                        Width = 50,
                        Height = 50,
                        Location = new Point(ox, oy),
                    };
                    Arr[i, j].Multiline = true;

                    Arr[i, j].BackColor = colorDic[arrGoc[i, j]];
                    ox += 50;
                    panel1.Controls.Add(Arr[i, j]);
                }

                oy += 50;
                ox = 0;
            }
        }

        public void GanArr(int[,] arrVao)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (arrVao[i, j] != 0)
                        Arr[i, j].Text = arrVao[i, j].ToString();
                    else Arr[i, j].Text = "";
                }
            }
        }

        public int[,] LayArr()
        {
            var arr = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Arr[i, j].Text != "")
                        arr[i, j] = int.Parse(Arr[i, j].Text);
                }
            }
            return arr;
        }

        public void KiemTraArrDung()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Arr[i, j].Text != "")
                        if (arrDung[i, j] != int.Parse(Arr[i, j].Text))
                            Arr[i, j].BackColor = Color.White;
                }
            }
            arrDung = null;
        }
    }
}
