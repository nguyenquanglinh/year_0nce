using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VongTron
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void v_5_5()
        {
            var a = DiemVongTron.Program.Nhap(5,5);
            CollectionAssert.AreEqual(a, new int[5, 5] { { 1, 2, 3, 4, 5 }, { 16, 17, 18, 19, 6 }, { 15, 24, 25, 20, 7 }, { 14, 23, 22, 21, 8 }, { 13, 12, 11, 10, 9 } });
        }
        [TestMethod]
        public void v_4_4()
        {
            var a = DiemVongTron.Program.Nhap(4,4);
            CollectionAssert.AreEqual(a, new int[4, 4] { { 1, 2, 3, 4 }, { 12, 13, 14, 5 }, { 11, 16, 15, 6 }, { 10, 9, 8, 7 } });
        }
        [TestMethod]
        public void v_4_4_1()
        {
            var a = DiemVongTron.Program.DienSoTang(4,4);
            CollectionAssert.AreEqual(a, new int[4, 4] { { 1, 1, 1, 1 }, { 1, 2, 2, 1 }, { 1, 2, 2, 1 }, { 1, 1, 1, 1 } });
        }
        [TestMethod]
        public void C_4_3()
        {
            var a = DiemVongTron.Program.Nhap(3, 4);
            CollectionAssert.AreEqual(a, new int[3, 4] { { 1, 2, 3, 4 }, { 10, 11, 12, 5 }, { 9, 8, 7, 6 } });
        }
        [TestMethod]
        public void C_2_3()
        {
            var s = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            var a =DiemVongTron.Program.Doichieu(s);
            CollectionAssert.AreEqual(a, new int[2, 3] { { 1, 3, 5 },  { 2, 4, 6 } });
        }
        [TestMethod]
        public void C_3_3()
        {
            var s = new int[3, 3] { { 1, 2 ,3}, { 3, 4,5 }, { 5, 6,7 } };
            var a = DiemVongTron.Program.Doichieu(s);
            CollectionAssert.AreEqual(a, new int[3, 3] { { 1, 3, 5 }, { 2, 4, 6 } , { 3, 5, 7 } });
        }
    }
}
