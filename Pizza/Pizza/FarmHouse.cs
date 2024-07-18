using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class FarmHouse : BasePizza
    {
        public override int CalculatePrice()
        {
            return 100;
        }
    }
}
