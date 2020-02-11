using System;

namespace Composto
{
    internal class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist: {duck} Just quacked.");
        }
    }
}