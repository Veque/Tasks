using System;
using AreasLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreasTest
{
    [TestClass]
    public class CircleTests
    {
        /// <summary>
        /// Using the same precision as in Pi, 5 digits
        /// </summary>
        private const string PrecisionCircle = "E4";
        
        
        [TestMethod]
        public void AreaFail1()
        {
            var r = -1d;

            var (a, e) = CircleHelper.Area(r);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionCircle)}");

            Assert.AreEqual(Errors.NegativeRadius, e);
            Assert.AreEqual(-1d, a);
        }

        [TestMethod]
        public void AreaFail2()
        {
            var r = double.NegativeInfinity;

            var (a, e) = CircleHelper.Area(r);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionCircle)}");

            Assert.AreEqual(Errors.NegativeRadius, e);
            Assert.AreEqual(-1d, a);
        }

        [TestMethod]
        public void AreaOk1()
        {
            var r = 0d;
            var etalon = 0d;

            var (a, e) = CircleHelper.Area(r);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionCircle)}\r\nEtalon:{etalon.ToString(PrecisionCircle)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionCircle), a.ToString(PrecisionCircle));
        }

        [TestMethod]
        public void AreaOk2()
        {
            var r = 123.5674329800d;
            var etalon = 47968.697033967d;

            var (a, e) = CircleHelper.Area(r);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionCircle)}\r\nEtalon:{etalon.ToString(PrecisionCircle)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionCircle), a.ToString(PrecisionCircle));
        }

        [TestMethod]
        public void AreaOk3()
        {
            var r = 0.3989422804014327d;
            var etalon = 0.5d;

            var (a, e) = CircleHelper.Area(r);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionCircle)}\r\nEtalon:{etalon.ToString(PrecisionCircle)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionCircle), a.ToString(PrecisionCircle));
        }

        [TestMethod]
        public void AreaOk4()
        {
            var r = 0.73561321801096269d;
            var etalon = 1.7d;

            var (a, e) = CircleHelper.Area(r);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionCircle)}\r\nEtalon:{etalon.ToString(PrecisionCircle)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionCircle), a.ToString(PrecisionCircle));
        }

        [TestMethod]
        public void AreaOk5()
        {
            var r = 1d;
            var etalon = 3.1415926535898d;

            var (a, e) = CircleHelper.Area(r);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionCircle)}\r\nEtalon:{etalon.ToString(PrecisionCircle)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionCircle), a.ToString(PrecisionCircle));
        }

        [TestMethod]
        public void AreaOk6()
        {
            var r = Math.Pow(10,300);
            var etalon = double.PositiveInfinity;

            var (a, e) = CircleHelper.Area(r);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionCircle)}\r\nEtalon:{etalon.ToString(PrecisionCircle)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionCircle), a.ToString(PrecisionCircle));
        }

        [TestMethod]
        public void AreaOk7()
        {
            var r = double.PositiveInfinity;
            var etalon = double.PositiveInfinity;

            var (a, e) = CircleHelper.Area(r);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionCircle)}\r\nEtalon:{etalon.ToString(PrecisionCircle)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionCircle), a.ToString(PrecisionCircle));
        }

        [TestMethod]
        public void AreaOk8()
        {
            var r = double.NaN;
            var etalon = double.NaN;

            var (a, e) = CircleHelper.Area(r);

            Console.WriteLine($"Error:{e.ToString()}\r\nAnswer:{a.ToString(PrecisionCircle)}\r\nEtalon:{etalon.ToString(PrecisionCircle)}");

            Assert.AreEqual(Errors.None, e);
            Assert.AreEqual(etalon.ToString(PrecisionCircle), a.ToString(PrecisionCircle));
        }

        

        
    }
}
