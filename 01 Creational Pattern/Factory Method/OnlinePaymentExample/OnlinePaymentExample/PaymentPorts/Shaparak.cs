using OnlinePaymentExample.Base;

namespace OnlinePaymentExample.PaymentPorts;

public class Shaparak : IPaymentPort
{
    public void CreatePort()
    {
        Console.WriteLine("You Paid with Shaparak Port.");
    }
}