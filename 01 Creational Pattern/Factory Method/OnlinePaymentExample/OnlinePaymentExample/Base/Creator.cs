namespace OnlinePaymentExample.Base;

public abstract class Creator
{
    public abstract IPaymentPort FactoryMethod();

    public void CreatePort()
    {
        var port = FactoryMethod();
        port.CreatePort();
    }
}