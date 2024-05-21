using ObserverDesignpattern.Observable;
using ObserverDesignpattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignpattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockObservable stockObservable = new IPhoneObservable();
            stockObservable.Add(new EmailObserver());
            stockObservable.Add(new SMSObserver());

            stockObservable.SetStockCount(1);
            stockObservable.SetStockCount(2);
            stockObservable.SetStockCount(3);
            Console.ReadLine();
        }
    }
}
