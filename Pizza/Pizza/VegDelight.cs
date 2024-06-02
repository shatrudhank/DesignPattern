using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class VegDelight:BasePizza
    {
        public override int CalculatePrice()
        {
            return 120;
        }
    }
}
