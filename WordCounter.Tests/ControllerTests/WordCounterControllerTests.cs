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
    [TestMethod]
    public void Create_ReturnCorrectActionType_RedirectToActionResult()
    {
    WordCounterController controller = new WordCounterController();

    IActionResult view = controller.Create("Dog", "I seent a dog today.");

    Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }
    [TestMethod]
    public void Create_ReturnCorrectActionName_Index()
    {
    WordCounterController controller = new WordCounterController();
    RedirectToActionResult actionResult = controller.Create("Dog", "I seent a dog today.") as RedirectToActionResult;

    string result = actionResult.ActionName;

    Assert.AreEqual(result, "Index");
}

  }
}
