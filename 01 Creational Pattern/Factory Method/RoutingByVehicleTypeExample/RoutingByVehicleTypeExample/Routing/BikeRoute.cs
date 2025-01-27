using RoutingByVehicleTypeExample.Base;
using RoutingByVehicleTypeExample.VehicleType;

namespace RoutingByVehicleTypeExample.Routing;

public class BikeRoute : Router
{
    public override ITranspot FactoryMethod()
    {
        return new Bike();
    }
}