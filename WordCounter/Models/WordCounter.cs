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

    public string GetWordToCompare()
    {
      return _word;
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

    public bool CompareTwoInputs()
    {
      char[] wordArray = _word.ToCharArray();
      char[] sentenceArray = _sentence.ToCharArray();

      if (wordArray.Length == sentenceArray.Length)
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
    // public bool CompareFirstLetter()
    // {
    //   char[] wordArray = _word.ToCharArray();
    //   char[] sentenceArray = _sentence.ToCharArray();
    //
    //   for (int i = 0; i < wordArray.Length; i ++)
    //   {
    //     string compare = wordArray[i];
    //   }
    //   for (int i = 0; i < sentenceArray.Length; i ++)
    //   {
    //     string compareSentence = sentenceArray[i];
    //   }
    //   return true;
    // }

    // public string GetSentenceToCompare()
    // {
    //   return _sentence;
    // }
    //
    // public string CompareFirstLetter()
    // {
    //   string value = "a";
    //   char[] array = value.ToCharArray();
    //
    //   for (int i=0; i<= array.Length; i ++)
    //   {
    //     char letter = array[i=0];
    //     return letter;
    //   }
    //
    // }
    //
    // public string CompareFirstInSentence()
    // {
    //   string valueSentence = "a dog walks";
    //   char[] arrayTwo = valueSentence.ToCharArray();
    //
    //   for (int i=0; i<= arrayTwo.Length; i ++)
    //   {
    //     char FirstLetter = arrayTwo[i=0];
    //     return FirstLetter;
    //   }

    // }
  }
}
