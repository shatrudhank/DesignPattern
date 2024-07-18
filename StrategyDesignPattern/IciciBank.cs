using StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class IciciBank : Bank
    {
        private IPaymentStrategy _strategy;
        public IciciBank(IPaymentStrategy strategy)
        {
            this._strategy = strategy;
        }
        public override void DoPayment()
        {
            this._strategy.DoPayment();
        }
    }
}
