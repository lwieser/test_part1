using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class AlgorithmsTester
    {
        [TestMethod]
        public void Divide_With10And5_Then2() // [Method]_With[params]_Then[expected]
        {
            var res = Algorithms.Divide(10, 5);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void Divide_With1And1_Then1()
        {
            var res = Algorithms.Divide(1, 1);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Divide_With10And0_Then10()
        {
            var res = Algorithms.Divide(10, 0);
            Assert.AreEqual(10,res);
        }
    }
}
