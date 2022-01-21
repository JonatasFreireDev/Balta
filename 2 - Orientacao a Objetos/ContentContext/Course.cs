using System.Collections.Generic;
using _2___Orientação_a_Objetos.ContentContext.Enums;

namespace _2___Orientação_a_Objetos.ContentContext
{
  public class Course : Content
  {
    public Course(string title, string url) : base(title, url)
    {
      Modules = new List<Module>();
    }
    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
  }
}