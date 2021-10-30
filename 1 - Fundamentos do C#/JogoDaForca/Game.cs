using System;
using System.Collections.Generic;
using System.Threading;

namespace JogoDaForca
{
  public static class Game
  {
    public static string Tip { get; set; }
    public static List<char> Word { get; set; }
    public static string SecretWord { get; set; }
    public static short Tries { get; set; }

    public static void PlayGame()
    {
      //Init
      SecretWord = "Amor";
      Tip = "Teste";
      Tries = 3;
      Word = new();
      SetWord();

      Print.GamePrint(Tip, Word, Tries);
      GetLetter();
    }

    public static void GetLetter()
    {
      bool hasWord = false;
      bool alreadyWin = true;

      Console.Write("Digite uma letra: ");
      char letter = char.Parse(Console.ReadLine());

      for (int i = 0; i < SecretWord.Length; i++)
      {
        if (letter == SecretWord[i])
        {
          Word.Insert(i, SecretWord[i]);
          Word.RemoveAt(i + 1);
          hasWord = true;
        }
        if (SecretWord[i] != Word[i])
        {
          alreadyWin = false;
        }
      }

      if (!hasWord) Tries--;
      if (Tries == 0) YouLose();
      if (alreadyWin) YouWin();

      Print.GamePrint(Tip, Word, Tries);
    }

    private static void YouLose()
    {
      Console.Clear();
      Console.WriteLine("Voce foi inforcado !!");
      Thread.Sleep(2500);
    }

    private static void YouWin()
    {
      Console.Clear();
      Console.WriteLine(@"\o/ Parabens \o/");
      Thread.Sleep(2500);
    }

    private static void SetWord()
    {
      for (int i = 0; i < SecretWord.Length; i++)
      {
        Word.Add('_');
      }
    }
  }
}