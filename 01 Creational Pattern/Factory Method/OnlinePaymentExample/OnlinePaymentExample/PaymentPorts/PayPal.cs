using OnlinePaymentExample.Base;

namespace OnlinePaymentExample.PaymentPorts;

public class PayPal : IPaymentPort
{
    public void CreatePort()
    {
        Console.WriteLine("You Paid with PayPal Port.");
    }
}