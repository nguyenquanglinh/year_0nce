using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapXepMangThyeoThuTu
{
    public class Program
    {
        private static int[] ChuyenTuhaiChieuSangMotChieu(int[,] a)
        {

            int[] b = new int[a.GetLength(1) * a.GetLength(0)];
            int n = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[n] = a[i, j];
                    n++;
                }
            }
            return b;
        }

        private static int[] SapXepMangMotChieu(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {


                    if (a[i] > a[j])
                    {
                        var b = a[i];
                        a[i] = a[j];
                        a[j] = b;
                    }
                }
            }
            return a;
        }

        private static int[,] ChuyenTuMotChieuSanghaiChieu(int[] a)
        {
            var m = (int)Math.Sqrt(a.Length);
            var n = m; int f = 0;
            int[,] c = new int[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[f];
                    f++;
                }
            }
            return c;
        }

        public static int[,] SapXepTheoThuTuTangDanCuahang(int[,] a)
        {
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int x = j + 1; x < n; x++)
                    {
                        if (a[i, j] >= a[i, x])
                        {
                            var b = a[i, j];
                            a[i, j] = a[i, x];
                            a[i, x] = b;
                        }
                    }
                }
            }
            return a;
        }

        public static int[,] SapXepTheoHinhVuong(int[,] a)
        {
            return ChuyenTuMotChieuSanghaiChieu(SapXepMangMotChieu(ChuyenTuhaiChieuSangMotChieu(a)));
        }

        static void nhap(int[,] a)
        {
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("gia tri thu [{0},{1}] ", i, j);
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
            //Console.Write("nhap so hang  ngang ");
            //int sohang = int.Parse(Console.ReadLine());
            //Console.Write("nhP so hang doc ");
            //  int soCot = int.Parse(Console.ReadLine());
            int[,] a = new int[3, 3] { { 9, 8, 7, }, { 6, 5, 4 }, { 3, 2, 1 } };
            //   nhap(a);
            Console.WriteLine("----------------------");
            Xuat(a);
            Console.WriteLine("------------------------");
            //if (soCot == sohang)
            //{
            //    Xuat(SapXepTheoHinhVuong(a));
            //}
            //else
         //   Xuat(SapXepTheoThuTuTangDanCuahang(a, 2, 3));

            Console.ReadLine();
        }
    }
}
