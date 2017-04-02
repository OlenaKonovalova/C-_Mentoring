using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_4
{
    public enum CookTopType
    {
        Gas,
        Electric
    }
    public interface ICookFunc
    {
        void Cook();

        CookTopType cookTopType { get; }
    }
}
