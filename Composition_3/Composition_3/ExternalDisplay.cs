using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_3
{
    public class ExternalDisplay : IDisplay
    {
        public void Display()
        {
            Console.WriteLine("Displayed on ExternalDisplay");
        }
    }
}
