using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class Game
  {
    public string Word { get; set; } = null;
    public List<char> Display { get; set; } = null;
    public int Guesses { get; set; } = 5;
    public bool GameOver { get; set; } = false;

    public void WordGet()
    {
      Random rnd = new Random();
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM `words` WHERE id = @wordID;";
      MySqlParameter wordID = new MySqlParameter();
      wordID.ParameterName = "@wordID";
      wordID.Value = rnd.Next(1, 8);
      cmd.Parameters.Add(wordID);
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      string word = "";
      while (rdr.Read())
      {
        word = rdr.GetString(1);
      }
      if (word != null)
      {
        Word = word;
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public void WordDisplay()
    {
      Display = new List<char>{};
      foreach(char x in Word)
      {
        Display.Add('_');
      }
    }

    public bool IsCorrect(char entry)
    {
      if(Word.Contains(entry))
      {
        return true;
      }
      return false;
    }

    public void UpdateDisplay(char entry)
    {
      for (int i = 0; i < Word.Length; i++)
      {
        if (entry == Word[i])
        {
          Display[i] = entry;
        }
      }
      if (Display.Contains('_') == false)
      {
        GameOver = true;
      }
    }

    public void DecreaseGuesses()
    {
      Guesses--;
    }
  }
}