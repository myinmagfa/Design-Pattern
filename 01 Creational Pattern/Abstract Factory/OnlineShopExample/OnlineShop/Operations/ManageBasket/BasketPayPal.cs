using OnlineShop.Factory;

namespace OnlineShop.Operations.ManageBasket
{
    public class BasketPayPal:IPayPal
    {
        public void Execute()
        {
            Console.WriteLine("Manage Basket with PayPal");
        }
    }
}
