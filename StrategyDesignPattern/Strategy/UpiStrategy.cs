using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Strategy
{
    internal class UpiStrategy : IPaymentStrategy
    {
        public void DoPayment()
        {
            Console.WriteLine("UPI Payment");
        }
    }
}
