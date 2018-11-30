using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordAnalysisTests
  {
    [TestMethod]
    public void CheckIfWordIsInString_CompareFirstLetterToFistLetterOfFirstWord_True()
    {
      WordAnalysis compareSecond = new WordAnalysis("saw", "I saw a dog");
      bool checkWord = compareSecond.CheckIfWordIsInString();
      Assert.AreEqual(true, checkWord);
    }
    [TestMethod]
    public void SplitSentence_CompareWordAndSentence_True()
    {
      WordAnalysis compareStrings = new WordAnalysis("seent", "I seent, a dog");
      List<string> strings = compareStrings.SplitSentence();
      List<string>  expected = new List<string>(){"seent"};
      CollectionAssert.AreEqual(expected, strings);
    }
    [TestMethod]
    public void CountWordsInPhrase_ReturnsNumberOfInstancesOfWordInPhrase_Int()
    {
      WordAnalysis compareStrings = new WordAnalysis("seent", "I seent a dog");
      int expectedCound = 1;
      int actualCount = compareStrings.CountWordsInPhrase();
      Assert.AreEqual(expectedCound, actualCount);
    }
  }
}
