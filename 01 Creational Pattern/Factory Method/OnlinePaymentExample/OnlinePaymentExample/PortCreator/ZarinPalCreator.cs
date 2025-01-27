using OnlinePaymentExample.Base;
using OnlinePaymentExample.PaymentPorts;

namespace OnlinePaymentExample.PortCreator;

public class ZarinPalCreator : Creator
{
    public override IPaymentPort FactoryMethod()
    {
        return new ZarinPal();
    }
}