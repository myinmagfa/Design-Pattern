using OnlineShop.Factory;

namespace OnlineShop.Operations.CreateInvoice;

public class InvoiceFactory : IShopFactory
{
    public ICreditCart SelectCreditCart()
    {
        return new InvoiceCreditCart();
    }

    public IPayPal SelectPayPal()
    {
        return new InvoicePayPal();
    }

    public IECoin SelectECoin()
    {
        return new InvoiceECoin();
    }
}