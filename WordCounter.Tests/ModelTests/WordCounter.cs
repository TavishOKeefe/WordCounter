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
    public void CompareFirstLetterOfTwoInputs_CompareFirstLetterOfWordAndSentence_True()
    {
      WordAnalysis compareFistLetters = new WordAnalysis("dog", "dog");
      bool firstLetter = compareFistLetters.CompareFirstLetterOfTwoInputs();
      Assert.AreEqual(true, firstLetter);
    }
  }
}
