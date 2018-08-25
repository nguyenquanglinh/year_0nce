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
    /// in viền ảnh theo kernel 3x3
    /// </summary>
    public class ConvertImageToNegative : XuLy
    {


        public ConvertImageToNegative(int[,] mask)
            : base()
        {

            this.Mask = mask;
        }
        public int[,] Mask { get; set; }
        public override void ConvertImage(byte[,] mangByte)
        {
            byte[,] ret = mangByte.Clone() as byte[,];
            //đặt giá trị cho ảnh
            var height = mangByte.GetLength(0) - Mask.GetLength(0) + 1;
            var weight = mangByte.GetLength(1) - Mask.GetLength(0) + 1;
            var cao = Mask.GetLength(0) / 2;
            var rong = Mask.GetLength(0) / 2;
  
        
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    ret[i + cao, j + rong] = SetNewIntColor(GetListByte(i, j, mangByte));
                }
            }
            mangByte = ret;
        }

        private byte[,] GetListByte(int k, int q, byte[,] mangByte)
        {
            var ret = new byte[Mask.GetLength(0), Mask.GetLength(1)];
            for (int i = 0; i < Mask.GetLength(0); i++)
            {
                for (int j = 0; j < Mask.GetLength(1); j++)
                {
                    ret[i, j] = mangByte[i + k, j + q];
                }
            }
            return ret;
        }

        byte SetNewIntColor(byte[,] data)
        {
            int tong = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    tong += data[i, j] * Mask[i, j];
                }
            }
            if (tong < 0)
                return 0;
            else if (tong > 255)
                return 255;
            else return (byte)(tong);
        }



    }
}
