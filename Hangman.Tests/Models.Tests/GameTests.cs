using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

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

    [TestMethod]
    public void WordDisplay_ShouldGenerateAWordDisplayToKeepTrackOfUserGuesses_ListGenerator()
    {
      Game newGame = new Game();
      newGame.WordGet();
      newGame.WordDisplay();
      List<char> expectedList = new List<char>{};
      foreach(char x in newGame.Word)
      {
        expectedList.Add('_');
      }
      CollectionAssert.AreEqual(expectedList, newGame.Display);
    }

    [TestMethod]
    public void IsCorrect_ShouldDetermineIfLetterIsInWord_Bool()
    {
      Game newGame = new Game();
      newGame.WordGet();
      char entry = 'a';
      bool response = newGame.IsCorrect(entry);
      bool expected = newGame.Word.Contains(entry);
      Assert.AreEqual(expected, response);
    }

    [TestMethod]
    public void UpdateDisplay_UpdateDisplayIfEntryIsCorrect_ListGenerator()
    {
      Game newGame = new Game();
      newGame.Word = "airplane";
      newGame.WordDisplay();
      char entry = 'a';
      newGame.UpdateDisplay(entry);
      List<char> expectedList = new List<char> {'a', '_', '_', '_', '_', 'a', '_', '_'};
      CollectionAssert.AreEqual(expectedList, newGame.Display);
    }

    [TestMethod]
    public void DecreaseGuesses_ReduceRemainingGuessesIfEntryIsIncorrect_Int()
    {
      Game newGame = new Game();
      newGame.Word = "airplane";
      newGame.DecreaseGuesses();
      Assert.AreEqual(4, newGame.Guesses);
    }
  }
}