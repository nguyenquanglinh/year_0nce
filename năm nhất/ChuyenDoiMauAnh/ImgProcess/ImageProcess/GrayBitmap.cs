using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgProcess.ImageProcess
{
    interface ThuatToan
    {
        void process(byte[,] data);
    }

    class ColorReversal : ThuatToan
    {
        public void process(byte[,] data)
        {
            for (var i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = (byte)(255 - data[i, j]);
                }
            }
        }
    }

    class Ma
    {
        public static void Main()
        {
            Bitmap bm = null;
            var gr = new GrayBitmap(bm);
            gr.ThuatToan.Add(new ColorReversal());
            //pibureb = gr.Process();
        }
    }

    class GrayBitmap
    {
        public List<ThuatToan> ThuatToan { get; set; }

        public GrayBitmap(Bitmap colorBitmap)
        {
            this.GrayData = Lockbits(colorBitmap);
            this.Bitmap = colorBitmap;
            ThuatToan = new List<ThuatToan>();
        }

        public Bitmap Process()
        {
            foreach (var item in ThuatToan)
            {
                item.process(GrayData);
            }
            Unlockbit();
            return Bitmap;
        }

        private byte[,] Lockbits(Bitmap colorBitmap)
        {
            // 
            return new byte[colorBitmap.Width, colorBitmap.Height];
        }

        private void Unlockbit()
        {

        }

        public byte[,] GrayData { get; set; }
        private Bitmap Bitmap { get; set; }
    }
}