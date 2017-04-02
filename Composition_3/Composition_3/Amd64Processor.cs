using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_3
{
    public class Amd64Processor : IProcessor
    {
        public void Process()
        {
            Console.WriteLine("Amd64Processor is used");
        }
    }
}
