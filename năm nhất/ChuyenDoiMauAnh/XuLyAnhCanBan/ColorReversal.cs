using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyAnhCanBan
{
    /// <summary>
    /// đảo màu ảnh theo x=255-x0;
    /// </summary>
    class ColorReversal : XuLy
    {

        public ColorReversal()
            : base()
        {

        }

        override public void ConvertImage(byte[,] mangByte)
        {

            for (int i = 0; i < mangByte.GetLength(0); i++)
            {
                for (int j = 0; j < mangByte.GetLength(1); j++)
                {
                    mangByte[i, j] = (byte)(255 - mangByte[i, j]);
                }
            }
        }

    }
}
