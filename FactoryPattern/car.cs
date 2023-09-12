using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public string Discription { get; set; } = "The clasic option for doing CRME";
        public string Name { get; set; } = "Crimemobeal 9000";

        public void NumOfTiers()
        {
            Console.WriteLine("This bad boy has 4 tiers");
        }
    }
}
