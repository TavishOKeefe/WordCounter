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
      List<string> sentence = new List<string>{"and", "I", "ran"};
      WordCounter compareFirst = new WordCounter("and", sentence);
      string firstWord = compareFirst.LetterCompare();
      Assert.AreEqual(true, firstWord);
    }


  }
}
