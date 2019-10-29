using System;
using AreasLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreasTest
{
    [TestClass]
    public class PolygonTests
    {
        /// <summary>
        /// I used a web site for calculating etalons which provided with low precision. So this precision isn't big
        /// </summary>
        private const string PrecisionPoly = "E3";
        [TestMethod]
        public void AreaOk1()
        {
            var points = new Point[]
            {
                new Point(-5.26, 3.37),
                new Point(-3.66, -2.67),
                new Point(5.84, -1.55),
                new Point(1.36, 0.79),
                new Point(2.2, 6.27),
                new Point(-1.68, 1.61)
            };
            var etalon = 39.02;

            var (a, e) = PolygonHelper.Area(points);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionPoly)}\r\nEtalon:{etalon.ToString(PrecisionPoly)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionPoly), a.ToString(PrecisionPoly));
        }

        [TestMethod]
        public void AreaOk3()
        {
            // a complicated snake
            var points = new Point[]
            {
                new Point(-2, 3),
                new Point(-5, 0),
                new Point(-5.62, -4.69),
                new Point(-2.86, -6.99),
                new Point(1.94, -7.27),
                new Point(4.38, -4.21),
                new Point(5.44, -0.15),
                new Point(3.52, -2.17),
                new Point(2.64, -4.23),
                new Point(0.36, -5.47),
                new Point(-2.76, -4.73),
                new Point(-3.42, -3.19),
                new Point(-3.44, -0.83),
                new Point(-0.06, -2.25),
                new Point(-1.64, -3.53),
                new Point(-2.28, -2.11),
                new Point(-2.1, -4.31),
                new Point(0.44, -3.67),
                new Point(0.92, -0.21),
                new Point(-2.08, 0.51)
            };
            var etalon = 45.83;

            var (a, e) = PolygonHelper.Area(points);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionPoly)}\r\nEtalon:{etalon.ToString(PrecisionPoly)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionPoly), a.ToString(PrecisionPoly));
        }

        [TestMethod]
        public void AreaOk2()
        {
            var points = new Point[]
            {
                new Point(-5.26, 3.37),
                new Point(-5.26, 3.37),
                new Point(-5.26, 3.37),
            };
            var etalon = 0;

            var (a, e) = PolygonHelper.Area(points);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionPoly)}\r\nEtalon:{etalon.ToString(PrecisionPoly)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionPoly), a.ToString(PrecisionPoly));
        }

        [TestMethod]
        public void AreaOk4()
        {
            var points = new Point[]
            {
                new Point(-5.26, 3.37),
                new Point(-5.26, double.PositiveInfinity),
                new Point(-5.26, 3.37),
            };
            var etalon = double.NaN;

            var (a, e) = PolygonHelper.Area(points);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionPoly)}\r\nEtalon:{etalon.ToString(PrecisionPoly)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionPoly), a.ToString(PrecisionPoly));
        }

        [TestMethod]
        public void AreaFail1()
        {
            var points = new Point[]
            {
                new Point(-5.26, 3.37),
                new Point(-1.26, 0),
            };


            var (a, e) = PolygonHelper.Area(points);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionPoly)}");

            Assert.AreEqual(Errors.NeedMorePoints, e);
            Assert.AreEqual((-1).ToString(PrecisionPoly), a.ToString(PrecisionPoly));
        }
    }
}
