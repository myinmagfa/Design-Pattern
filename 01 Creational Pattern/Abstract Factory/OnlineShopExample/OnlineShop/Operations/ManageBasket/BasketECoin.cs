using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Factory;

namespace OnlineShop.Operations.ManageBasket
{
    public class BasketECoin:IECoin
    {
        public void Execute()
        {
            Console.WriteLine("Manage Basket with E-Coin");
        }
    }
}
