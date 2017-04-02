using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_4
{
    public class ElectricStove
    {
        private ICookFunc _cookTop;
        private IBakeFunc _oven;

        public ElectricStove(ICookFunc cookTop, IBakeFunc oven)
        {
            if (cookTop.cookTopType != CookTopType.Electric || oven.ovenType != OvenType.Electric)
            {
                throw new ArgumentException("Stove type SHOULD be electric");
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
