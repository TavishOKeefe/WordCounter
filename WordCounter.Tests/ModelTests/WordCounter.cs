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
      WordAnalysis compareSecond = new WordAnalysis("dog", "I saw a dog");
      bool checkWord = compareSecond.CheckIfWordIsInString();
      Assert.AreEqual(true, checkWord);
    }
    // [TestMethod]
    // public void BreakWordIntoCharacters_BreakInputWordIntoCharacters_True()
    // {
    //   WordAnalysis breakWord = new WordAnalysis("dog", "I saw a dog");
    //   bool brokenWord = breakWord.BreakWordIntoCharacters();
    //   Assert.AreEqual(true, brokenWord);
    // }
    // [TestMethod]
    // public void BreakSentenceIntoCharacters_BreakInputSentenceIntoCharacters_True()
    // {
    //   WordAnalysis breakSentence = new WordAnalysis("dog", "I saw a dog");
    //   bool brokenSentence = breakSentence.BreakSentenceIntoCharacters();
    //   Assert.AreEqual(true, brokenSentence);
    // }
    [TestMethod]
    public void CompareTwoInputs_CompareWordAndSentence_True()
    {
      WordAnalysis compareInputs = new WordAnalysis("dog", "i saw a dog");
      bool inputs = compareInputs.CompareTwoInputs();
      Assert.AreEqual(true, inputs);
    }
    // [TestMethod]
    // public void splitSentence_CompareWordAndSentence_True()
    // {
    //   WordAnalysis compareStrings = new WordAnalysis("dog", "I seen a dog");
    //   bool strings = compareStrings.splitSentence();
    //   Assert.AreEqual(true, strings);
    // }
  }
}
