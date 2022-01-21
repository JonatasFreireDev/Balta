using System.Collections.Generic;
using _2___Orientação_a_Objetos.SharedContext;

namespace _2___Orientação_a_Objetos.ContentContext
{
  public class Module : Base
  {
    public Module()
    {
      Lectures = new List<Lecture>();
    }
    public int Order { get; set; }
    public string Title { get; set; }
    public IList<Lecture> Lectures { get; set; }

  }
}