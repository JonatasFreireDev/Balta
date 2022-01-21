using System;
using System.Collections.Generic;
using System.Threading;

namespace JogoDaForca
{
  public static class ErrorHandling
  {
    public static void HasError(string errorMessage)
    {
      Print.ErrorText(errorMessage);
      Thread.Sleep(3500);
      Menu.MainMenu();
    }
    public static void HasErrorInGame(string errorMessage, string tip, IList<char> word, short tries)
    {
      Print.ErrorText(errorMessage);
      Thread.Sleep(2500);
      Print.GameWriteText(tip, word, tries);
    }
  }
}