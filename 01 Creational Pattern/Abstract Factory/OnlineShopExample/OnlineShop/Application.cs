using OnlineShop.Factory;

namespace OnlineShop
{
    public class Application
    {
        private readonly ICreditCart _creditCart;
        private readonly IECoin _eCoin;
        private readonly IPayPal _payPal;

        public Application(IShopFactory factory)
        {
            _creditCart=factory.SelectCreditCart();
            _eCoin=factory.SelectECoin();
            _payPal=factory.SelectPayPal();
        }

        public void Execute()
        {
            _creditCart.Execute();
            _eCoin.Execute();
            _payPal.Execute();
        }
    }
}
