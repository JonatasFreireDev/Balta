namespace PaymentContext.Domain.Entities
{
  public class BoletoPayment : Payment
  {
    public BoletoPayment(string email,
                         string boletoNumber,
                         DateTime paidDate,
                         DateTime expireDate,
                         decimal total,
                         decimal totalPaid,
                         string payer,
                         string document,
                         string address)
                         : base(paidDate,
                             expireDate,
                             total,
                             totalPaid,
                             payer,
                             document,
                             address)
    {
      Email = email;
      BoletoNumber = boletoNumber;
    }

    public string BarCode { get; private set; }
    public string Email { get; private set; }
    public string BoletoNumber { get; private set; }
  }
}