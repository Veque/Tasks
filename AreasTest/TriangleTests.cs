using System;
using AreasLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreasTest
{
    [TestClass]
    public class TriangleTests
    {
        private const string PrecisionArea = "E10";
        [TestMethod]
        public void AreaOk1()
        {
            var a = 3d;
            var b = 4d;
            var c = 5d;

            var etalon = 6d;

            var (area, e) = TriangleHelper.Area(a, b, c);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{area.ToString(PrecisionArea)}\r\nEtalon:{etalon.ToString(PrecisionArea)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionArea), area.ToString(PrecisionArea));
        }

        [TestMethod]
        public void AreaOk2()
        {
            var a = 5.08d;
            var b = 3.94d;
            var c = 8.91d;

            var etalon = 3.1025589091d;

            var (area, e) = TriangleHelper.Area(a, b, c);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{area.ToString(PrecisionArea)}\r\nEtalon:{etalon.ToString(PrecisionArea)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionArea), area.ToString(PrecisionArea));
        }

        [TestMethod]
        public void AreaFail1()
        {
            var a = -5.08d;
            var b = 3.94d;
            var c = 8.91d;

            var (area, e) = TriangleHelper.Area(a, b, c);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{area.ToString(PrecisionArea)}");

            Assert.AreEqual(Errors.NegativeSide, e);
            Assert.AreEqual((-1).ToString(PrecisionArea), area.ToString(PrecisionArea));
        }

        [TestMethod]
        public void AreaFail2()
        {
            var a = 5.08d;
            var b = 33.94d;
            var c = 8.91d;

            var (area, e) = TriangleHelper.Area(a, b, c);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{area.ToString(PrecisionArea)}");

            Assert.AreEqual(Errors.WrongSides, e);
            Assert.AreEqual((-1).ToString(PrecisionArea), area.ToString(PrecisionArea));
        }
    }
}
