using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyAnhCanBan
{
    public class LockBitImage
    {

        public byte[,] Arr { get; set; }

        public Bitmap Bitmap { get; set; }

        private IntPtr Ptr { get; set; }

        private BitmapData bmpData { get; set; }

        public LockBitImage(Bitmap bitmap)
        {
            this.Bitmap = bitmap;
            LockBit();
        }

        public void UnLockBit()
        {
            this.Bitmap.UnlockBits(bmpData);
        }

        public void LockBit()
        {
            this.bmpData = Bitmap.LockBits(new Rectangle(0, 0, Bitmap.Width, Bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            // lấy địa chỉ dòng đầu tiên của ảnh
            this.Ptr = bmpData.Scan0;
        }

        public byte[,] GetByteBit()
        {
            int stride = bmpData.Stride;
            var ret = new byte[Bitmap.Height, Bitmap.Width];
            unsafe
            {
                byte* p = (byte*)(void*)bmpData.Scan0;
                int noffset = stride - bmpData.Width * 3;
                for (int i = 0; i < ret.GetLength(0); i++)
                {
                    for (int j = 0; j < ret.GetLength(1); j++)
                    {
                        ret[i, j] = (byte)((p[0] * 0.2989 + p[1] * 0.5870 + p[2] * 0.1140));
                        p += 3;
                    }
                    p += noffset;
                }
            }
            return ret;
        }

        public void SetByteToBitMap(byte[,] arr)
        {
            var stride = bmpData.Stride;

            var ar = new byte[stride * arr.GetLength(0)];
            int dem = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    ar[dem] = arr[i, j];
                    ar[dem + 1] = arr[i, j];
                    ar[dem + 2] = arr[i, j];
                    dem += 3;
                }
                dem += stride - arr.GetLength(1) * 3;
            }
 `                 if (dem != ar.Length)
                throw new Exception("");
            System.Runtime.InteropServices.Marshal.Copy(ar, 0, Ptr, dem);
            // Unlock the bits.
            Bitmap.UnlockBits(bmpData);
        }


    }
}
