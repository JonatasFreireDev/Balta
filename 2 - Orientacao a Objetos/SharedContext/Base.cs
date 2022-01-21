using System;
using _2___Orientação_a_Objetos.NotificationContext;

namespace _2___Orientação_a_Objetos.SharedContext
{
  public abstract class Base : Notifiable
  {
    public Guid Id { get; set; }
    public Base()
    {
      Id = Guid.NewGuid();
    }
  }
}