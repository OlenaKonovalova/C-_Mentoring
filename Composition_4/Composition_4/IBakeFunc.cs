using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_4
{
    public enum OvenType
    {
        Gas,
        Electric
    }
    public interface IBakeFunc
    {
        void Bake();

        OvenType ovenType { get; }
    }
}
