using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaTrix
{
    public class MaTrix1
    {
        int soHang, soCot;
        int[,] arr;
        double[,] arrr;
        public int[,] Data { get { return arr; } }

        public double[,] DataThuc { get { return arrr; } }

      
        public int Get(int hang, int cot)
        {
            return arr[hang, cot];
        }

        public int Hang
        {
            get
            {
                return soHang;
            }
            set
            {
                soHang = value;
            }
        }

        public int Cot
        {
            get
            {
                return soCot;
            }
            set
            {
                soCot = value;
            }

        }

        public MaTrix1(int[,] arr1)
        {
            arr = arr1;
            soHang = arr1.GetLength(0);
            soCot = arr1.GetLength(1);
        }

        public MaTrix1(double[,] arr1)
        {
            arrr = arr1;
            soHang = arr1.GetLength(0);
            soCot = arr1.GetLength(1);
        }

        public MaTrix1()
        {
            arr = new int[0, 0];
        }

        public MaTrix1(int hang, int cot)
        {
            Hang = hang;
            Cot = cot;
            arr = new int[Hang, Cot];
        }

        public void Nhap()
        {
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write("nhap gia tri [{0},{1}] ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Xuat()
        {
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public MaTrix1 Add(MaTrix1 other)
        {

            if (!this.KiemTra(other))
                throw new Exception("Loi khong cong dc");

            int[,] result = new int[Hang, Cot];

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    result[i, j] = this.Get(i, j) + other.Get(i, j);
                }
            }
            return new MaTrix1(result);
        }
        public MaTrix1 Tru(MaTrix1 other)
        {
            int[,] a = new int[Hang, Cot];
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    a[i, j] = this.Get(i, j) - other.Get(i, j);
                }
            }
            return new MaTrix1(a);
        }
        public MaTrix1 Nhan(MaTrix1 other)
        {
            int[,] a = new int[Hang, Cot];
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    a[i, j] = this.Get(i, j) * other.Get(i, j);
                }
            }
            return new MaTrix1(a);
        }
        public MaTrix1 Chia(MaTrix1 other)
        {
            int[,] a = new int[Hang, Cot];
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    a[i, j] = this.Get(i, j) / other.Get(i, j);
                }
            }
            return new MaTrix1(a);
        }
        public bool KiemTra(MaTrix1 other)
        {
            if (this.Hang != other.Hang || this.Cot != other.Cot)
            {
                return false;
            }
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so hang cua ma tran 1 ");
            int soHangMT1 = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot cua  ma tra 1 ");
            int soCotMT1 = int.Parse(Console.ReadLine());
            var a = new MaTrix1(soHangMT1, soCotMT1);
            a.Nhap();
            Console.Write("nhap so hang cua ma tran 2 ");
            int soHangMT2 = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot cua  ma tra 1 ");
            int soCotMt2 = int.Parse(Console.ReadLine());
            var b = new MaTrix1(soHangMT2, soCotMt2);
            b.Nhap();
            if (soCotMT1 != soCotMt2 || soHangMT1 != soHangMT2)
                throw new Exception("loi");

            var x = a.Add(b);
            var y = a.Tru(b);
            x.Xuat();

            Console.ReadKey();
        }
    }
}
