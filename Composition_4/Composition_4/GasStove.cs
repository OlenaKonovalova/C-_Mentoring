using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_4
{
    public class GasStove 
    {
        private ICookFunc _cookTop;
        private IBakeFunc _oven;

        public GasStove(ICookFunc cookTop, IBakeFunc oven)
        {
            if (cookTop.cookTopType != CookTopType.Gas || oven.ovenType != OvenType.Gas)
            {
                throw new ArgumentException("Stove type SHOULD be gas");
            }
            _cookTop = cookTop;
            _oven = oven;
        }

        public void Bake()
        {
            _oven.Bake();
        }

        public void Cook()
        {
            _cookTop.Cook();
        }
    }
}
