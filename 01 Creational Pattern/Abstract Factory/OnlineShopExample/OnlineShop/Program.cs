using OnlineShop;
using OnlineShop.Factory;

class program
{
    static void Main(string[] args)
    {
        Test();
    }

    static void Client()
    {

        Console.WriteLine();
    }

    static void Operate(IShopFactory operation)
    {
        var factory = new Application(operation);
    }
}


/*
 * فروشگاه آنلاین 
 * هدف:
 *     سیستم‌هایی برای پردازش پرداخت‌ها، ایجاد فاکتورها و مدیریت سبد خرید
* نوع پرداخت :
1- کارت اعتباری
2- پی پال
3- ارز دیجیتال
 */
