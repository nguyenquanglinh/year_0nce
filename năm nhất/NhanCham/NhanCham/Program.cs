using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanCham
{
    public class Program
    {
        public static int[,] DienVongTrong(int[,] a, int[,] b)
        {
            var u = b.GetLength(0);
            var k = b.GetLength(1);
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            int[,] c = new int[m - 2, n - 2];
            for (int i = 0; i < m - 2; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    int z = 0;
                    var tong = 0;
                    for (int x = i; x < i + u; x++)
                    {
                        int t = 0;
                        for (int y = j; y < j + k; y++)
                        {
                            tong = tong + a[i, y] * b[z, t];
                            t++;
                        }
                        z++;
                    }
                    c[i, j] = tong;
                }
            }


            int p = 0, q;
            for (int i = 1; i < m - 1; i++)
            {
                q = 0;
                for (int j = 1; j < n - 1; j++)
                {
                    a[i, j] = c[p, q];
                    q++;
                }
                p++;
            }
            return a;
        }

        public static int[,] CachHaiNhanChap(int[,] a, int[,] b)
        {
             var ret = a.Clone() as int[,];
           var m = a.GetLength(0);
            var n = a.GetLength(1);
            for (int i = 1; i < m - 1; i++)
            {
                for (int j = 1; j < n - 1; j++)
                {
                    int t = 0;
                    for (int k = -1; k < 2; k++)
                    {
                        for (int q = -1; q < 2; q++)
                        {
                            t = t + b[1 + k, 1 + q] * a[i + k, j + q];
                        }
                    }
                    ret[i, j] = t;
                }
            }
            return ret;
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

        public static bool KiemTraSuCoMatCuaMotSoTrongMang(int[,] a, int b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (b == a[i, j])
                        return true;
                }
            }
            return false;
        }

        public static List<List<int>> DemSoDuongSoAmTrenMotHang(int[,] a)
        {
            var result = new List<List<int>>();
            var cacSoDuong = new List<int>();
            var cacSoAm = new List<int>();
            var m = a.GetLength(0);
            var n = a.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0)
                        cacSoDuong.Add(a[i, j]);
                    if (a[i, j] < 0)
                        cacSoAm.Add(a[i, j]);
                }
            }
            result.Add(cacSoDuong);
            result.Add(cacSoAm);

            return result;
        }


        static void Main(string[] args)
        {
            Console.Write("nhap so hang ngang cua mang lon ");
            int soHang = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot cua mang lon ");
            int soCot = int.Parse(Console.ReadLine());
            if (soHang < 3 || soCot < 3)
                Console.WriteLine("mang khong the mhan ");
            var a = new int[soHang, soCot];
            Nhap(a);
            Xuat(a);

            Console.Write("nhap so hang ngang cua mang nho ");
            int hangNgang = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot cua mang nho ");
            int cotNho = int.Parse(Console.ReadLine());
            var b = new int[hangNgang, cotNho];
            Nhap(b);
            Xuat(DienVongTrong(a, b));
            Console.ReadKey();
        }
    }
}
