using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class FiboTester
    {
        [TestMethod]
        public void Fibonacci_With0_ThenLastElementIs0()
        {
            Assert.AreEqual(0, Algorithms.Fibonacci(0).Length);
        }
        [TestMethod]
        public void Fibonacci_With1_ThenLastElementIs0()
        {
            Assert.AreEqual(0, Algorithms.Fibonacci(1).Last());
        }
        [TestMethod]
        public void Fibonacci_With2_ThenLastElementIs1()
        {
            Assert.AreEqual(1, Algorithms.Fibonacci(2).Last());
        }
        [TestMethod]
        public void Fibonacci_With3_ThenLastElementIs1()
        {
            Assert.AreEqual(1, Algorithms.Fibonacci(3).Last());
        }
        [TestMethod]
        public void Fibonacci_With4_ThenLastElementIs2()
        {
            Assert.AreEqual(2, Algorithms.Fibonacci(4).Last());
        }
        [TestMethod]
        public void Fibonacci_With11_ThenLastElementIs55()
        {
            Assert.AreEqual(55, Algorithms.Fibonacci(11).Last());
        }
        [TestMethod]
        public void Fibonacci_WithLessThenZero_ThenArrayIsEmpty()
        {
            Assert.AreEqual(0, Algorithms.Fibonacci(-2).Length);
        }
    }
}