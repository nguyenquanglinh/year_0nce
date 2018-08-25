using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SapXepTangDanTheoThuTuTangDan
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Hv9pt()
        {
            var s = new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            CollectionAssert.AreEqual(new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, SapXepMangThyeoThuTu.Program.SapXepTheoHinhVuong(s));
        }
        [TestMethod]
        public void ChuyenTuHaisangMot0Pt()
        {
            var s = new int[0, 0];
            CollectionAssert.AreEqual(new int[,] { }, SapXepMangThyeoThuTu.Program.SapXepTheoHinhVuong(s));
        }
        [TestMethod]
        public void ChuyenTuHaisangMot1Pt()
        {
            var s = new int[1, 1] { { 1 } };
            CollectionAssert.AreEqual(new int[] { 1 }, SapXepMangThyeoThuTu.Program.SapXepTheoHinhVuong(s));
        }
        [TestMethod]
        public void CachHai1Pt()
        {
            var s = new int[1, 1] { { 1 } };
            CollectionAssert.AreEqual(new int[] { 1 }, SapXepMangThyeoThuTu.Program.SapXepTheoThuTuTangDanCuahang(s));
        }
        [TestMethod]
        public void CachHai4Pt()
        {
            var s = new int[2, 2] { { 9, 8 }, { 7, 6 } };
            CollectionAssert.AreEqual(new int[2, 2] { { 8, 9 }, { 6, 7 } }, SapXepMangThyeoThuTu.Program.SapXepTheoThuTuTangDanCuahang(s));
        }
        [TestMethod]
        public void CachHai9Pt()
        {
            var s = new int[3, 3] { { 9, 8, 7 }, { 7, 6, 5 }, { 5, 4, 3 } };
            CollectionAssert.AreEqual(new int[3, 3] { { 7, 8, 9 }, { 5, 6, 7 }, { 3, 4, 5 } }, SapXepMangThyeoThuTu.Program.SapXepTheoThuTuTangDanCuahang(s));
        }
        [TestMethod]
        public void CachHai6Pt()
        {
            var s = new int[2, 3] { { 9, 8, 7 }, { 7, 6, 5 } };
            CollectionAssert.AreEqual(new int[2, 3] { { 7, 8, 9 }, { 5, 6, 7 } }, SapXepMangThyeoThuTu.Program.SapXepTheoThuTuTangDanCuahang(s));
        }
        [TestMethod]
        public void CachHai16Pt()
        {
            var s = new int[4, 4] { { 9, 8, 7, 1 }, { 3, 7, 6, 5 }, { 5, 5, 4, 2 }, { 3, 3, 2, 0 } };
            CollectionAssert.AreEqual(new int[4, 4] { { 1, 7, 8, 9 }, { 3, 5, 6, 7 }, { 2, 4, 5, 5 }, { 0, 2, 3, 3 } }, SapXepMangThyeoThuTu.Program.SapXepTheoThuTuTangDanCuahang(s));
        }
        [TestMethod]
        public void CachHai12Pt()
        {
            var s = new int[4, 3] {
                { 9, 8, 7 },
                {  7, 6, 5 },
                { 5, 4, 2 },
                { 30,  2, 0 } };
            CollectionAssert.AreEqual(new int[4, 3] { { 7, 8, 9 }, { 5, 6, 7 }, { 2, 4, 5 }, { 0, 2, 30 } }, SapXepMangThyeoThuTu.Program.SapXepTheoThuTuTangDanCuahang(s));
        }

    }
}
