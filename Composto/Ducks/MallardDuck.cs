using System;

namespace Composto
{
    internal class MallardDuck : IQuackable
    {
        public Observable Observable { get; set; }

        public MallardDuck()
        {
            Observable = new Observable(this);
        }

        public void NotifyObervers()
        {
            Observable.NotifyObervers();
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObervers();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observable.RegisterObserver(observer);
        }
    }
}