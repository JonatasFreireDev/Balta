using System;
using _2___Orientação_a_Objetos.SharedContext;

namespace _2___Orientação_a_Objetos.SubscriptionContext
{
  public abstract class Subscription : Base
  {
    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsInactive => EndDate <= DateTime.Now;
  }
}