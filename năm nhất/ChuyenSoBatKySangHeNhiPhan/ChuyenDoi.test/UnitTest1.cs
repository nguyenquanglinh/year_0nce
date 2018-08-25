using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChuyenDoi.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual( 0000 , ChuyenSoBatKySangHeNhiPhan.Program.ChuyenDoi(0));
        }
    }
}
