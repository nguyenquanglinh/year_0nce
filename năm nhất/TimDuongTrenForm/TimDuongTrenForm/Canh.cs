using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TimDuongTrenForm
{
    public class Canh
    {
        public IDiem DiemDau { get; set; }
        public IDiem DiemCuoi { get; set; }
        public Canh(IDiem diemDau, IDiem diemCuoi)
        {
            DiemDau = diemDau;
            DiemCuoi = diemCuoi;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var canh = obj as Canh;
            if (canh == null)
                return false;
            if (this.DiemDau.Equals(canh.DiemDau) && this.DiemCuoi.Equals(canh.DiemCuoi) || (this.DiemDau.Equals(canh.DiemCuoi) && this.DiemCuoi.Equals(canh.DiemDau)))
                return true;
            return false;
        }
    }
}
