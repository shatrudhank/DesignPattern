using ObserverDesignpattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignpattern.Observable
{
    internal class IPhoneObservable : StockObservable
    {
        private List<NotificationObserver> _observers=new List<NotificationObserver>();
        int stockCount = 0;
        public void Add(NotificationObserver notificationObserver)
        {
            _observers.Add(notificationObserver);
        }

        public int GetStockCount()
        {
            return stockCount;
        }

        private void NotifySubscriber()
        {
            foreach (var notificationObserver in _observers)
            {
                notificationObserver.Notify();
            }
        }

        public void Remove(NotificationObserver notificationObserver)
        {
            _observers.Remove(notificationObserver);
        }

        public void SetStockCount(int newStock)
        {
            if(stockCount == 0) {
                NotifySubscriber();
            }
            stockCount += newStock;
        }

    }
}
