using OnlinePaymentExample.Base;
using OnlinePaymentExample.PortCreator;

namespace OnlinePaymentExample;

internal class Program
{
    private static void Main(string[] args)
    {
        new Client().Main();
    }
}

internal class Client
{
    public void Main()
    {
        CreateHandler(new ZarinPalCreator());
        CreateHandler(new PayPalCreator());
        CreateHandler(new ShaparakCreator());
    }

    public void CreateHandler(Creator creator)
    {
        creator.CreatePort();
        Console.WriteLine();
    }
}