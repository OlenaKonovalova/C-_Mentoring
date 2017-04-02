using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_3
{
    public class Joystick : IInput
    {
        public void GetInput()
        {
            Console.WriteLine("Clicked with th joystick");
        }
    }
}
