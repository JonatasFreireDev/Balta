using _2___Orientação_a_Objetos.ContentContext.Enums;
using _2___Orientação_a_Objetos.SharedContext;

namespace _2___Orientação_a_Objetos.ContentContext
{
  public class Lecture : Base
  {
    public int Order { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
  }
}