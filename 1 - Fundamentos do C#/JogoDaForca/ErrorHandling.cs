using System;
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
  }
}