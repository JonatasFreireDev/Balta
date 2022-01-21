using System;

namespace DataTest
{
  class Program
  {
    static void Main(string[] args)
    {
      var teste = DateTime.Now;
      Console.WriteLine(teste.Hour.ToString("d"));
      var newDate = teste.AddDays(3);
      Console.WriteLine(newDate);

      var teste2 = new TimeSpan(10, 10, 10, 10);
    }
  }
}
