using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class AlgorithmsTesterAnthony
    {
        [TestMethod]
        public void CorrectText_StartWithMajAndFinishByADot()
        {
            var param = "je m'appelle titouan";
            var res = Algorithms.CorrectText(param);
            Assert.AreEqual(res, "Je m'appelle titouan.");
        }

        [TestMethod]
        public void CorrectText_WithSpaceBeforeADot()
        {
            var param = "Je m'appelle titouan.J'aime les pistolets � billes.";
            var res = Algorithms.CorrectText(param);
            Assert.AreEqual(res, "Je m'appelle titouan. J'aime les pistolets � billes.");
        }

        [TestMethod]
        public void CorrectText_WithSpaceBeforeADotInterro()
        {
            var param = "Je m'appelle titouan?J'aime les pistolets � billes?";
            var res = Algorithms.CorrectText(param);
            Assert.AreEqual(res, "Je m'appelle titouan? J'aime les pistolets � billes?");
        }

        [TestMethod]
        public void CorrectText_WithSpaceBeforeADotExcla()
        {
            var param = "Je m'appelle titouan!J'aime les pistolets � billes!";
            var res = Algorithms.CorrectText(param);
            Assert.AreEqual(res, "Je m'appelle titouan! J'aime les pistolets � billes!");
        }

        [TestMethod]
        public void CorrectText_With2Escape()
        {
            var param = "Je  m'appelle titouan.J'aime  les pistolets �  billes.";
            var res = Algorithms.CorrectText(param);
            Assert.IsFalse(res.Contains("  "));
        }
        [TestMethod]
        public void CorrectSentence_WithALotOfEscape()
        {
            var param = "Bonjour          ";
            var res = Algorithms.CorrectSentence(param);
            Assert.IsFalse(res.Contains("  "));
        }

        [TestMethod]
        public void RemoveSpaces_With_Then()
        {
            var param = "     Bonjour          ";
            var res = Algorithms.RemoveSpaces(param);
            Assert.IsFalse(res.Contains("  "));
        }
        [TestMethod]
        public void RemoveSpaces_With_Then2()
        {
            var param = "     Bonjour      ";
            var res = Algorithms.RemoveSpaces(param);
            Assert.IsFalse(res.Contains("  "));
        }

        [TestMethod]
        public void RemoveSpaces_With_Then3()
        {
            var param = "Bonjour";
            var res = Algorithms.RemoveSpaces(param);
            Assert.IsFalse(res.Contains("  "));
        }


        [TestMethod]
        public void CorrectDots_With4Points()
        {
            var param = "Je  m'appelle titouan....";
            var res = Algorithms.CorrectDots(param);
            Assert.AreEqual(res, "Je  m'appelle titouan...");
        }
        [TestMethod]
        public void CorrectDots_With6Points()
        {
            var param = "J'aime  les pistolets �  billes......";
            var res = Algorithms.CorrectDots(param);
            Assert.AreEqual(res, "J'aime  les pistolets �  billes...");
        }

    }
}