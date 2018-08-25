using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuyetBfs
{
    class ThuatToanBfs
    {
        int[,] arr;
        public ThuatToanBfs(int[,] arr)
        {
            this.arr = arr;
        }
        Dictionary<int, int> xx;
        public void ThuatToan(int dinh, List<int> result)
        {
            var dinhDaDuyet = new int[arr.GetLength(0)];
            var dinhCha = new int[arr.GetLength(1)];
            var que = new Queue<int>();
            que.Enqueue(dinh);
            dinhDaDuyet[dinh] = -1;

            xx = new Dictionary<int, int>();
            while (que.Count != 0)
            {
                dinh = que.Dequeue();
                result.Add(dinh);
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[dinh, i] != 0 && dinhDaDuyet[i] == 0)
                    {
                        dinhDaDuyet[i] = 1;
                        xx.Add(i, dinh);
                        dinhCha[i] = dinh;
                        que.Enqueue(i);
                    }
                }
            }
        }

        public List<KeyValuePair<int, int>> TimDuong(int bd, int kt)
        {
            var ss = LayDuongDiTiepTheo(bd);
            return null;
        }
        KeyValuePair<int, int> LayDuongDiTiepTheo(int dinh)
        {
            foreach (var giaTri in xx)
            {
                if (giaTri.Value == dinh || giaTri.Key == dinh)
                    return giaTri;
            }
            return new KeyValuePair<int, int>();
        }
    }
}
