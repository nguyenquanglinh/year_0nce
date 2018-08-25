using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinhSoLonBieuThucTrungTo;
namespace TestBieuThuc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var s = new SoLon("00000000000000111111");
            var ss = new SoLon(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
            var sss = s.Cong(ss);
        }
    }
}
