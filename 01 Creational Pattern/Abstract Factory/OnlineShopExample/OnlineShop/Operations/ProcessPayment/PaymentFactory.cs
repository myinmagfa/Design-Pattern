using OnlineShop.Factory;

namespace OnlineShop.Operations.PaymentProcess
{
    public class PaymentFactory:IShopFactory
    {
        public ICreditCart SelectCreditCart()
        {
            return new PaymentCreditCart();
        }

        public IPayPal SelectPayPal()
        {
            return new PaymentPayPal();
        }

        public IECoin SelectECoin()
        {
            return new PaymentECoint();
        }
    }
}
