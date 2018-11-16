using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class WordCounter
  {
    private string _word;
    private List<string> _sentence = new List<string>{};

    public void inputedWord (string word, List<string> sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public bool LetterCompare ()
    {
      return true;
    }



  }
}
