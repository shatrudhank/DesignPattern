using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignpattern.Observer
{
    internal class SMSObserver : NotificationObserver
    {
        public void Notify()
        {
            Console.WriteLine("SMS Sent");
        }
    }
}
