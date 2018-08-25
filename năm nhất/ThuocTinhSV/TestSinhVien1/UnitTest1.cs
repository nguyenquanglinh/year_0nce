using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ThuocTinhSV;

namespace TestSinhVien1
{
    [TestClass]
    public class UnitTest1
    {
        public List<SinhVien> TaoList()
       { 
            var list = new List<SinhVien>();
            list.Add(new SinhVien("nguyen van an", "ha noi", 1, 2, 3, 19));
            list.Add(new SinhVien("nguyen van trung", "ha noi", 1, 2, 3, 19));
            list.Add(new SinhVien("nguyen thanh an an", "ha tay", 1, 2, 3, 19));
            list.Add(new SinhVien("nguyen van an", "ha noi", 1, 2, 3, 19));
            list.Add(new SinhVien("nguyen van trung", "ha noi", 1, 2, 3, 19));
            return list;
        }

        [TestMethod]
        public void Xoa_TrungTen_XoaHetCacSinhVienTrungTen()
        {
            var list = TaoList();
            var listDaXoa = Program.XoaTen(list, "an");
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(list[0].Ten, "nguyen van trung");
        }
    }
}
