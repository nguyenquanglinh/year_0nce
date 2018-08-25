using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyAnhCanBan
{
    /// <summary>
    /// tạo đơi tượng xử lý chung nhất chuyển đổi ảnh
    /// </summary>
    public interface IXuLyAnh
    {
        void ConvertImage(byte[,] mangByte);
    }
}
