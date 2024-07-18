using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class ExtraCheese : ToppingDecorator
    {
        public ExtraCheese(BasePizza basePizza)
        {
            this.basePizza=basePizza;
        }
        public override int CalculatePrice()
        {
            return 20 +this.basePizza.CalculatePrice();
        }
    }
}
