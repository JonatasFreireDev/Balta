using System;
using System.IO;
using System.Threading;

namespace TextEditor
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
      Console.WriteLine("O que voce deseja fazer ?");
      Console.WriteLine("1 - Abrir arquivo");
      Console.WriteLine("2 - Criar novo arquivo");
      Console.WriteLine("0 - Sair");
      short option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
      }
    }

    public static void Abrir()
    {
      Console.Clear();
      Console.WriteLine("Qual o caminho do arquivo?");
      string path = Console.ReadLine();

      using (var file = new StreamReader(path))
      {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
      }

      Console.WriteLine("");
      Console.ReadLine();
      Menu();
    }
    public static void Editar()
    {
      Console.Clear();
      Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
      Console.WriteLine("---------------------------------------");

      string text = "";

      do
      {
        text += Console.ReadLine();
        text += Environment.NewLine;
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Salvar(text);
    }

    public static void Salvar(string text)
    {
      Console.Clear();
      Console.WriteLine("AQual caminho para salvar o arquivo?");
      var path = Console.ReadLine();

      using (var file = new StreamWriter(path))
      {
        file.Write(text);
      }

      Console.WriteLine($"AArquivo {path} salvo com sucesso !");
      Thread.Sleep(3000);
      Menu();
    }
  }
}
