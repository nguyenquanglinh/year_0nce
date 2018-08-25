using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyAnhCanBan
{
    /// <summary>
    /// lớp trìu tượng xử lý có hàm tạo bên trong
    /// </summary>
    public abstract class XuLy : IXuLyAnh
    {
        public XuLy()
        {
        }

        abstract public void ConvertImage(byte[,] mangByte);
    }

}
