using OnlineShop.Factory;

namespace OnlineShop.Operations.PaymentProcess
{
    public class PaymentCreditCart:ICreditCart
    {
        public void Execute()
        {
            Console.WriteLine("Process Payment with Credit Cart");
        }
    }
}
