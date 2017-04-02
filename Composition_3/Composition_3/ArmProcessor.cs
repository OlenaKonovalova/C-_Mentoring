using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_3
{
    public class ArmProcessor : IProcessor
    {
        public void Process()
        {
            Console.WriteLine("ArmPocessor is used");
        }
    }
}
