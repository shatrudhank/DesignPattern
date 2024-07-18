using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class Magherita: BasePizza
    {
        public override int CalculatePrice()
        {
            return 150;
        }
    }
}
