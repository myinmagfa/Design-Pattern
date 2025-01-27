using RoutingByVehicleTypeExample.Base;
using RoutingByVehicleTypeExample.VehicleType;

namespace RoutingByVehicleTypeExample.Routing;

public class WalkRoute : Router
{
    public override ITranspot FactoryMethod()
    {
        return new Walk();
    }
}