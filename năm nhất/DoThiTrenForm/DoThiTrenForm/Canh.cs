using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThiTrenForm
{
    public class Canh : DoThiTrenForm.ICanh
    {
        public IDiem DiemDau { get; set; }

        public IDiem DiemCuoi { get; set; }

        public Canh(IDiem dDau, IDiem dCuoi)
        {
            DiemDau = dDau;
            DiemCuoi = dCuoi;
            this.Color = System.Drawing.Color.Blue;
        }

        public override string ToString()
        {
            return DiemDau.PointName + " " + DiemCuoi.PointName;
        }

        public override int GetHashCode()
        {
            return DiemDau.PointName.GetHashCode() ^ DiemDau.Center.GetHashCode() ^ DiemCuoi.PointName.GetHashCode() ^ DiemCuoi.Center.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == (obj as Canh).GetHashCode();
        }

        public int LayDiemBenCuaCanh(int x)
        {
            if (this.DiemCuoi.PointName == x.ToString())
                return int.Parse(this.DiemDau.PointName);
            else return int.Parse(this.DiemCuoi.PointName);
        }
        public bool CanhChung(int x)
        {
            if (this.DiemCuoi.PointName == x.ToString() || this.DiemDau.PointName == x.ToString())
                return true;
            return false;
        }


        public System.Drawing.Color Color { get; set; }
    }
}
