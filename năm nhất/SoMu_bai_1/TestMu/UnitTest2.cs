using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMu
{
    [TestClass]
    public class KiemTraLuyThua
    {
        [TestMethod]
        public void LuyThua_2_3_8()
        {
            Assert.AreEqual(8, SoMu_bai_1.Program.LuyThua(2, 3));
        }

        [TestMethod]
        public void LuyThua_1_5_2_225()
        {
            Assert.AreEqual(2.25, SoMu_bai_1.Program.LuyThua(1.5, 2));
        }
    }
}
