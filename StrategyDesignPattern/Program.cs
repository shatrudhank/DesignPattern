using StrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new AxisBank(new UpiStrategy());
            bank.DoPayment();  //UPI Payment

            bank=new HdfcBank(new NetBankingStrategy());
            bank.DoPayment(); //Net banking payment

            bank = new HdfcBank(new UpiStrategy());
            bank.DoPayment(); //UPI Payment

            bank = new IciciBank(new UpiStrategy());
            bank.DoPayment(); //UPI Payment


        }
    }
}
