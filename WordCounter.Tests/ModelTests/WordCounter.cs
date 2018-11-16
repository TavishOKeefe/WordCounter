using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordAnalysisTests
  {
    [TestMethod]
    public void GetWordtoCompare_CompareFirstLetterToFistLetterOfFirstWord_True()
    {
      WordAnalysis compareFirst = new WordAnalysis("a", "a sentence");
      string firstWord = compareFirst.GetWordToCompare();
      Assert.AreEqual("a", firstWord);
      // RepeatCounter newRepeatCounter = new RepeatCounter("word", "A sentence");
      // Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }
  }
}
