using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void LetterCompare_CompareFirstLetterToFistLetterOfFirstWord_True()
    {
      string expectedWord = "and";
      List<string> sentence = new List<string>{"and"};
      WordCounter compareFirst = new WordCounter(expectedWord, sentence);
      string firstWord = compareFirst.LetterCompare();
      Assert.AreEqual("and", firstWord);
    }


  }
}
