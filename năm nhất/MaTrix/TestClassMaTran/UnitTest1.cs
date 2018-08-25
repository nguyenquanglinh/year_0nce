using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MaTrix;
namespace TestClassMaTran
{
    [TestClass]
    public class UnitTest1
    {
        public bool KiemTraHaiMangGiongNhau(int[,] a, int[,] b)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            if (m != b.GetLength(0))
                return false;
            if (n != b.GetLength(1))
                return false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] != b[i, j])
                        return false;
                }
            }
            return true;
        }

        public MaTrix1 MaTran()
        {
            var a = new MaTrix1(new int[2, 2] { { 1, 2 }, { 3, 4 } });
            return a;
        }

        [TestMethod]
        public void CongHaiMaTranBangNhau()
        {
            var a = MaTran();
            var b = MaTran();
            var c = a.Add(b);
            bool bangNhau = KiemTraHaiMangGiongNhau(c.Data, new int[2, 2] { { 2, 4 }, { 6, 8 } });
            Assert.AreEqual(bangNhau, true);
        }

        [TestMethod]
        public void CongHaiMaTranK0BangNhau()
        {
            var a = MaTran();
            var b = MaTran();
            var c = a.Add(b);
            bool bangNhau = KiemTraHaiMangGiongNhau(c.Data, new int[2, 2] { { 2, 4 }, { 7, 8 } });
            Assert.AreEqual(bangNhau, false);
        }

        [TestMethod]
        public void TruHaiMaTranBangNhau()
        {
            var a = MaTran();
            var b = MaTran();
            var c = a.Tru(b);
            bool bangNhau = KiemTraHaiMangGiongNhau(c.Data, new int[2, 2] { { 0, 0 }, { 0, 0 } });
            Assert.AreEqual(bangNhau, true);
        }

        [TestMethod]
        public void TruHaiMaTranK0BangNhau()
        {
            var a = MaTran();
            var b = MaTran();
            var c = a.Tru(b);
            bool bangNhau = KiemTraHaiMangGiongNhau(c.Data, new int[2, 2] { { 0, 0 }, { 1, 8 } });
            Assert.AreEqual(bangNhau, false);
        }

        [TestMethod]
        public void NhanHaiMaTranK0BangNhau()
        {
            var a = MaTran();
            var b = MaTran();
            var c = a.Nhan(b);
            bool bangNhau = KiemTraHaiMangGiongNhau(c.Data, new int[2, 2] { { 0, 0 }, { 1, 8 } });
            Assert.AreEqual(bangNhau, false);
        }

        [TestMethod]
        public void NhanHaiMaTranBangNhau()
        {
            var a = MaTran();
            var b = MaTran();
            var c = a.Nhan(b);
            bool bangNhau = KiemTraHaiMangGiongNhau(c.Data, new int[2, 2] { { 1, 4}, { 9, 16 } });
            Assert.AreEqual(bangNhau, true);
        }

        [TestMethod]
        public void ChiaHaiMaTranBangNhau()
        {
            var a = MaTran();
            var b = MaTran();
            var c = a.Chia(b);
            bool bangNhau = KiemTraHaiMangGiongNhau(c.Data, new int[2, 2] { { 1, 1 }, { 1, 1 } });
            Assert.AreEqual(bangNhau, true);
        }

        [TestMethod]
        public void ChiaHaiMaTranK0BangNhau()
        {
            var a = MaTran();
            var b = MaTran();
            var c = a.Chia(b);
            bool bangNhau = KiemTraHaiMangGiongNhau(c.Data, new int[2, 2] { { 1, 2 }, { 1, 1 } });
            Assert.AreEqual(bangNhau, false);
        }
    }
}
