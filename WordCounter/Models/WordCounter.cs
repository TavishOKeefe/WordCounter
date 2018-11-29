using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordAnalysis
  {
    private string _word;
    private string _sentence;

    public WordAnalysis(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public bool CheckIfWordIsInString()
    {
      string inputWord = (_word);
      if (_sentence.Contains(inputWord))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public List<string> SplitSentence()
    {
      string phrase = _sentence;
      string[] convertedSentence = phrase.Split(' ');
      List<string> matchingWords = new List<string> {};

      foreach (string words in convertedSentence)
      {
        if (words == _word)
        {
          matchingWords.Add(words);
        }
      }
      return matchingWords;
    }

    public int CountWordsInPhrase()
    {
      List<string> matchingWords = SplitSentence();
      int count = matchingWords.Count;
      return count;
    }
  }
}
