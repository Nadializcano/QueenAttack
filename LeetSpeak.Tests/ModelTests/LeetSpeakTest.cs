using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
    [TestClass]
    public class LeetSpeakTest
    {
        [TestMethod]
        public void LeetSpeakTranslate_ConvertETo3_True()
        {
            LeetSpeakTranslator leetSpeak  = new LeetSpeakTranslator();
            Assert.AreEqual("33", leetSpeak.Translate("Ee"));
        }

        [TestMethod]
        public void LeetSpeakTranslate_ConvertOTo0_True()
        {
            LeetSpeakTranslator leetSpeak  = new LeetSpeakTranslator();
            Assert.AreEqual("H3ll0", leetSpeak.Translate("Hello"));

        }

        [TestMethod]
        public void LeetSpeakTranslate_ConvertITo1_True()
        {
            LeetSpeakTranslator leetSpeak  = new LeetSpeakTranslator();
            Assert.AreEqual("1lluzi0n", leetSpeak.Translate("Illusion"));

        }

        [TestMethod]
        public void LeetSpeakTranslate_ConvertTTo7_True()
        {
            LeetSpeakTranslator leetSpeak  = new LeetSpeakTranslator();
            Assert.AreEqual("7abl3", leetSpeak.Translate("Table"));

        }

        [TestMethod]
        public void LeetSpeakTranslate_ConvertSTozIfNotFirstLetter_True()
        {
            LeetSpeakTranslator leetSpeak  = new LeetSpeakTranslator();
            Assert.AreEqual("Sazzy", leetSpeak.Translate("Sassy"));

        }

        
    }
}