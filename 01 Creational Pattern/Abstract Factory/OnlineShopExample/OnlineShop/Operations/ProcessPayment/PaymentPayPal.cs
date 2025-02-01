using OnlineShop.Factory;

namespace OnlineShop.Operations.PaymentProcess
{
    public class PaymentPayPal:IPayPal
    {
        public void Execute()
        {
            Console.WriteLine("Process Payment with PayPal");
        }
    }
}
