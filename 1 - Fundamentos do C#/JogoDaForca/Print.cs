using System;
using System.Collections.Generic;

namespace JogoDaForca
{
  public class Print
  {
    public static short Rows { get; set; }
    public static short Columns { get; set; }

    public static void GamePrint(string tip, IList<char> word, short tries)
    {
      Rows = 40;
      Columns = 8;
      GameDraw(Rows, Columns);
      GameWriteText(tip, word, tries);
    }

    public static void GameDraw(short Columns, short Rows)
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.DarkGray;

      //Show Header
      Console.Write("+");
      for (int i = 0; i < Columns; i++)
      {
        Console.Write("-");
      }
      Console.WriteLine("+");

      //Show Body
      for (int i = 0; i < Rows; i++)
      {
        Console.Write("|");
        for (int j = 0; j < Columns; j++)
        {
          Console.Write(" ");
        }
        Console.Write("|");
        Console.WriteLine("");
      }

      //Show Footer
      Console.Write("+");
      for (int i = 0; i < Columns; i++)
      {
        Console.Write("-");
      }
      Console.WriteLine("+");
    }

    public static void GameWriteText(string tip, IList<char> word, short tries)
    {
      int origRow = Console.CursorTop;
      int origCol = Console.CursorLeft;

      //Cabecalho
      Console.SetCursorPosition((Rows / 2) - (15 / 2), 2);
      Console.Write("Jogo da Forca !");

      //Tries
      Console.SetCursorPosition(Rows - 1, 1);
      Console.Write($"{tries} ");

      //word
      Console.SetCursorPosition(((Rows / 2) - (word.Count / 2)) - 1, 5);
      for (int i = 0; i < word.Count; i++)
      {
        Console.Write($"{word[i]} ");
      }

      //tip
      var stringParaMedir = $"A dica é: {tip}";
      Console.SetCursorPosition((Rows / 2) - (stringParaMedir.Length / 2), 8);
      Console.Write($"A dica é: {tip}");

      Console.SetCursorPosition(origCol, origRow);

      Game.GetLetter();
    }
  }
}