using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/game/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/game")]
    public ActionResult Create(string word, string sentence)
    {
      WordAnalysis newWordAnalysis = new WordAnalysis(word, sentence);
      int finalCount = newWordAnalysis.CountWordsInPhrase();
      return View("Index", finalCount);
    }
  }
}
