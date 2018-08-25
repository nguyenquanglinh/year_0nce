using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace TestTuDien
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var s = "a b c";
            var x = TuDien.Program.KiemTraSoChuSoDong(s);
            Assert.AreEqual(3, x.Count);


            Assert.AreEqual(1, x["a"]);
            Assert.AreEqual(1, x["b"]);
            Assert.AreEqual(1, x["c"]);
        }
        public void TestMethod2()
        {
            var s = "a b c --";
            var x = TuDien.Program.KiemTraSoChuSoDong(s);
            Assert.AreEqual(3, x.Count);


            Assert.AreEqual(2, x["a"]);
            Assert.AreEqual(1, x["b"]);
            Assert.AreEqual(1, x["c"]);
        }
    }
}
