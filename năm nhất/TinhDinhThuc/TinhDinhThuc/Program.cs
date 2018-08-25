using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDinhThuc
{
    class Program
    {
        static double[] LayCacGiaTriHangThuN(double[,] arr, int n)
        {
            var ar = new double[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                ar[i] = arr[n, i];
            }
            return ar;
        }

        static int KtViTriHangKhac0Min(double[,] ar)
        {
            var min = ar[1, 0];
            int x = 0;
            for (int i = 2; i < ar.GetLength(0); i++)
            {
                if (ar[i, 0] < min && ar[i, 0] != 0)
                    x = i;
            }
            return x;
        }

        static void DoiViTri2HangBang0TrongMatrix(double[,] arr, int viTri)
        {
            var min = KtViTriHangKhac0Min(arr);
            var aN = LayCacGiaTriHangThuN(arr, min);
            var a0 = LayCacGiaTriHangThuN(arr, 0);
            var a1 = LayCacGiaTriHangThuN(arr, viTri);
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[0, 0] == 0)

                    if (viTri == 0)
                    {
                        arr[0, i] = aN[i];
                        arr[min, i] = a0[i];
                    }

                arr[viTri, i] = aN[i];
                arr[viTri, i] = a1[i];
            }
        }

        static bool KtHangBang0(double[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] != 0)
                    return false;
            }
            return true;
        }

        static void TinhGiaTriTamGiacDuocbang0(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                var arTren = LayCacGiaTriHangThuN(arr, i);
                for (int j = i + 1; j < arr.GetLength(0); j++)
                {
                    var arDuoi = LayCacGiaTriHangThuN(arr, j);
                    double thuong = arDuoi[i] * 1.0 / arTren[i];
                    for (int k = i; k < arr.GetLength(1); k++)
                    {
                        arr[j, k] = (arDuoi[k] - arTren[k] * thuong);
                    }
                    Xuat(arr);
                }

            }
        }

        static void KtCacHangKhac0(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var ar = LayCacGiaTriHangThuN(arr, i);
                if (KtHangBang0(ar))
                {
                    DoiViTri2HangBang0TrongMatrix(arr, i);
                }
            }
        }

        static void Nhap(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("nhap gia tri [{0} {1}] ", i, j);
                    int x = int.Parse(Console.ReadLine());
                    arr[i, j] = x;
                }
            }
        }

        static void Xuat(double[,] arr)
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

        static void Main(string[] args)
        {

            //Console.Write("nhâp so cot cua ma tran ");
            //int cot = int.Parse(Console.ReadLine());
            //Console.Write("nhap so hang cua ma trân ");
            //int hang = int.Parse(Console.ReadLine());
            //var arr = new double[hang, cot];
            ////Nhap(arr);
            // Xuat(arr);
            // var arr1 = new double[6, 6] { { 4, 4, -1, 0, -1, 8 }, { 2, 3, 7, 5, 2, 3 }, { 3, 2, 5, 7, 3, 2 }, { 1, 2, 2, 1, 1, 2, }, { 1, 7, 6, 6, 5, 7 }, { 2, 1, 1, 2, 2, 1 } };
            //       var arr1 = new double[4, 4] { { 3, 2, 3, 6 }, { 2, 3, 6, 3 }, { 3, 6, 3, 2 }, { 6, 3, 2, 3 } };
           // var arr1 = new double[4, 4] { { 1001, 1002, 1003, 1004 }, { 1002, 1003, 1001, 1002 }, { 1001, 1000, 1001, 999 }, { 1001, 1000, 998, 999 } };
            var arr1 = new double[2, 2] { { 1, 2 }, { 3, 4 } };
            TinhGiaTriTamGiacDuocbang0(arr1);
            KtCacHangKhac0(arr1);
            Xuat(arr1);
            double x = 1, dem = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        x = x * arr1[i, j] * 1.0;
                        break;

                    }
                    dem++;
                }
            }
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
