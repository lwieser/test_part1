using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class PGCDTester
    {
        [TestMethod]
        public void PGCD_With10and5_then5()
        {
            Assert.AreEqual(5, Algorithms.PGCD(10, 5));
        }

        [TestMethod]
        public void PGCD_With1000and24_then8()
        {
            Assert.AreEqual(8, Algorithms.PGCD(1000, 24));
        }
        [TestMethod]
        public void PGCD_With24and1000_then8()
        {
            Assert.AreEqual(8, Algorithms.PGCD(24, 1000));
        }

        [TestMethod]
        public void PGCD_With96and13_then1()
        {
            Assert.AreEqual(1, Algorithms.PGCD(96, 13));
        }
        [TestMethod]
        public void PGCD_With13and96_then1()
        {
            Assert.AreEqual(1, Algorithms.PGCD(13, 96));
        }

        [TestMethod]
        public void PGCD_With15and0_then0()
        {
            Assert.AreEqual(0, Algorithms.PGCD(15, 0));
        }
        [TestMethod]
        public void Rest_With10And5_Then0()
        {
            Assert.AreEqual(0, Algorithms.GetRest(10,5));
        }
    }
}