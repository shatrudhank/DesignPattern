using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Strategy
{
    internal interface IPaymentStrategy
    {
        void DoPayment();
    }
}
