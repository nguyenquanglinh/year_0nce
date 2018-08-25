using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameSudoku
{
    public class Sudoku
    {
        Panel Panel;

        public Sudoku(Panel pannel)
        {
            Panel = pannel;

            Arr = new TextBox[9, 9];
        }
        TextBox[,] Arr;
        int[,] arr;

        public void NewSudoKu()
        {
            Panel.Enabled = true;
            Panel.Controls.Clear();
            arrKq = null;
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
                    Panel.Controls.Add(Arr[i, j]);
                }

                oy += 50;
                ox = 0;
            }
        }

        void LayGiaTriTrenArr()
        {
                arr = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Arr[i, j].Text == "")
                        arr[i, j] = 0;
                    else
                        arr[i, j] = int.Parse(Arr[i, j].Text);
                }
            } 
        }

        public void GiaiSudoku()
        {

            if (DienDung(arrKq))
            {
                LayGiaTriTrenArr();
                DienDinh(arr);
                if (DienDung(arr) == false)
                {
                    MessageBox.Show("máy tính chưa làm được kiểm tra lại");
                    return;
                }
                ArrDapAn(arr);
                
            }
            else 
                ArrDapAn(arrKq);
        }

        private void ArrDapAn(int[,] arrr)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (arrr[i, j] == 0)
                        continue;
                    Arr[i, j].Text = arrr[i, j].ToString();
                    
                }
            }
        }


        int[,] arrKq;

        void KetQua()
        {
            DienDinh(arrKq);
        }

        public void   DocFile(string pathFile)
        {
            var fileString = File.ReadAllText(pathFile);
            var s = fileString.ToString().ToCharArray();
            if (s.Length < 81)
            {
                MessageBox.Show("câu hỏi đã nhập sai");
                return;
            }
            arr = new int[9, 9];
            int k = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Char.IsNumber(s[k]) == false)
                    {
                        MessageBox.Show("câu hỏi đã bị nhập sai");
                        return;
                    }
                    arr[i, j] = int.Parse(s[k].ToString());
                    k++;
                }
            }
            arrKq = arr.Clone() as int[,];
            ArrDapAn(arr);
            KetQua();
        }

        #region Giai
        //lấy đỉnh để điền
        List<int> LayDinh(int i, int j, int[,] arr)
        {
            var dinhArr3x3 = LayDinhTren3x3(i, j, arr);
            var dinhTrenHang = (LayCacDinhTrenHang(i, arr));
            var dinhtrenCot = (LayCacDinhTrenCot(j, arr)); 
            var list = new List<int>();
            for (int dinh = 1; dinh < 10; dinh++)
            {
                if (!DinhDaCo(dinhTrenHang, dinh) && !DinhDaCo(dinhtrenCot, dinh) && !DinhDaCo(dinhArr3x3, dinh))
                    list.Add(dinh);
            }
            return list;
        }

        List<int> LayDinhTren3x3(int i, int j, int[,] arr)
        {
            var ret = new List<int>();
            if (i < 3)
            {
                if (j < 3)
                    for (int k = 0; k < 3; k++)
                    {
                        for (int q = 0; q < 3; q++)
                        {
                            if (arr[k, q] != 0)
                                ret.Add(arr[k, q]);
                        }
                    }
                else if (j > 5)
                    for (int k = 0; k < 3; k++)
                    {
                        for (int q = 6; q < 9; q++)
                        {
                            if (arr[k, q] != 0)
                                ret.Add(arr[k, q]);
                        }
                    }
                else
                    for (int k = 0; k < 3; k++)
                    {
                        for (int q = 3; q < 6; q++)
                        {
                            if (arr[k, q] != 0)
                                ret.Add(arr[i, j]);
                        }
                    }
            }
            else if (i > 5)
            {
                if (j < 3)
                    for (int k = 6; k < 9; k++)
                    {
                        for (int q = 0; q < 3; q++)
                        {
                            if (arr[k, q] != 0)
                                ret.Add(arr[k, q]);
                        }
                    }
                else if (j > 5)
                    for (int k = 6; k < 9; k++)
                    {
                        for (int q = 6; q < 9; q++)
                        {
                            if (arr[k, q] != 0)
                                ret.Add(arr[k, q]);
                        }
                    }
                else
                    for (int k = 6; k < 9; k++)
                    {
                        for (int q = 3; q < 6; q++)
                        {
                            if (arr[k, q] != 0)
                                ret.Add(arr[i, j]);
                        }
                    }
            }
            else
            {
                if (j < 3)
                    for (int k = 3; k < 6; k++)
                    {
                        for (int q = 0; q < 3; q++)
                        {
                            if (arr[k, q] != 0)
                                ret.Add(arr[k, q]);
                        }
                    }
                else if (j > 5)
                    for (int k = 3; k < 6; k++)
                    {
                        for (int q = 6; q < 9; q++)
                        {
                            if (arr[k, q] != 0)
                                ret.Add(arr[k, q]);
                        }
                    }
                else
                    for (int k = 3; k < 6; k++)
                    {
                        for (int q = 3; q < 6; q++)
                        {
                            if (arr[k, q] != 0)
                                ret.Add(arr[i, j]);
                        }
                    }
            }
            return ret;
        }

        List<int> LayCacDinhTrenHang(int hang, int[,] arr)
        {
            var cacDinhTrenHang = new List<int>();
            for (int i = 0; i < arr.GetLength(0); i++)
                if (arr[hang, i] != 0)
                    cacDinhTrenHang.Add(arr[hang, i]);
            return cacDinhTrenHang;
        }

        List<int> LayCacDinhTrenCot(int cot, int[,] arr)
        {
            var cacDinhTrenCot = new List<int>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var s = arr[i, cot];
                if (arr[i, cot] != 0)
                    cacDinhTrenCot.Add(arr[i, cot]);
            }
            return cacDinhTrenCot;
        }

        bool DinhDaCo(List<int> tapDinh, int dinh)
        { 
            foreach (var din in tapDinh)
            {
                if (din == dinh)
                    return true;
            }
            return false;
        }

        void DienDinh(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        var cacSoCoTheDien = LayDinh(i, j, arr);
                        if (cacSoCoTheDien.Count > 0)
                            foreach (var so in cacSoCoTheDien)
                            {
                                arr[i, j] = so;
                                DienDinh(arr);
                                if (DienDung(arr))
                                    return;
                                arr[i, j] = 0;
                            }

                        return;
                    }
                }
        }

        bool DienDung(int[,] arr)
        {
            if (arr == null)
                return false;

            for (int i = 0; i < 9; i++)
            {
                var dinhTrenHang = LayCacDinhTrenHang(i, arr);
                var dinhTrenCot = LayCacDinhTrenCot(i, arr);
                for (int dinh = 1; dinh < 10; dinh++)
                {
                    if (dinhTrenHang.Count < 9 || dinhTrenCot.Count < 9)
                        return false;

                    else if (DinhDaCo(dinhTrenHang, dinh) && DinhDaCo(dinhTrenCot, dinh))
                        continue;
                    return false;
                }
            }
            return true;
        }

        #endregion

        internal void KiemTraKetQua()
        { 
            LayGiaTriTrenArr();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (arr[i, j] != 0)
                        if (arr[i, j] != arrKq[i, j])
                            Arr[i, j].BackColor = Color.Red;
                        else
                            Arr[i, j].BackColor = Color.White;
                }
            }
        }
    }

}