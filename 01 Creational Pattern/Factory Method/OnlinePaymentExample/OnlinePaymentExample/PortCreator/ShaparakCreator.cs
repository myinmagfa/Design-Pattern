using OnlinePaymentExample.Base;
using OnlinePaymentExample.PaymentPorts;

namespace OnlinePaymentExample.PortCreator;

public class ShaparakCreator : Creator
{
    public override IPaymentPort FactoryMethod()
    {
        return new Shaparak();
    }
}