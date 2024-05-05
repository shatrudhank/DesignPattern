using StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class Bank
    {
        private IPaymentStrategy _strategy;

        public Bank(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public void DoPayment()
        {
            _strategy.DoPayment();
        }
    }
}
