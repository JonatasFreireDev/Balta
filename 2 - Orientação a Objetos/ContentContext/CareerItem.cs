using System;
using _2___Orientação_a_Objetos.NotificationContext;
using _2___Orientação_a_Objetos.SharedContext;

namespace _2___Orientação_a_Objetos.ContentContext
{
  public class CareerItem : Base
  {
    public CareerItem(int order, string title, string description, Course course)
    {
      if (course == null) AddNotification(new Notification("Course", "curso invalido"));
      Order = order;
      Title = title;
      Description = description;
      Course = course;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
  }
}