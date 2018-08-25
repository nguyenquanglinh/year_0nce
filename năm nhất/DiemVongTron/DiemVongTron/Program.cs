using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemVongTron
{
    public class Program
    {
        public static int[,] Nhap(int m, int n)
        {
            var a = new int[m, n];
            int soHang = 0, soCot = 0, giaTriCanDien = 1, viTriTamThoi = 0;
            while (true)
            {
                if (soHang == soCot)
                    for (int j = soCot; j < n - 1 - viTriTamThoi; j++)
                    {
                        a[soHang, j] = giaTriCanDien;
                        soCot++;
                        giaTriCanDien++;
                        Xuat(a);
                    }
                if (soCot == n - 1 - viTriTamThoi)
                {
                    for (int i = viTriTamThoi; i < m - viTriTamThoi - 1; i++)
                    {
                        a[i, soCot] = giaTriCanDien;
                        soHang++;
                        giaTriCanDien++;
                        Xuat(a);
                    }
                }
                if (soHang == m - 1 - viTriTamThoi)
                {
                    for (int j = soCot; j > viTriTamThoi; j--)
                    {
                        a[soHang, j] = giaTriCanDien;
                        soCot--;
                        giaTriCanDien++;
                    }
                }
                if (soCot == viTriTamThoi)
                {
                    for (int i = soHang; i > viTriTamThoi; i--)
                    {
                        a[i, soCot] = giaTriCanDien;
                        soHang--;
                        giaTriCanDien++;
                    }
                }

                if (soHang == m / 2 && soCot == n / 2)
                {
                    a[soHang, soCot] = giaTriCanDien;
                    giaTriCanDien++;
                }
                soCot++;
                soHang++;
                viTriTamThoi++;
                if (giaTriCanDien > m * n)
                    break;
            }
            return a;
        }


        public static int[,] DienSoTang(int m, int n)
        {
            var a = new int[m, n];

            if (n > m) m = n;
            if (m > n) n = m;
            for (int x = 0; x < n / 2; x++)
            {
                for (int i = x; i < m - x; i++)
                {
                    for (int j = x; j < n - x; j++)
                    {
                        if ((i == x || j == x || i == m - 1 - x || j == m - 1 - x))
                            a[i, j] = x + 1;
                    }
                }
            }
            return a;
        }

        public static int[,] Doichieu(int[,] a)
        {
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            var ketQua = new int[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ketQua[j, i] = a[i, j];
                }
            }
            return ketQua;
        }

        public static int[,] DienSo(int m)
        {
            var a = new int[m, m];
            int soHang = 0, soCot = 0, giaTriCanDien = 1, giaTriTamThoi = 0, dem = 0;
            while (true)
            {
                if (soHang == soCot)
                    for (int j = soCot; j < m - 1 - giaTriTamThoi; j++)
                    {
                        a[soHang, j] = giaTriCanDien;
                        soCot++;
                        dem++;
                    }
                if (soCot == m - 1 - giaTriTamThoi)
                {
                    for (int i = soHang; i < soCot; i++)
                    {
                        a[i, soCot] = giaTriCanDien;
                        soHang++;
                        dem++;
                    }
                }
                if (soHang == m - 1 - giaTriTamThoi)
                {
                    for (int j = soCot; j > giaTriTamThoi; j--)
                    {
                        a[soHang, j] = giaTriCanDien;
                        dem++;
                        soCot--;
                    }
                }
                if (soCot == giaTriTamThoi)
                {
                    for (int i = soHang; i > giaTriTamThoi; i--)
                    {
                        a[i, soCot] = giaTriCanDien;
                        soHang--;
                        dem++;
                    }
                }
                if (soHang == m / 2)
                {
                    a[soHang, soCot] = giaTriCanDien;
                    dem++;
                }
                soCot++;
                soHang++;
                giaTriTamThoi++;
                giaTriCanDien++;
                if (dem >= m * m)
                    break;
            }
            return a;
        }

        public static int[,] DienSoC1(int m, int n)
        {
            var a = new int[m, n];
            int soHang = 0, soCot = 0, giaTriCanDien = 1, viTriTamThoi = 0, dem = 0;
            while (true)
            {
                if (soHang == soCot)
                    for (int j = soCot; j < n - 1 - viTriTamThoi; j++)
                    {
                        a[soHang, j] = giaTriCanDien;
                        soCot++;
                        dem++;
                    }
                if (soCot == n - 1 - viTriTamThoi)
                {
                    for (int i = viTriTamThoi; i < m - viTriTamThoi - 1; i++)
                    {
                        a[i, soCot] = giaTriCanDien;
                        soHang++;
                        dem++;
                        Xuat(a);
                    }
                }
                if (soHang == m - 1 - viTriTamThoi)
                {
                    for (int j = soCot; j > viTriTamThoi; j--)
                    {
                        a[soHang, j] = giaTriCanDien;
                        soCot--;
                        dem++;
                    }
                }
                if (soCot == viTriTamThoi)
                {
                    for (int i = soHang; i > viTriTamThoi; i--)
                    {
                        a[i, soCot] = giaTriCanDien;
                        soHang--;
                        dem++;
                    }
                }

                if (soHang == m /2&&soCot==n/2)
                {
                    a[soHang, soCot] = giaTriCanDien;
                    dem++;
                }
                soCot++;
                soHang++;
                viTriTamThoi++;
                if (dem > m * n)
                    break;
            }
            return a;
        }

        static void Xuat(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
