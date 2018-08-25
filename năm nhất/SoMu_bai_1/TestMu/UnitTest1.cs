using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMu
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void X_0_N_0_1()
        {
            var n = 0;
            var x = 0;

            var ketQua = SoMu_bai_1.Program.SoMu(x, n);
            Assert.AreEqual(1, ketQua);
        }


        [TestMethod]
        public void X_0_N_1_1()
        {
            var n = 1;
            var x = 0;

            var ketQua = SoMu_bai_1.Program.SoMu(x, n);
            Assert.AreEqual(1, ketQua);
        }

        [TestMethod]
        public void X_1_N_2_6()
        {
            var n = 2;
            var x = 1;

            var ketQua = SoMu_bai_1.Program.SoMu(x, n);
            Assert.AreEqual(6, ketQua);
        }

        [TestMethod]
        public void X_2_N_2_17()
        {
            var n = 2;
            var x = 2;

            var ketQua = SoMu_bai_1.Program.SoMu(x, n);
            Assert.AreEqual(17, ketQua);
        }

        [TestMethod]
        public void X_1_5_N_3_2()
        {
            var n = 2;
            var x = 1.5;

            var ketQua = SoMu_bai_1.Program.SoMu(x, n);
            Assert.AreEqual(10.75, ketQua);
        }
    }
}
