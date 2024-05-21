using ObserverDesignpattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignpattern.Observable
{
    internal interface StockObservable
    {
       void Add(NotificationObserver notificationObserver);
       void Remove(NotificationObserver notificationObserver);

        void SetStockCount(int count);

        int GetStockCount();

    }
}
