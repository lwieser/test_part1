using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class CorrectTextTester
    {
        private string s1 = "bonjour tout le monde.";
        private string s1c = "Bonjour tout le monde.";
        private string s2 = "Bonjour tout le monde";
        private string s2c = "Bonjour tout le monde.";


        [TestMethod]
        public void CorrectText_WithNull_ThenNull()
        {
            Assert.IsNull(Algorithms.CorrectText(null));
        }

        [TestMethod]
        public void CorrectTest_WithS1_ThenS1c()
        {
            Assert.AreEqual(s1c, Algorithms.CorrectText(s1));
        }
        [TestMethod]
        public void CorrectTest_WithS2_ThenS2c()
        {
            Assert.AreEqual(s2c, Algorithms.CorrectText(s2));
        }

        [TestMethod]
        public void CorrectTest_WithTwoS1_ThenTwoS1c()
        {
            Assert.AreEqual(s1c+s1c, Algorithms.CorrectText(s1+s1));
        }

        [TestMethod]
        public void CorrectSentence_WithEmpty_ThenEmpty()
        {
            Assert.AreEqual("", Algorithms.CorrectSentence(""));
        }

    }
}