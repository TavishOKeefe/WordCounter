using System.Collections.Generic;
using System;

namespace WordCounter
{
  class WordCounter
  {
    private string _word;
    private List<string> _sentence = new List<string>{};

    public inputedWord (string word)
    {
      _word = word;
    }

    public inputedSentence (List<string> sentence)
    {
      _sentence = sentence;
    }

    

  }
}
