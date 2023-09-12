using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motercycle : IVehicle
    {
        public string Discription { get; set; } = "The one to go vroom vroom";
        public string Name { get; set; } = "The fast boi";

        public void NumOfTiers()
        {
            Console.WriteLine("This bad boy has 4 tiers");
        }
    }
}
