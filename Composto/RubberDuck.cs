using System;

namespace Composto
{
    internal class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}