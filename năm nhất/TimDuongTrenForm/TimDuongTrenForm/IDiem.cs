using System;
namespace TimDuongTrenForm
{
    public interface IDiem
    {
        System.Drawing.Point Center { get; }
        System.Drawing.Color Color { get; set; }
        string NameHt { get; set; }
        bool Overlap(IDiem other);
    }
}
