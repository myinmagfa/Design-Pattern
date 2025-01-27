namespace RoutingByVehicleTypeExample.Base;

public abstract class Router
{
    public abstract ITranspot FactoryMethod();

    public void RoutingBy()
    {
        var router = FactoryMethod();
        router.Routing();
    }
}