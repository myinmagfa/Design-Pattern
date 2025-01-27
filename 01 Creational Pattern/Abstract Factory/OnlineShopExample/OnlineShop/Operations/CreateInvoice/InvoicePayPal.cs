using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Factory;

namespace OnlineShop.Operations.CreateInvoice
{
    public class InvoicePayPal:IPayPal
    {
        public void Execute()
        {
            Console.WriteLine("Create Invoice By PayPal");
        }
    }
}
