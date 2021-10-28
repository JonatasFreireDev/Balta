using System;
using System.Threading;

namespace Stopwatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }
    public static void Menu()
    {
      Console.Clear();
      Console.WriteLine("1 = De 1 até X");
      Console.WriteLine("2 = De X até 0");
      Console.WriteLine("3 = Sair");
      Console.WriteLine("Qual modelo voce quer ?");

      string data = Console.ReadLine();

      switch (data)
      {
        case "1":
          MenuToStart(1);
          break;
        case "2":
          MenuToStart(2);
          break;
        case "3":
          System.Environment.Exit(0);
          break;
        default:
          ShowError("Opção invalida");
          break;
      }
    }
    public static void MenuToStart(int chose)
    {
      Console.Clear();
      Console.WriteLine("S = Segundos => 10s = 10 segundos");
      Console.WriteLine("M = Minutos  => 1m  = 60 segundos");
      Console.WriteLine("0 = Voltar");
      Console.WriteLine("Quanto tempo deseja contar ?");

      string data = Console.ReadLine().ToLower();
      if (data == "0") Menu();
      if (data.Length == 1) ShowError("Foi informado apenas um caracter!");

      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));
      int multiplier = 1;

      if (type == 'm') multiplier = 60;
      if (time <= 0) ShowError("Tempo menor que 0!");
      if (time.GetType() != typeof(int)) ShowError("O tempo informado, não é um numero!");
      if (type.GetType() != typeof(char)) ShowError("O tipo informado, não é um caracter!");
      if (type != 'm' && type != 's') ShowError("Tipo de tempo invalido!");

      PreStart(time * multiplier, chose);
    }
    public static void PreStart(int time, int chose)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set... ");
      Thread.Sleep(1000);
      Console.WriteLine("Go!!! ");
      Thread.Sleep(2500);

      if (chose == 1) Start1ToX(time);
      if (chose == 2) StartXTo1(time);
      return;
    }
    public static void Start1ToX(int time)
    {
      int currentTime = 0;

      while (currentTime < time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine($"Contando... {currentTime}");
        Thread.Sleep(1000);
      }

      Console.Clear();
      Console.WriteLine("StopWatch finalizado :)");
      Thread.Sleep(2000);
      Menu();
    }
    public static void StartXTo1(int time)
    {
      for (int i = time; i >= 0; i--)
      {
        Console.Clear();
        Console.WriteLine($"Contando... {i}");
        Thread.Sleep(1000);
      }

      Console.Clear();
      Console.WriteLine("StopWatch finalizado :)");
      Thread.Sleep(2000);
      Menu();
    }
    public static void ShowError(string msg)
    {
      Console.Clear();
      Console.WriteLine($"Ocorreu um erro: {msg}");
      Thread.Sleep(4000);
      Menu();
    }
  }
}
