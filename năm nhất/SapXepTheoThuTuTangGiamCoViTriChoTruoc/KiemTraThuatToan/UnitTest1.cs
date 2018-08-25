using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace KiemTraThuatToan
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Mag3_3_vt_1_1()
        {
            var s = new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            CollectionAssert.AreEqual(new int[3, 3] { { 9, 8, 7 }, { 6, 4, 5 }, { 1, 2, 3 } }, SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.SapXepTheoMotViTri(s, 1, 1));
        }
        [TestMethod]
        public void mag_3_3vt_1_2()
        {
            var s = new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            CollectionAssert.AreEqual(new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 1, 2, 3 } }, SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.SapXepTheoMotViTri(s, 1, 2));
        }
        [TestMethod]
        public void mag_0_0vt_0_0()
        {
            var s = new int[0, 0] { };
            CollectionAssert.AreEqual(new int[0, 0] { }, SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.SapXepTheoMotViTri(s, 0, 0));
        }
        [TestMethod]
        public void mag_4_3vt_1_2()
        {
            var s = new int[4, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 }, { 3, 2, 1 } };
            CollectionAssert.AreEqual(new int[4, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 1, 2, 3 }, { 1, 2, 3 } }, SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.SapXepTheoMotViTri(s, 1, 2));
        }
        [TestMethod]
        public void mag_4_3vt_1_1()
        {
            var s = new int[4, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 }, { 3, 2, 1 } };
            CollectionAssert.AreEqual(new int[4, 3] { { 9, 8, 7 }, { 6, 4, 5 }, { 1, 2, 3 }, { 1, 2, 3 } }, SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.SapXepTheoMotViTri(s, 1, 1));
        }
        [TestMethod]
        public void mag_3_3_t_1()
        {
            var s = SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.TinhTongCacDuongCheoTrenMang(new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } });
            Assert.AreEqual(2, s.Count);
            CollectionAssert.AreEqual(s, new int[] { 15, 15 });
        }
        [TestMethod]
        public void mag_4_3t_1()
        {
            var s = SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.TinhTongCacDuongCheoTrenMang(new int[4, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 }, { 3, 2, 1 } });
            Assert.AreEqual(2, s.Count);
            CollectionAssert.AreEqual(s, new int[] { 15, 15 });
        }
        [TestMethod]
        public void mag_4_3vt_11()
        {
            var s = new int[4, 3] { { 7, 8, 9 }, { 6, 4, 5 }, { 1, 2, 3 }, { 1, 2, 3 } };
            CollectionAssert.AreEqual(new int[4, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 3, 2 }, { 2, 1, 1 } }, SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.SapXepTheoThuTuGiamDan(s, 1, 1));
        }
        [TestMethod]
        public void Mag3_3_vt_11()
        {
            var s = new int[3, 3] { { 7, 8, 9 }, { 6, 9, 4 }, { 3, 2, 10 } };
            CollectionAssert.AreEqual(new int[3, 3] { { 7, 8, 9 }, { 4, 6, 9 }, { 2, 3, 10 } }, SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.SapXepTheoMotViTri(s, 0, 0));
        }
        [TestMethod]
        public void Mag3_3_vt_111()
        {
            var s = new int[3, 3] { { 7, 8, 9 }, { 6, 9, 4 }, { 3, 2, 10 } };
            CollectionAssert.AreEqual(new int[3, 3] { { -1, -1, -1 }, { 6, -1, -1 }, { 3, 2, -1 } }, SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.DienSoSao(s));
        }
        [TestMethod]
        public void mag_max_t_1()
        {
            var s = SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.TimMaxMin(new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } });
            Assert.AreEqual(2, s.Count);
            CollectionAssert.AreEqual(s, new int[] { 9, 1 });
        }
        [TestMethod]
        public void mag_max_t_2()
        {
            var s = SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.TimMaxMin(new int[3, 3] { { 19, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } });
            Assert.AreEqual(2, s.Count);
            CollectionAssert.AreEqual(s, new int[] { 19, 1 });
        }
        [TestMethod]
        public void mag_max_c_1()
        {
            var s = SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.TongSoChanSoLe(new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } });
            Assert.AreEqual(2, s.Count);
            CollectionAssert.AreEqual(s, new int[] { 20, 45 });
        }
        [TestMethod]
        public void mag_max_c_2()
        {
            var s = SapXepTheoThuTuTangGiamCoViTriChoTruoc.Program.TongSoChanSoLe(new int[0, 0] { });
            Assert.AreEqual(0, s.Count);
            CollectionAssert.AreEqual(s, new int[] { });
        }
    }
}
