using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
namespace XuLyAnhCanBan
{
    /// <summary>
    /// chọn khoảng xử lý trong đoạn ab thì giữ nguyên ngoài đoạn cho về 0
    /// </summary>
    class ThresholdAB : XuLy
    {
        public ThresholdAB(int a, int b)
            : base()
        {
            this.A = a;
            this.B = b;
        }



        private byte GetNewNumber(byte x)
        {
            if (x >= A && x <= B)
                return x;
            return 255;
        }

        public int A { get; set; }

        public int B { get; set; }

        override public void ConvertImage(byte[,] mangByte)
        {
            //đặt giá trị cho ảnh
            for (int i = 0; i < mangByte.GetLength(0); i++)
            {
                for (int j = 0; j < mangByte.GetLength(1); j++)
                {
                    mangByte[i, j] = GetNewNumber(mangByte[i, j]);
                }
            }

        }
    }
}
