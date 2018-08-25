using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudukuNew
{
    class GiaiSudoku
    {
        int[,] arrGoc = new int[9, 9] { { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 } };
        int[,] arr { get; set; }
        int[,] arrKetQua;

        public GiaiSudoku(int[,] arrVao)
        {
            arr = arrVao;
            arrKetQua = new int[9, 9];
        }

        void DienDinhVaoArr()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        var cacSoCoTheDien = LayDinh(i, j).ToArray();
                        if (cacSoCoTheDien.Length > 0)
                            foreach (var so in cacSoCoTheDien)
                            {
                                arr[i, j] = so;
                                DienDinhVaoArr();
                                if (DaDienDung())
                                    return;
                                arr[i, j] = 0;
                            }

                        return;
                    }
                }
        }

        public int[,] LayKetQua()
        {
            DienDinhVaoArr();
            return arr;
        }

        List<int> LayCacSotrenArr3x3(int hang, int cot)
        {
            var CacSoTrenArr3x3 = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (arrGoc[i, j] == arrGoc[hang, cot] && arr[i, j] != 0)
                        CacSoTrenArr3x3.Add(arr[i, j]);
                }
            }
            return CacSoTrenArr3x3;
        }

        //public static int count = 0;
        //static List<int> list = new List<int>();
        //static List<int> list10So = Enumerable.Range(1, 9).ToList();
        private List<int> LayDinh(int hang, int cot)
        {
            //list.Clear();
            //count++;

            //var cacSoTrenArr3x3 = LayCacSotrenArr3x3(hang, cot);
            //for (int i = 0; i < 9; i++)
            //{
            //    if (arr[hang, i] != 0)
            //        list.Add(arr[hang, i]);
            //    if (arr[i, cot] != 0)
            //        list.Add(arr[i, cot]);
            //}




            //list.AddRange(cacSoTrenArr3x3);
            //return list10So.Except(list).ToList();


            var cacDinhTrenHang = LayCacDinhTrenHang(hang);
            var cacDinhTrenCot = LayCacDinhTrenCot(cot);
            var cacSoTrenArr3x3 = LayCacSotrenArr3x3(hang, cot);


            var ret = new List<int>();
            for (int dinh = 1; dinh < 10; dinh++)
            {
                if (!cacDinhTrenHang.Contains(dinh) && !cacDinhTrenCot.Contains(dinh) && !cacSoTrenArr3x3.Contains(dinh))
                    ret.Add(dinh);

            }
            return ret;

        }

        List<int> LayCacDinhTrenHang(int hang)
        {
            var cacDinhTrenHang = new List<int>();
            for (int i = 0; i < 9; i++)
                if (arr[hang, i] != 0)
                    cacDinhTrenHang.Add(arr[hang, i]);
            return cacDinhTrenHang;
        }

        List<int> LayCacDinhTrenCot(int cot)
        {
            var cacDinhTrenHang = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                var s = arr[i, cot];
                if (arr[i, cot] != 0)
                    cacDinhTrenHang.Add(arr[i, cot]);
            }
            return cacDinhTrenHang;
        }

        bool DaDienDung()
        {
            for (int i = 0; i < 9; i++)
            {
                var dinhTrenHang = LayCacDinhTrenHang(i);
                var dinhTrenCot = LayCacDinhTrenCot(i);
                for (int dinh = 1; dinh < 10; dinh++)
                {
                    if (dinhTrenHang.Count < 9 || dinhTrenCot.Count < 9)
                        return false;
                    else if (dinhTrenHang.Contains(dinh) && dinhTrenCot.Contains(dinh))
                        continue;
                    return false;
                }
            }
            return true;
        }

    }
}
