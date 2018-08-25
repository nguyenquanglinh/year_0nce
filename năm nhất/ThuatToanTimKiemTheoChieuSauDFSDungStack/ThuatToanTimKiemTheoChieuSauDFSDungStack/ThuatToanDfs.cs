using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThuatToanTimKiemTheoChieuSauDFSDungStack
{
    class ThuatToanDfs
    {
        int[,] arr;
        public ThuatToanDfs(int[,] a)
        {
            dinhDaDuyet = new int[20];
            Dinh = new List<int>();
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

        public ThuatToanDfs(int doDaiCanh)
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

        private bool DinhDaDuocDuyet(List<int> a, int dinh)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == dinh)
                    return true;
            }
            return false;
        }
        public int[] dinhDaDuyet { get; set; }
        public List<int> Dinh { get; set; }
        public void DinhDangDuyet(int dinh)
        {
            Dinh.Add(dinh);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[dinh, i] == 1 && dinhDaDuyet[i] == 0)
                {
                    dinhDaDuyet[dinh] = 22;
                    DinhDangDuyet(i);
                }
            }
        }
        public List<int> ThuTuDuyetDinh(int dinh)
        {
            //var stack = new Stack<int>();
            var list = new List<int>();

            //stack.Push(dinh);
            //while (stack.Count != 0)
            {
                //var dinhRa = stack.Pop();
                //list.Add(dinhRa);
                var dinhRa = dinh;
                list.Add(dinh);
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[dinhRa, i] == 1 && dinhDaDuyet[i] == 0)
                    {
                        dinhDaDuyet[i] = 22;
                        var s = ThuTuDuyetDinh(i);
                    }
                }
            }
            if (list.Count > 1)
                return list;
            return null;
        }

        public List<List<int>> DanhSachDoThi()
        {
            var list = new List<List<int>>();
            var cacDinhDuyet = ThuTuDuyetDinh(1);
            list.Add(cacDinhDuyet);

            for (int i = 1; i < arr.GetLength(0); i++)
            {
                if (!DinhDaDuocDuyet(cacDinhDuyet, i))
                {
                    cacDinhDuyet = ThuTuDuyetDinh(i);
                    if (cacDinhDuyet != null)
                        list.Add(cacDinhDuyet);
                }
            }
            return list;
        }

        public int DemCanhDoThi(int dinh)
        {
            var list = ThuTuDuyetDinh(dinh);
            if (list == null)
                return 0;
            return list.Count - 1;
        }


        internal void  clear()
        {
            dinhDaDuyet = new int[20];
            Dinh = new List<int>();
        }
    }
}
