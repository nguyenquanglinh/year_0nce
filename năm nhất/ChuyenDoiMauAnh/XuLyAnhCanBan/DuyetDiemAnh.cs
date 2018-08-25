using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyAnhCanBan
{
    public class DuyetDiemAnhChu
    {

        byte[,] arrr;
        List<Stt> listHang;
        byte[] arphai;
        Bitmap bitmap;
        public DuyetDiemAnhChu(byte[,] arr, Bitmap bitmap)
        {
            this.bitmap = bitmap;
            var phanNguong = new HandleThreshold(128);
            phanNguong.ConvertImage(arr);
            this.Arr = arr.Clone() as byte[,];
            arrr = arr;

            ChieuAnhSangTayPhai();
            TimToaDoHinhChieu();

        }

        private void TimToaDoHinhChieu()
        {
            bool ViTriDau = true;
            int x1 = 0;
            int x2 = 0;
            listHang = new List<Stt>();
            for (int i = 0; i < arphai.GetLength(0) - 1; i++)
            {
                if (arphai[i] == 0 && ViTriDau)
                {
                    x1 = i;
                    ViTriDau = false;
                }
                if (arphai[i + 1] == 255 && ViTriDau == false)
                {
                    x2 = i;
                    listHang.Add(new Stt(x1, x2));
                    ViTriDau = true;
                    x1 = 0;
                    x2 = 0;
                }
            }

        }

        private void ChieuAnhSangTayPhai()
        {
            arphai = new byte[arrr.GetLength(0)];
            for (int i = 0; i < arrr.GetLength(0); i++)
            {
                byte min = 255;
                for (int j = 0; j < arrr.GetLength(1); j++)
                {
                    if (arrr[i, j] < min)
                        min = arrr[i, j];
                }
                arphai[i] = min;
            }

        }

        private void ChieuAnhXuongDuoiDat()
        {

        }

        public byte[,] Arr { get; private set; }

        public List<Bitmap> DuyetDiemChu()
        {
            var ret = new List<Bitmap>();

            foreach (var item in listHang)
            {
                for (int j = 0; j < arrr.GetLength(1); j++)
                {
                    for (int i = item.DiemDau; i <= item.DiemCuoi; i++)
                    {

                        if (arrr[i, j] == 0)
                        {
                            var list = new List<Point>();
                            TimDuong(i, j, list);
                            ret.Add(GetBitMap(list));
                        }
                    }
                }
            }
            return ret;
        }

        private List<Stt> LayChieuRongChieuCaoCuaAnh(List<Point> item)
        {
            int Xmax = item[0].X;
            int Ymax = item[0].Y;
            foreach (var rong in item)
            {
                if (rong.X > Xmax)
                    Xmax = rong.X;
                if (rong.Y > Ymax)
                    Ymax = rong.Y;
            }
            int Xmin = Xmax;
            int Ymin = Ymax;
            foreach (var dai in item)
            {
                if (dai.X < Xmin)
                    Xmin = dai.X;
                if (dai.Y < Ymin)
                    Ymin = dai.Y;
            }
            return new List<Stt>() { new Stt(Xmin, Xmax), new Stt(Ymin, Ymax) };
        }

        private Bitmap GetBitMap(List<Point> item)
        {
            var list = LayChieuRongChieuCaoCuaAnh(item);
            Rectangle cloneRect = new Rectangle(list[1].DiemDau, list[0].DiemDau, list[1].DoDai, list[0].DoDai);
            Bitmap cloneBitmap = bitmap.Clone(cloneRect, bitmap.PixelFormat);
            return cloneBitmap;

        }
        public void TimDuong(int i, int j, List<Point> list)
        {

            if (arrr[i, j] != 0)
                return;
            list.Add(new Point(i, j));
            arrr[i, j] = 255; // xóa điểm hiển tại để ko duyệt lại điểm đã duyệt
            if (j + 1 < arrr.GetLength(1)) // Điểm bên phải điểm đang xét = 1
                TimDuong(i, j + 1, list);
            if (j - 1 >= 0) // điêm bên trái =1
                TimDuong(i, j - 1, list);
            if (i + 1 < arrr.GetLength(0)) // điêm bên dưới =1
                TimDuong(i + 1, j, list);
            if (i - 1 >= 0) // điêm bên trên =1
                TimDuong(i - 1, j, list);
            if (i - 1 >= 0 && j - 1 >= 0)//chéo trên bên phải
                TimDuong(i - 1, j - 1, list);
            if (i + 1 < arrr.GetLength(0) && j + 1 < arrr.GetLength(1))//chéo dưới bên phải
                TimDuong(i + 1, j + 1, list);
            if (j + 1 < arrr.GetLength(1) && i - 1 >= 0)//chéo trên bên trái
                TimDuong(i - 1, j + 1, list);
            if (j - 1 >= 0 && i + 1 < arrr.GetLength(0))//chéo dưới bên trái
                TimDuong(i + 1, j - 1, list);
        }
    }
}
