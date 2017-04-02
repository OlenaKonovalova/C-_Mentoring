using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_3
{
    public class KeyBoard : IInput
    {
        public void GetInput()
        {
            Console.WriteLine("Enterd from the keyboard");
        }
    }
}
