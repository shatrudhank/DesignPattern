using StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class HdfcBank : Bank
    {
        public HdfcBank(IPaymentStrategy strategy):base(strategy) 
        {
            
        }
    }
}
