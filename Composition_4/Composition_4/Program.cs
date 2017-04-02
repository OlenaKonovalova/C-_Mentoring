using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var gasStove = new GasStove(new GasCookTop(), new GasOven());

            var electricStove = new ElectricStove(new ElectricCookTop(), new ElectricOven());

            //var gasCooker = new GasStove(new ElectricCookTop(), new GasOven());
        }
    }
}
