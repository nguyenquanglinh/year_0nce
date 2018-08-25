using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BieuThucTrungToSoLonConsole;
namespace TestSolon
{
    [TestClass]
    public class UnitTest1
    {
        #region Test SoLon

        /// <summary>
        /// chuỗi đúng với thuộc tính arr,tostring,thuộc tính âm dương
        /// </summary>
        //chuỗi 123 duong
        [TestMethod]
        public void HamTao_123()
        {
            var s = new SoLon("123");
            var x = s.ToString();
            Assert.AreEqual("123", x);
            Assert.AreEqual(false, s.LasoAm);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, s.arr);
        }
        [TestMethod]
        //null duong
        public void HamTao_null()
        {
            var s = new SoLon("");
            var x = s.ToString();
            Assert.AreEqual("0", x);
            Assert.AreEqual(false, s.LasoAm);
            CollectionAssert.AreEqual(new int[] { 0 }, s.arr);
        }
        //chuôi 1_duong
        [TestMethod]
        public void HamTao_1()
        {
            var s = new SoLon("1");
            var x = s.ToString();
            Assert.AreEqual("1", x);
            Assert.AreEqual(false, s.LasoAm);
            CollectionAssert.AreEqual(new int[] { 1 }, s.arr);
        }
        //chuoi -123
        [TestMethod]
        public void HamTao__123()
        {
            var s = new SoLon("-123");
            var x = s.ToString();
            Assert.AreEqual("-123", x);
            Assert.AreEqual(true, s.LasoAm);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, s.arr);
        }
        //chuoi -1-23 sai
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void HamTao__1_23()
        {
            var s = new SoLon("-1-23");
        }
        //hàm tạo mảng
        [TestMethod]
        public void HamTao_mang_1234()
        {
            var s = new SoLon(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual("1234", s.ToString());
            Assert.AreEqual(false, s.LasoAm);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, s.arr);
        }
        [TestMethod]
        public void HamTao_mang__1234()
        {
            var s = new SoLon(new int[] { -1, 2, 3, 4 });
            Assert.AreEqual("-1234", s.ToString());
            Assert.AreEqual(true, s.LasoAm);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, s.arr);
        }
        /// <summary>
        /// hàm equals
        /// </summary>
        [TestMethod]
        public void HamSoSanh_false()
        {
            var s = new SoLon("123");
            Assert.AreEqual(false, s.Equals(new SoLon(new int[] { 1, 3, 2 })));
        }
        [TestMethod]
        public void HamSoSanh_true()
        {
            var s = new SoLon(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(true, s.Equals(new SoLon("1234")));
        }
        [TestMethod]
        public void HamSaoSanh__false()
        {
            var s = new SoLon("-1234");
            Assert.AreEqual(false, s.Equals(new SoLon("1234")));
        }
        [TestMethod]
        public void HamSoSanh__true()
        {
            var s = new SoLon(new int[] { -1, 2, 3, 4 });
            Assert.AreEqual(true, s.Equals(new SoLon("-1234")));
        }
        ///<summary>
        ///phep +
        ///<summary>
        [TestMethod]
        public void Cong0_0_0()
        {
            var s = new SoLon("0") + new SoLon(new int[] { 0 });
            Assert.AreEqual(true, s.Equals(new SoLon("0")));
        }
        [TestMethod]
        public void Cong_null_123456789_0_123456789()
        {
            var s = new SoLon("") + new SoLon("123456789");
            Assert.AreEqual(true, s.Equals(new SoLon("123456789")));
        }
        [TestMethod]
        public void Cong_123456789_123456789()
        {
            var s = new SoLon("123456789") + new SoLon(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Assert.AreEqual(true, s.Equals(new SoLon("246913578")));
        }
        [TestMethod]
        public void Cong_123456789__123456789()
        {
            var s = new SoLon("123456789") + new SoLon("-123456789");
            Assert.AreEqual("0", s.ToString());
        }
        [TestMethod]
        public void Cong__123456789__123456789()
        {
            var s = new SoLon("-123456789") + new SoLon("-123456789");
            Assert.AreEqual(true, s.Equals(new SoLon("-246913578")));
        }
        [TestMethod]
        public void Cong_1_9_10()
        {
            var s = new SoLon("1") + new SoLon("9");
            Assert.AreEqual(true, s.Equals(new SoLon("10")));
        }
        ///<summary>
        ///phep -
        ///<summary>
        [TestMethod]
        public void Tru_0_0_0()
        {
            var s = new SoLon("") - new SoLon("0");
            Assert.AreEqual(true, s.Equals(new SoLon("")));
        }
        [TestMethod]
        public void Tru_0_123456__123456()
        {
            var s = new SoLon("") - new SoLon("123456");
            Assert.AreEqual(true, s.Equals(new SoLon("-123456")));
        }
        [TestMethod]
        public void Tru_1234567890_1234567890()
        {
            var s = new SoLon("1234567890") - new SoLon("1234567890");
            Assert.AreEqual("0", s.ToString());
        }
        [TestMethod]
        public void Tru_6_9__3()
        {
            var s = new SoLon("6") - new SoLon("9");
            Assert.AreEqual(true, s.Equals(new SoLon("-3")));
        }
        [TestMethod]
        public void Tru_1__9_10()
        {
            var s = new SoLon("1") - new SoLon("-9");
            Assert.AreEqual(true, s.Equals(new SoLon("10")));
        }
        [TestMethod]
        public void Tru_1234_1235__1()
        {
            var s = new SoLon("1234") - new SoLon("1235");
            Assert.AreEqual(true, s.Equals(new SoLon("-1")));
        }
        [TestMethod]
        public void Tru_1_10__9()
        {
            var s = new SoLon("1") - new SoLon("10");
            Assert.AreEqual(true, s.Equals(new SoLon("-9")));
        }
        ///<summary>
        ///phep *
        ///<summary>
        [TestMethod]
        public void Nhan_0_0_0()
        {
            var s = new SoLon("") * new SoLon("");
            Assert.AreEqual(true, s.Equals(new SoLon("")));
        }
        [TestMethod]
        public void Nhan_1_0_0()
        {
            var s = new SoLon("0") * new SoLon("1");
            Assert.AreEqual(true, s.Equals(new SoLon("0")));
        }
        [TestMethod]
        public void Nhan_123_123_15129()
        {
            var s = new SoLon("123") * new SoLon("123");
            Assert.AreEqual(true, s.Equals(new SoLon("15129")));
        }
        [TestMethod]
        public void Nhan_123456__1__12346()
        {
            var s = new SoLon("-1") * new SoLon("123456");
            Assert.AreEqual(true, s.Equals(new SoLon("-123456")));
        }
        ///<summary>
        ///phep ^
        ///<summary>
        [TestMethod]
        public void Mu_1_2_1()
        {
            var s = new SoLon("1") ^ new SoLon("2");
            Assert.AreEqual(true, s.Equals(new SoLon("1")));
        }
        [TestMethod]
        public void Mu_2_10_1024()
        {
            var s = new SoLon("2") ^ new SoLon("10");
            Assert.AreEqual(true, s.Equals(new SoLon("1024")));
        }
        [TestMethod]
        public void Mu_3_10_59049()
        {
            var s = new SoLon("3") ^ new SoLon("10");
            Assert.AreEqual(true, s.Equals(new SoLon("59049")));
        }
        [TestMethod]
        public void Mu_4_10_1048576()
        {
            var s = new SoLon("4") ^ new SoLon("10");
            Assert.AreEqual(true, s.Equals(new SoLon("1048576")));
        }
        [TestMethod]
        public void Mu_5_11_48828125()
        {
            var s = new SoLon("5") ^ new SoLon("11");
            Assert.AreEqual(true, s.Equals(new SoLon("48828125")));
        }
        [TestMethod]
        public void Mu_6_12_2176782336()
        {
            var s = new SoLon("6") ^ new SoLon("12");
            Assert.AreEqual(true, s.Equals(new SoLon("2176782336")));
        }
        #endregion
        #region
        ///<summary>
        ///chuyen trung to
        ///<summary>
        // [TestMethod]
        //public void 

        #endregion
    }
}
