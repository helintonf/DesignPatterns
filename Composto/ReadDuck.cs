using System;

namespace Composto
{
    internal class ReadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}