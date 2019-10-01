using System;

namespace Adapter
{
    internal class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}