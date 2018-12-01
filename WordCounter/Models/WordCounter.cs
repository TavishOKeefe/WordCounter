using System.Collections.Generic;

namespace WordCounter.Models
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

    public List<string> SplitSentence()
    {
      char[] charsToTrim = {',', '.', '?', '!', ';', ':'};
      string[] convertedSentence = _sentence.Split(' ');
      List<string> matchingWords = new List<string> {};

      foreach (string words in convertedSentence)
      {
        string perfectWords = words.TrimEnd(charsToTrim);
        if (perfectWords == _word)
        {
          matchingWords.Add(perfectWords);
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
