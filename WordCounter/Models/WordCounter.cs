using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class WordCounter
  {
    private string _word;
    private List<string> _sentence;

    public void InputedWord (string word, List<string> sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public string LetterCompare ()
    {
      return "dog";
    }



  }
}
