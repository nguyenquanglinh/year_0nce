using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeDoThiLienThong
{
    /// <summary>
    /// Mô tả 1 cạnh của đồ thị
    /// </summary>
    public class Canh
    {
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public HinhTron DiemDau { get; set; }
        public HinhTron DiemCuoi { get; set; }

        public Canh() { }

        public Canh(HinhTron lastedClick, HinhTron ht)
        {
            this.DiemDau = lastedClick;
            this.DiemCuoi = ht;
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
