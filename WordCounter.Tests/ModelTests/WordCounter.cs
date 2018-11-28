using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
    public void CheckIfWordIsInString_CompareFirstLetterToFistLetterOfFirstWord_True()
    {
      WordAnalysis compareSecond = new WordAnalysis("saw", "I saw a dog");
      bool checkWord = compareSecond.CheckIfWordIsInString();
      Assert.AreEqual(true, checkWord);
    }
    [TestMethod]
    public void CompareTwoInputs_CompareWordAndSentence_True()
    {
      WordAnalysis compareInputs = new WordAnalysis("i saw a dog", "i saw a dog");
      bool inputs = compareInputs.CompareTwoInputs();
      Assert.AreEqual(true, inputs);
    }
    [TestMethod]
    public void SplitSentence_CompareWordAndSentence_True()
    {
      WordAnalysis compareStrings = new WordAnalysis("seent", "I seent a dog");
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
