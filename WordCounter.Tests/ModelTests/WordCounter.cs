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
    }
    [TestMethod]
    public void CompareFirstLetter_CompareFirstLetterToFistLetterOfFirstWord_True()
    {
      WordAnalysis compareSecond = new WordAnalysis("dog", "I saw a dog");
      bool firstLetter = compareSecond.CheckIfWordIsInString();
      Assert.AreEqual(true, firstLetter);
    }
  }
}
