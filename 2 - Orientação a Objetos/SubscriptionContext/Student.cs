using System.Collections.Generic;
using System.Linq;
using _2___Orientação_a_Objetos.NotificationContext;
using _2___Orientação_a_Objetos.SharedContext;

namespace _2___Orientação_a_Objetos.SubscriptionContext
{
  public abstract class Student : Base
  {
    public Student()
    {
      Subscriptions = new List<Subscription>();
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; }
    public void CreateSubscription(Subscription sub)
    {
      if (IsPremium)
      {
        AddNotification(new Notification("Preminum", "O aluno já tem uma assinatura ativa"));
        return;
      }

      Subscriptions.Add(sub);
    }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
  }
}