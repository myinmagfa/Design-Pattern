using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoutingByVehicleTypeExample.Base;

namespace RoutingByVehicleTypeExample.VehicleType
{
    public class Bike:ITranspot
    {
        public void Routing()
        {
            Console.WriteLine("Routing by Bike");
        }
    }
}
