using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;

namespace Hangman.Tests
{
  [TestClass]
  public class GameTests
  {
    // Test methods go here
    [TestMethod]
    public void GameConstructor_CanInitializeAGameObject_ObjectCreated()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void WordGet_RetrievesARandomWordFromTheDatabase_WordGotten()
    {
      Game newGame = new Game();
      newGame.WordGet();
      Assert.IsNotNull(newGame.Word);
    }
  }
}