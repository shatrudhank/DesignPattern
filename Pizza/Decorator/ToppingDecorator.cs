using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Decorator
{
    public abstract class ToppingDecorator:BasePizza
    {
       public BasePizza basePizza { get; init; }
    }
}
