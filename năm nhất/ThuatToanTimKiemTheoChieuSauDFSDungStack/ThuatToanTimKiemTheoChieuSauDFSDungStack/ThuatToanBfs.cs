using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToanTimKiemTheoChieuSauDFSDungStack
{
    class ThuatToanBfs
    {
        int[,] arr;
        public ThuatToanBfs(int doDaiCanh)
        {
            arr = new int[doDaiCanh, doDaiCanh];
            Nhap();
        }
        private void Nhap()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("nhap gia tri thu [{0} {1}] ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
        public ThuatToanBfs(int[,] a)
        {
            arr = a;
        }
        public int[,] ARR
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
                if (value == null || value.GetLength(0) != value.GetLength(1))
                    throw new Exception("bạn đã truyền sai mang cần sét");

            }
        }

    }
}
