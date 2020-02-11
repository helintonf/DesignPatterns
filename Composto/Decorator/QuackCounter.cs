using System;

namespace Composto
{
    internal class QuackCounter : IQuackable
    {
        public Observable Observable { get; set; }

        public IQuackable Duck { get; set; }
        public static int NumberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            Duck = duck;
            Observable = new Observable(Duck);
        }

        public void Quack()
        {
            Duck.Quack();
            NumberOfQuacks++;
        }

        public void RegisterObserver(IObserver observer)
        {
            Observable.RegisterObserver(observer);
        }

        public void NotifyObervers()
        {
            Observable.NotifyObervers();
        }
    }
}