using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RefereeConsole.Test
{
    [TestClass]
    public class TypeConvertTest
    {
        [TestMethod]
        public void ToInt()
        {
            var item = "a";
            var result = item.ToInt();
            Assert.AreEqual(0, result);
            item = "1";
            result = item.ToInt();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ToDateTime()
        {
            var item = "aaa";
            var result = item.ToDateTime();
            Assert.AreEqual(DateTime.MinValue, result);
            item = "00:08:30";
            result = item.ToDateTime();
            Assert.AreEqual(0, result.Hour);
            Assert.AreEqual(8, result.Minute);
            Assert.AreEqual(30, result.Second);
        }
    }
}
