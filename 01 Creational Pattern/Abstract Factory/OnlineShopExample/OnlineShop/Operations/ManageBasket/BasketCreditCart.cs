using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Factory;

namespace OnlineShop.Operations.ManageCart
{
    public class BasketCreditCart:ICreditCart
    {
        public void Execute()
        {
            Console.WriteLine("Manage Basket with Credit Cart");
        }
    }
}
