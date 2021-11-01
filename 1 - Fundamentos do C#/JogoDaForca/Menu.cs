using System;
using System.Threading;

namespace JogoDaForca
{
  public static class Menu
  {
    public static void MainMenu()
    {
      short? choice = null;

      Print.MenuWriteText();
      Console.Write("Digite um numero: ");

      try
      {
        choice = short.Parse(Console.ReadLine());
      }
      catch (Exception err)
      {
        ErrorHandling.HasError($"{err.Message}");
      }

      //if (choice.GetType() != typeof(int)) ErrorHandling.HasError("Digito digitado \n diferente de numero");

      switch (choice)
      {
        case 1: Game.PlayGame(); break;
        case 2: WordsMenu(); break;
        case 3: Environment.Exit(0); break;
        default: ErrorHandling.HasError("Opção invalida"); break;
      }
    }

    public static void WordsMenu()
    {
      Print.WordsMenuText();
      short? choice = null;
      Console.Write("Digite um numero: ");

      try
      {
        choice = short.Parse(Console.ReadLine());
      }
      catch (Exception err)
      {
        ErrorHandling.HasError($"{err.Message}");
      }

      switch (choice)
      {
        case 1: AddWordsMenu(); break;
        case 2: RemoveTextMenu(); break;
        case 3: MainMenu(); break;
        default: ErrorHandling.HasError("Opção invalida"); break;
      }
    }

    public static void AddWordsMenu()
    {
      Print.AddWordsMenuText();

      string word = Console.ReadLine();

      try
      {
        Archive.InsertWord(word);
      }
      catch (Exception err)
      {
        ErrorHandling.HasError(err.Message);
      }

      AddTextSuccessMenu();
    }

    private static void AddTextSuccessMenu()
    {
      Print.AddWordsSuccessMenuText();
      Thread.Sleep(3500);
      WordsMenu();
    }

    private static void RemoveTextMenu()
    {
      Print.RemoveWordMenuText();
      Thread.Sleep(3500);
      WordsMenu();
    }

    public static void YouLoseMenu()
    {
      Print.LoseText();
      Thread.Sleep(3500);
      Menu.MainMenu();
    }

    public static void YouWinMenu()
    {
      Print.WinText();
      Thread.Sleep(3500);
      Menu.MainMenu();
    }
  }
}