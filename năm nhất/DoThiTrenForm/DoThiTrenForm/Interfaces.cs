using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThiTrenForm
{
    public interface IGraphDrawler
    {
        void Draw(IDoThi canh);
        void UpdateEdge(IDoThi canh);
    }
    public interface IThuatToan
    {
        List<IDiem> ThuTuDuyet(int viTriDuyet);
        Hinh TimDuongMin(int bd, int kt);
    }

    public interface IDoThi
    {
        event EventHandler OnGraphChanged;
        IEnumerable<ICanh> TapCanh { get; }
        IEnumerable<IDiem> TapDinh { get; }
        IDiem this[string name] { get; }
        int SoDinhCuaDoThi { get; }
        void ThemCanh(Canh canh);
        void ThemDinh(IDiem diemDinh);

        void XoaMotDiem(IDiem diemClick);
    }

    public interface IDiem
    {
        event EventHandler<DiemDoubleClickedArgs> OnDoubleClickK;
        event EventHandler<DiemClickedArgs> ClickOn;
        Point Center { get; }
        Color Color { get; set; }
        bool Overlap(Diem other);
        string PointName { get; set; }
    }

    public interface ICanh
    {
        IDiem DiemCuoi { get; set; }
        IDiem DiemDau { get; set; }
        Color Color { get; set; }
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}
