using System.Collections.Generic;

namespace Composto
{
    public class Observable : IQuackObservable
    {
        public List<IObserver> Observers { get; set; }

        public Observable(IQuackObservable duck)
        {
            Duck = duck;
        }

        public IQuackObservable Duck { get; set; }

        public void NotifyObervers()
        {
            var iterator = Observers.GetEnumerator();

            while (iterator.MoveNext())
            {
                var observer = iterator.Current;
                observer.Update(Duck);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }
    }
}