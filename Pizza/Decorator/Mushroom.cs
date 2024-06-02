using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Decorator
{
    internal class Mushroom:ToppingDecorator
    {
        public Mushroom(BasePizza basePizza)
        {
            this.basePizza = basePizza;
        }

        public override int CalculatePrice()
        {
            return 30+this.basePizza.CalculatePrice();
        }
    }
}
