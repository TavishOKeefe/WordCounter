using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      WordCounterController controller = new WordCounterController();

      ActionResult indexView = controller.New();

      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
  }
}
