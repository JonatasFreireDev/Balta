using System;
using System.Collections.Generic;
using System.Linq;
using _2___Orientação_a_Objetos.ContentContext;

namespace _2___Orientação_a_Objetos
{
  class Program
  {
    static void Main(string[] args)
    {
      var articles = new List<Article>();
      articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
      articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
      articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
      articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));

      // foreach (var article in articles)
      // {
      //   Console.WriteLine(article.Id);
      //   Console.WriteLine(article.Title);
      //   Console.WriteLine(article.Url);
      // }

      var course1 = new Course("Fundamentos OOP", "funtamentos-oop");
      var course2 = new Course("Fundamentos C#", "funtamentos-oop");
      var course3 = new Course("Fundamentos .NET", "funtamentos-oop");

      var courses = new List<Course>();

      courses.Add(course1);
      courses.Add(course2);
      courses.Add(course3);

      var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");

      var careerItem = new CareerItem(1, "Comece por aqui", "", course1);
      var careerItem2 = new CareerItem(2, "Comece por aqui", "", course2);

      var careers = new List<Career>();
      careerDotnet.Items.Add(careerItem);
      careerDotnet.Items.Add(careerItem2);
      careers.Add(careerDotnet);

      foreach (var career in careers)
      {
        Console.WriteLine(career.Title);
        foreach (var item in career.Items.OrderBy(x => x.Order))
        {
          Console.WriteLine($"{item.Order} - {item.Title}");
        }
      }

    }
  }
}
