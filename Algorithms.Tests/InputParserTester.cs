using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class InputParserTester
    {
        [TestMethod]
        public void ParseInt_With2_Then2()
        {
            Assert.AreEqual(2, InputParser.ParseInt("2"));
        }
        [TestMethod]
        public void ParseInt_WithMdr_Then0()
        {
            Assert.AreEqual(0, InputParser.ParseInt("mdr"));
        }
    }
}