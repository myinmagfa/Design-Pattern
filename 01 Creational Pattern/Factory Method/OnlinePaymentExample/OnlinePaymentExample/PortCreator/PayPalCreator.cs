using OnlinePaymentExample.Base;
using OnlinePaymentExample.PaymentPorts;

namespace OnlinePaymentExample.PortCreator;

public class PayPalCreator : Creator
{
    public override IPaymentPort FactoryMethod()
    {
        return new PayPal();
    }
}