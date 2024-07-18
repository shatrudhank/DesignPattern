using StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class AxisBank : Bank
    {
        private IPaymentStrategy _strategy;
        public AxisBank(IPaymentStrategy strategy)
        {
            this._strategy = strategy;
        }

        public override void DoPayment()
        {
            this._strategy.DoPayment();
        }
    }
}
