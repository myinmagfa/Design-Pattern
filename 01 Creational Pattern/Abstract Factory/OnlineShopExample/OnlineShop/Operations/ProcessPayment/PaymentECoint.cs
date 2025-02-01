using OnlineShop.Factory;

namespace OnlineShop.Operations.PaymentProcess
{
    public class PaymentECoint:IECoin
    {
        public void Execute()
        {
            Console.WriteLine("Process Payment with E-Coin");
        }
    }
}
