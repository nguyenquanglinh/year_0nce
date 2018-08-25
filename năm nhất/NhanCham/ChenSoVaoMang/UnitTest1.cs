using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChenSoVaoMang
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NhanCham_5_5()
        {
            int[,] a = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            int[,] b = new int[3, 3] { { 1, 0, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            var s = NhanCham.Program.DienVongTrong(a, b);
            CollectionAssert.AreEqual(s, new int[,] { { 1, 2, 3, 4, 5 }, { 1, 16, 24, 32, 5 }, { 1, 16, 24, 32, 5 }, { 1, 16, 24, 32, 5 }, { 1, 2, 3, 4, 5 } });
        }
        [TestMethod]
        public void KiemTraSo_3()
        {
            int[,] a = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            Assert.AreEqual(true, NhanCham.Program.KiemTraSuCoMatCuaMotSoTrongMang(a, 3));
        }
        [TestMethod]
        public void DemSoAmDuongTrenHang()
        {
            var a = new int[3, 3] { { -1, -2, -3 }, { 1, 2, 3 }, { -1, -2, 4 } };
            var s = NhanCham.Program.DemSoDuongSoAmTrenMotHang(a);
            Assert.AreEqual(2, s.Count);
            CollectionAssert.AreEqual(s[0], new int[] { 1, 2, 3, 4 });
            CollectionAssert.AreEqual(s[1], new int[] { -1, -2, -3, -1, -2 });
        }
        [TestMethod]
        public void NhanCham_5_5_c2()
        {
            int[,] a = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            int[,] b = new int[3, 3] { { 1, 0, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            var s = NhanCham.Program.CachHaiNhanChap(a, b);
            CollectionAssert.AreEqual(s, new int[,] { { 1, 2, 3, 4, 5 }, { 1, 16, 24, 32, 5 }, { 1, 16, 24, 32, 5 }, { 1, 16, 24, 32, 5 }, { 1, 2, 3, 4, 5 } });
        }
    }
}
