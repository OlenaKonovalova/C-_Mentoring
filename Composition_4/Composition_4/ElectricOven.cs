using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_4
{
    public class ElectricOven : IBakeFunc
    {
        public OvenType ovenType
        {
            get
            {
                return OvenType.Electric;
            }
        }

        public void Bake()
        {
            Console.WriteLine("This device can bake");
        }
    }
}
