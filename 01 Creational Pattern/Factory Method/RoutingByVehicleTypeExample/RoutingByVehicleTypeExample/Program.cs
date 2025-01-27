using RoutingByVehicleTypeExample.Base;
using RoutingByVehicleTypeExample.Routing;

namespace RoutingByVehicleTypeExample;

internal class Program
{
    private static void Main(string[] args)
    {
        new Client().Main();
    }
}

internal class Client
{
    public void Main()
    {
        RouterHandler(new CarRoute());
        RouterHandler(new BikeRoute());
        RouterHandler(new WalkRoute());
    }

    public void RouterHandler(Router router)
    {
        router.RoutingBy();
        Console.WriteLine();
    }
}

//7. برنامه‌های نقشه و مسیریابی
//در یک اپلیکیشن مسیریابی، ممکن است بخواهید مسیرها را برای وسایل نقلیه مختلف(ماشین، دوچرخه، پیاده) محاسبه کنید.
// محاسبه مسیر هر نوع وسیله نقلیه.
// مثال: CarRoute, BikeRoute, WalkRoute.