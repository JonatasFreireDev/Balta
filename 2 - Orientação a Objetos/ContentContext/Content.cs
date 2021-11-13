using System;
using _2___Orientação_a_Objetos.SharedContext;

namespace _2___Orientação_a_Objetos.ContentContext
{
  public abstract class Content : Base
  {
    public Content(string title, string url)
    {
      Title = title;
      Url = url;
    }

    public string Title { get; set; }
    public string Url { get; set; }
  }
}