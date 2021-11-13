using System.Collections.Generic;
using System.Linq;

namespace _2___Orientação_a_Objetos.NotificationContext
{
  public abstract class Notifiable
  {
    public List<Notification> Notifications { get; set; }
    public bool IsInvalid => Notifications.Any();

    public Notifiable()
    {
      Notifications = new List<Notification>();
    }

    public void AddNotification(Notification notification)
    {
      Notifications.Add(notification);
    }
    public void AddNotifications(IEnumerable<Notification> notifications)
    {
      Notifications.AddRange(notifications);
    }
  }

}