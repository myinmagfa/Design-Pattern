using RoutingByVehicleTypeExample.Base;
using RoutingByVehicleTypeExample.VehicleType;

namespace RoutingByVehicleTypeExample.Routing;

public class CarRoute : Router
{
    public override ITranspot FactoryMethod()
    {
        return new Car();
    }
}