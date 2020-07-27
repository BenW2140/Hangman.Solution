using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
  public class GamesController : Controller
  {
    public static Game newGame = null;
    [HttpGet("/games")]
    public ActionResult Index()
    {
      newGame = new Game();
      newGame.WordGet();
      newGame.WordDisplay();
      return View(newGame);
    }

    [HttpPost("/games/new")]
    public ActionResult New(char guess)
    {
      if (newGame.IsCorrect(guess))
      {
        newGame.UpdateDisplay(guess);
      }
      else
      {
        newGame.DecreaseGuesses();
      }
      return View("Index", newGame);
    }
  }
}