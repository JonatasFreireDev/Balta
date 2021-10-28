using System;

namespace Calculator
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

      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine(" 1 - Soma");
      Console.WriteLine(" 2 - Subtração");
      Console.WriteLine(" 3 - Divisão");
      Console.WriteLine(" 4 - Multiplicação");
      Console.WriteLine(" 5 - Sair");

      Console.WriteLine("-------------------");
      Console.WriteLine("Selecione uma opção");

      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Sair(); break;
        default: Menu(); break;
      }

    }

    public static void Sair()
    {
      System.Environment.Exit(0);
    }

    public static void Soma()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      float value1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float value2 = float.Parse(Console.ReadLine());

      float resultado = value1 + value2;
      Console.WriteLine($"O resultado da soma é: {resultado}");

      Console.ReadKey();
      Menu();
    }

    public static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      float value1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float value2 = float.Parse(Console.ReadLine());

      float resultado = value1 - value2;
      Console.WriteLine($"O resultado da subtracao é: {resultado}");

      Console.ReadKey();
      Menu();
    }

    public static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      float value1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float value2 = float.Parse(Console.ReadLine());

      float resultado = value1 / value2;
      Console.WriteLine($"O resultado da Divisao é: {resultado}");

      Console.ReadKey();
      Menu();
    }

    public static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor: ");
      float value1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float value2 = float.Parse(Console.ReadLine());

      float resultado = value1 * value2;
      Console.WriteLine($"O resultado da Multiplicação é: {resultado}");

      Console.ReadKey();
      Menu();
    }
  }
}
