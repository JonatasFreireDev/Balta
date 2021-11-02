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
      var data = Archive.GetSomeWord();
      Tip = data[0];
      SecretWord = data[1];
      Tries = 3;
      Word = new();
      SetWord();
      Print.GameWriteText(Tip, Word, Tries);
      GetLetter();
    }

    public static void GetLetter()
    {
      bool hasWord = false;
      bool alreadyWin = true;
      char? letter = null;

      Console.Write("Digite uma letra: ");

      try
      {
        letter = char.Parse(Console.ReadLine());
      }
      catch
      {
        ErrorHandling.HasErrorInGame("Erro ao escolher uma letra", Tip, Word, Tries);
        return;
      }

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
      if (Tries == 0) Menu.YouLoseMenu();
      if (alreadyWin) Menu.YouWinMenu();

      Print.GameWriteText(Tip, Word, Tries);
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