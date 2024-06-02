using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class FarmHouse : BasePizza
    {
        public override int CalculatePrice()
        {
            return 100;
        }
    }
}
