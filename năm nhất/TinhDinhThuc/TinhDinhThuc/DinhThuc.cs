using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDinhThuc
{
    class DinhThuc
    {
        public DinhThuc(int[,] a) { }

        int[,] arr;
        //gia ban dau
        int[,] MangNhapVao
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
            }
        }
        //vi tri đầu =0
        bool KTviTriDauBang0(int[,] a)
        {
            if (a[0, 0] == 0)
                return true;
            return false;
        }
        //lay các giá trị cột 0 khac khong them vao vi tri đâu tiên
        void LayviTriDauKhac0(int[,] a)
        {
            int[] ar = new int[a.GetLength(1)];
             
        }
        int[] LayGiatriHangDaubang0(int[,] a)
        {
            var ar = new int[a.GetLength(1)];
            for (int i = 0; i < a.GetLength(1); i++)
            {
                ar[i] = a[0, i];
            }
            return ar;
        }
    }
}
