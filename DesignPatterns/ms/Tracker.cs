using System;
using System.Collections.Generic;

namespace DesignPatterns.ms
{
    public class Tracker : IObservable<Location>
    {
        private List<IObserver<Location>> observers;

        public Tracker()
        {
            observers = new List<IObserver<Location>>();
        }

        public IDisposable Subscribe(IObserver<Location> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }

        public void Track(Location location)
        {
            foreach(var observer in observers)
            {
                if(location == null)
                {
                    observer.OnError(new Exception("No value!"));
                }
                else
                {
                    observer.OnNext(location);
                }
            }
        }
    }

    public class Unsubscriber : IDisposable
    {
        private List<IObserver<Location>> observers;
        private IObserver<Location> observer;

        public Unsubscriber(List<IObserver<Location>> observers, IObserver<Location> observer)
        {
            this.observer = observer;
            this.observers = observers;
        }

        public void Dispose()
        {
            if (observer != null && observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }
}