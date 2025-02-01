using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Factory;
using OnlineShop.Operations.ManageBasket;

namespace OnlineShop.Operations.ManageCart
{
    public class CartFactory : IShopFactory
    {
        public ICreditCart SelectCreditCart()
        {
            return new BasketCreditCart();
        }

        public IPayPal SelectPayPal()
        {
            return new BasketPayPal();
        }

        public IECoin SelectECoin()
        {
            return new BasketECoin();
        }
    }
}
