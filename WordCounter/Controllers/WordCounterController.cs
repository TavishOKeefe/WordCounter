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

  }
}
