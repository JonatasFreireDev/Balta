using System;
using System.Collections.Generic;

namespace JogoDaForca
{
  public class Print
  {
    public static short Rows { get; set; }
    public static short Columns { get; set; }

    private static void LayoutDraw()
    {
      Rows = 8;
      Columns = 40;

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
      LayoutDraw();
      int origRow = Console.CursorTop;
      int origCol = Console.CursorLeft;

      //Cabecalho
      Console.SetCursorPosition((Columns / 2) - (15 / 2), 2);
      Console.Write("Jogo da Forca !");

      //Tries
      Console.SetCursorPosition(Columns - 1, 1);
      Console.Write($"{tries} ");

      //word
      Console.SetCursorPosition(((Columns / 2) - (word.Count / 2)) - 1, 5);
      for (int i = 0; i < word.Count; i++)
      {
        Console.Write($"{word[i]} ");
      }

      //tip
      var stringParaMedir = $"A dica é: {tip}";
      Console.SetCursorPosition((Columns / 2) - (stringParaMedir.Length / 2), 8);
      Console.Write($"A dica é: {tip}");

      Console.SetCursorPosition(origCol, origRow);

      Game.GetLetter();
    }

    public static void MenuWriteText()
    {
      LayoutDraw();

      int origRow = Console.CursorTop;
      int origCol = Console.CursorLeft;

      //Cabecalho
      Console.SetCursorPosition((Columns / 2) - (15 / 2), 2);
      Console.Write("Jogo da Forca !");

      //Corpo
      Console.SetCursorPosition((Columns / 2) - 7, 4);
      Console.Write("1 - Jogar ");
      Console.SetCursorPosition((Columns / 2) - 7, 5);
      Console.Write("2 - Palavras");
      Console.SetCursorPosition((Columns / 2) - 7, 6);
      Console.Write("3 - Sair");

      Console.SetCursorPosition(origCol, origRow);
    }

    public static void WordsMenuText()
    {
      LayoutDraw();

      int origRow = Console.CursorTop;
      int origCol = Console.CursorLeft;

      //Cabecalho
      Console.SetCursorPosition((Columns / 2) - (15 / 2), 2);
      Console.Write("Jogo da Forca !");

      //Corpo
      Console.SetCursorPosition((Columns / 2) - 15, 4);
      Console.Write("1 - Adicionar uma palavra");
      Console.SetCursorPosition((Columns / 2) - 15, 5);
      Console.Write("2 - Remover ultima palavra add");
      Console.SetCursorPosition((Columns / 2) - 15, 6);
      Console.Write("3 - Voltar");

      Console.SetCursorPosition(origCol, origRow);
    }

    public static void AddWordsMenuText()
    {
      LayoutDraw();

      //Cabecalho
      Console.SetCursorPosition((Columns / 2) - (15 / 2), 2);
      Console.Write("Jogo da Forca !");

      //Corpo
      Console.SetCursorPosition((Columns / 2) - (12 / 2), 4);
      Console.Write("dica-palavra");
      Console.SetCursorPosition((Columns / 2) - (23 / 2), 6);
      Console.Write("Insira uma dica-palavra");
      Console.SetCursorPosition((Columns / 2) - (23 / 2), 7);
      Console.Write("^ como descrito acima ^");
      Console.SetCursorPosition((Columns / 2) - 10, 8);
    }

    public static void RemoveWordMenuText()
    {
      LayoutDraw();

      int origRow = Console.CursorTop;
      int origCol = Console.CursorLeft;

      //Cabecalho
      Console.SetCursorPosition((Columns / 2) - (12 / 2), 4);
      Console.Write("Removido com");
      Console.SetCursorPosition((Columns / 2) - (7 / 2), 5);
      Console.Write("Sucesso");

      Console.SetCursorPosition(origCol, origRow);
    }

    public static void WinText()
    {
      LayoutDraw();

      int origRow = Console.CursorTop;
      int origCol = Console.CursorLeft;

      //Cabecalho
      Console.SetCursorPosition((Columns / 2) - (16 / 2), 3);
      Console.Write(@"\o/ Parabéns \o/");

      //Corpo
      Console.SetCursorPosition((Columns / 2) - (17 / 2), 5);
      Console.Write("Voce sobreviveu !");

      Console.SetCursorPosition(origCol, origRow);
    }

    public static void LoseText()
    {
      LayoutDraw();

      int origRow = Console.CursorTop;
      int origCol = Console.CursorLeft;

      //Cabecalho
      Console.SetCursorPosition((Columns / 2) - (15 / 2), 3);
      Console.Write("Infelizmente...");

      //Corpo
      Console.SetCursorPosition((Columns / 2) - (20 / 2), 5);
      Console.Write("Voce foi inforcado!!");
      Console.SetCursorPosition((Columns / 2) - (4 / 2), 6);
      Console.Write("O.o");

      Console.SetCursorPosition(origCol, origRow);
    }

    public static void AddWordsSuccessMenuText()
    {
      LayoutDraw();

      int origRow = Console.CursorTop;
      int origCol = Console.CursorLeft;

      //Cabecalho
      Console.SetCursorPosition((Columns / 2) - (7 / 2), 3);
      Console.Write("Sucesso");

      //Corpo
      Console.SetCursorPosition((Columns / 2) - (17 / 2), 5);
      Console.Write("Palavra inserida!");

      Console.SetCursorPosition(origCol, origRow);
    }

    public static void ErrorText(string errorMessage)
    {
      LayoutDraw();

      int origRow = Console.CursorTop;
      int origCol = Console.CursorLeft;

      //Cabecalho
      Console.SetCursorPosition((Columns / 2) - (15 / 2), 3);
      Console.Write("Ocorreu um erro !");

      //Corpo
      Console.SetCursorPosition((Columns / 2) - (errorMessage.Length / 2), 5);
      Console.Write($"{errorMessage}");

      Console.SetCursorPosition(origCol, origRow);
    }
  }
}