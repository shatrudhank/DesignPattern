using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignpattern.Observer
{
    internal class EmailObserver : NotificationObserver
    {
        public void Notify()
        {
            Console.WriteLine("Email Sent");
        }
    }
}
