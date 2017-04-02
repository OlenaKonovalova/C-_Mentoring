using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_4
{
    public class GasCookTop : ICookFunc
    {
        public CookTopType cookTopType
        {
            get
            {
                return CookTopType.Gas;
            }
        }

        public void Cook()
        {
            Console.WriteLine("This device can cook");
        }
    }
}
