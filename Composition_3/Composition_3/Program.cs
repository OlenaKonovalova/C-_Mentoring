using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer_Samsung = new Computer(new KeyBoard(), new Projector(), new ArmProcessor());
            computer_Samsung.Work();

            var computer_Lenova = new Computer(new Joystick(), new BuiltInDisplay(), new Amd64Processor());
            computer_Lenova.Work();

            var computer_Mac = new Computer(new Mouse(), new ExternalDisplay(), new Amd64Processor());
            computer_Mac.Work();
        }
    }
}
