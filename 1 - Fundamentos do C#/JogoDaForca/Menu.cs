using System;

namespace JogoDaForca
{
  public static class Menu
  {
    public static void Show()
    {
      Print.MenuWriteText();

      Console.Write("Digite um numero: ");
      short choice = short.Parse(Console.ReadLine());

      switch (choice)
      {
        case 1: Game.PlayGame(); break;
        case 3: Environment.Exit(0); break;
        default: Show(); break;
      }
    }
  }
}