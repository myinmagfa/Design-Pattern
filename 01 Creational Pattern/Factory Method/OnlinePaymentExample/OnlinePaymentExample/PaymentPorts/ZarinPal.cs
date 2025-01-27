using OnlinePaymentExample.Base;

namespace OnlinePaymentExample.PaymentPorts;

public class ZarinPal : IPaymentPort
{
    public void CreatePort()
    {
        Console.WriteLine("You Paid with ZarinPal Port.");
    }
}