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
    /// chọn 1 ngưỡng ảnh T nếu >=t=255;không t=0;
    /// </summary>
    class HandleThreshold : XuLy
    {

        public HandleThreshold( int t)
            : base()
        {
            this.T = t;
        }


        override public void ConvertImage(byte[,] mangByte)
        {
            for (int i = 0; i < mangByte.GetLength(0); i++)
            {
                for (int j = 0; j < mangByte.GetLength(1); j++)
                {
                    mangByte[i, j] = NumberNew(mangByte[i, j]);
                }
            }
        }

        private byte NumberNew(byte x)
        {
            if (x > T)
                return 255;
            return 0;
        }

        public int T { get; set; }
    }
}
