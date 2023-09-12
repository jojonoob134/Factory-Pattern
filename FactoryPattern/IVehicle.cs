using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IVehicle
    {
        public abstract void NumOfTiers();

        public string Discription { set; get; }

        public string Name { set; get; }
    }
}
