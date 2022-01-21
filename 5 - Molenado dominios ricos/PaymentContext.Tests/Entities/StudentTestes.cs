using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests;

[TestClass]
public class StudentsTests
{
  [TestMethod]
  public void TestMethod1()
  {
    var students = new Student(
      "Teste",
      "10",
      "teste",
      "teste"
    );
  }
}