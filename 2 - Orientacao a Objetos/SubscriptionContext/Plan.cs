using _2___Orientação_a_Objetos.SharedContext;

namespace _2___Orientação_a_Objetos.SubscriptionContext
{
  public abstract class Plan : Base
  {
    public string Title { get; set; }
    public decimal Price { get; set; }

  }
}