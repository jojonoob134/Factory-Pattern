using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(int choice)
        {
            switch (choice)
            {
                case 4:
                    return new Car();
                default:
                    return new Motercycle();
            }
        }
    }
}
