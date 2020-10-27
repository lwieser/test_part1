using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class PalindromeTester
    {
        [TestMethod]
        public void IsPalindrome_WithMaoam_ThenTrue()
        {
            Assert.IsTrue(Algorithms.IsPalindrome("Maoam"));
        }
        [TestMethod]
        public void IsPalindrome_Withmaoam_ThenTrue()
        {
            Assert.IsTrue(Algorithms.IsPalindrome("maoam"));
        }
        [TestMethod]
        public void IsPalindrome_WithNull_ThenFalse()
        {
            Assert.IsFalse(Algorithms.IsPalindrome(null));
        }
        [TestMethod]
        public void IsPalindrome_WithEmpty_ThenTrue()
        {
            Assert.IsTrue(Algorithms.IsPalindrome(""));
        }
        [TestMethod]
        public void IsPalindrome_WithLongEmptyString_ThenTrue()
        {
            Assert.IsTrue(Algorithms.IsPalindrome("            "));
        }
    }
}