using System;

namespace Estrategia
{
    public class Squeak : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Squeak!!!");
        }
    }
}