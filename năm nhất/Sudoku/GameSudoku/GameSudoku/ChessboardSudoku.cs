using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSudoku
{
    public partial class ChessboardSudoku : UserControl
    {
        int[,] arrGoc = new int[9, 9] { { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 } };
        int[,] arr = new int[9, 9];
        TextBox[,] Arr = new TextBox[9, 9];
        public ChessboardSudoku()
        {
            InitializeComponent();
            NeWChessBoardSudoku();
        }
        void NeWChessBoardSudoku()
        {
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
                    if (i < 3)
                    {
                        if (j < 3)

                            Arr[i, j].BackColor = Color.Khaki;
                        else if (j > 5)
                            Arr[i, j].BackColor = Color.Yellow;
                        else
                            Arr[i, j].BackColor = Color.YellowGreen;
                    }
                    else if (i > 5)
                    {
                        if (j < 3)
                            Arr[i, j].BackColor = Color.Yellow;
                        else if (j > 5)
                            Arr[i, j].BackColor = Color.Khaki;
                        else
                            Arr[i, j].BackColor = Color.HotPink;
                    }
                    else
                    {
                        if (j < 3)
                            Arr[i, j].BackColor = Color.Lavender;
                        else if (j > 5)
                            Arr[i, j].BackColor = Color.Honeydew;
                        else
                            Arr[i, j].BackColor = Color.SpringGreen;

                    }
                    ox += 50;
                    panel.Controls.Add(Arr[i, j]);
                }

                oy += 50;
                ox = 0;
            }
        }

    }
}
