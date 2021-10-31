using System;

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
      //TODO
    }
  }
}