using System;
using System.Collections.Generic;
using System.Collections;

namespace SapXepTheoThuTuTangGiamCoViTriChoTruoc
{
    public class Program
    {
        public static int[,] SapXepTheoMotViTri(int[,] a, int x, int y)
        {
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            if (y + 1 < n)
                if (a[x, y] > a[x, y + 1])
                {
                    var b = a[x, y];
                    a[x, y] = a[x, y + 1];
                    a[x, y + 1] = b;
                    y++;
                }
            for (int i = x + 1; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (a[i, j] >= a[i, k])
                        {
                            var s = a[i, j];
                            a[i, j] = a[i, k];
                            a[i, k] = s;
                        }
                    }
                }
            }
            return a;
        }

        public static List<int> TinhTongCacDuongCheoTrenMang(int[,] a)
        {
            var b = new List<int>();
            int tongCheo1 = 0, tongCheo2 = 0;
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            if (m > n) m = n;
            if (n > m) n = m;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        tongCheo1 = tongCheo1 + a[i, j];
                }
                for (int j = n - 1; j >= 0; j--)
                {
                    if (n - j - 1 == i)
                        tongCheo2 = tongCheo2 + a[i, j];
                }
            }
            b.Add(tongCheo1);
            b.Add(tongCheo2);
            return b;
        }

        public static int[,] SapXepTheoThuTuGiamDan(int[,] a, int x, int y)
        {
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (x = i; x < m; x++)
                    {
                        for (y = j; y < n; y++)
                        {
                            if (x > i || y > j)
                                if (a[i, j] < a[x, y])
                                {
                                    var s = a[i, j];
                                    a[i, j] = a[x, y];
                                    a[x, y] = s;
                                }
                        }
                    }
                }
            }
            return a;
        }

        public static int[,] DienSoSao(int[,] a)
        {
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= j)
                        a[i, j] = -1;
                }
                Console.WriteLine();
            }
            return a;
        }

        public static List<int> TimMaxMin(int[,] a)
        {
            var b = new List<int>();

            var m = a.GetLength(0);
            var n = a.GetLength(1);
            if (m <= 0 || n <= 0)
                return b;
            int max = a[0, 0], min = a[0, 0];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                    if (a[i, j] < min)
                        min = a[i, j];
                }
            }
            b.Add(max);
            b.Add(min);
            return b;
        }

        public static List<int> TongSoChanSoLe(int[,] a)
        {
            var b = new List<int>();
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            if (m <= 0 || n <= 0)
                return b;
            int tongChan = 0, tongLe = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] % 2 == 0)
                        tongChan = tongChan + a[i, j];
                    tongLe = tongLe + a[i, j];
                }
            }
            b.Add(tongChan);
            b.Add(tongLe);
            return b;
        }

        static void Nhap(int[,] a)
        {
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("[{0},{1}] ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void Xuat(int[,] a)
        {
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("nhap so hang cua mang ");
            int soHang = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot cua mang ");
            int soCot = int.Parse(Console.ReadLine());
            int[,] a = new int[soHang, soCot];
            Nhap(a);
            Console.WriteLine();
            Xuat(a);
            Console.WriteLine();
            TimMaxMin(a);

            Console.Write("nhap vi tri hang ngang can sap xep ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("nhap vi tri cot can sap xep ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Xuat(DienSoSao(a));
            Xuat(SapXepTheoMotViTri(a, x, y));
            Console.WriteLine();
            Xuat(SapXepTheoThuTuGiamDan(a, x, y));
            Console.WriteLine();
            foreach (var item in TinhTongCacDuongCheoTrenMang(a))
            {
                Console.Write(item + "\t");
            }
            Console.ReadKey();
        }

    }
}
