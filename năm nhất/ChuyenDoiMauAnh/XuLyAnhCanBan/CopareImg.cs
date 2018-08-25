using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace XuLyAnhCanBan
{
    internal class CopareImg
    {
        private byte[,] arrMau;
         public CopareImg(byte[,] arr)
        {
            this.arrMau = arr;
        }
        public bool Compare(byte[,] arrVao)
        {
            //neu mang vao nho hon mang mau 
            if (arrVao.GetLength(0) < this.arrMau.GetLength(0) && arrVao.GetLength(1) <= this.arrMau.GetLength(1))
                return CompareImg(arrMau, arrVao);
            else
                return CompareImg(arrVao, arrMau);
        }
        //ảnh có chiều dài rộng lớn hơn 
        private bool CompareImg(byte[,] lon, byte[,] nho)
        {
            int tiLeX = lon.GetLength(0) / nho.GetLength(0);
            int tiLeY = lon.GetLength(1) / nho.GetLength(1);
            if (tiLeX == 0 && tiLeY != 0 || tiLeY == 0 && tiLeX != 0)
            {
                var xx = TimToaDoDuyet(lon, nho);
                return CompareImg(lon, nho, TimToaDoDuyet(lon, nho));
            }

            return CompareImg(lon, nho, tiLeX, tiLeY);
        }

        private bool CompareImg(byte[,] lon, byte[,] nho, Point stt)
        {
            int dem = 0;
            for (int i = 0; i < stt.X; i++)
            {
                for (int j = 0; j < stt.Y; j++)
                {
                    if (lon[i, j] == nho[i, j])
                        dem++;
                }
            }
            if (dem == stt.X * stt.Y)
                return true;
            return false;
        }


        private Point TimToaDoDuyet(byte[,] lon, byte[,] nho)
        {
            int x = 0;
            int y = 0;
            //x=0; y!=0;=>lấy x của nhỏ y của lớn
            if (nho.GetLength(0) < lon.GetLength(0))
                x = nho.GetLength(0);
            else
                x = lon.GetLength(0);
            if (nho.GetLength(1) < lon.GetLength(1))
                y = nho.GetLength(1);
            else
                y = lon.GetLength(1);
            return new Point(x, y);

        }


        //ảnh có chiều dài hoặc chiều rộng lớn hơn
        private bool CompareImg(byte[,] lon, byte[,] nho, int tiLeX, int tiLeY)
        {
            int dem = 0;
            for (int i = 0; i < nho.GetLength(0); i++)
            {
                for (int j = 0; j < nho.GetLength(1); j++)
                {
                    if (lon[i * tiLeX, j * tiLeY] == nho[i, j])
                        dem++;
                }
            }
            if (dem >= nho.GetLength(0) * nho.GetLength(1) )
                return true;
            return false;
        }
    }
}