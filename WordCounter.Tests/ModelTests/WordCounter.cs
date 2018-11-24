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
    public void splitSentence_CompareWordAndSentence_True()
    {
      WordAnalysis compareStrings = new WordAnalysis("dog", "I seen a dog");
      bool strings = compareStrings.splitSentence();
      Assert.AreEqual(true, strings);
    }
  }
}
