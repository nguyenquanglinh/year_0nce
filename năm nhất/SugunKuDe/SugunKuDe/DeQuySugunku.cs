using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugunKuDe
{
    class DeQuySugunku
    {
        public int[,] Arr { get; set; }
        public DeQuySugunku(int[,] arr)
        {
            Arr = arr;
            Xuat(arr);
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

        void Xuat(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        public void GiaiSugunku()
        {
            Xuat(Arr);
            Console.WriteLine();
            var arr = Arr.Clone() as int[,];
            DienDinh(arr);
            Xuat(arr);
        }


        #region sai luật 3x3


        bool DienDung(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                        return false;
                }
            }
            return true;
        }
        //dúng luật dài
        int dem = 0;
        void DienDinh(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    dem++;
                    if (dem > int.MaxValue - 100)
                        return;

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

        #endregion

        List<Diem> LayCacDinhBang0()
        {
            var cacDiemBang0 = new List<Diem>();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(0); j++)
                {
                    if (Arr[i, j] == 0)
                        cacDiemBang0.Add(new Diem(i, j));
                }
            }
            return cacDiemBang0;
        }
    }
}

