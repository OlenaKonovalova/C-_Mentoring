using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_3
{
    public class Projector : IDisplay
    {
        public void Display()
        {
            Console.WriteLine("Displayed on Projector");
        }
    }
}
