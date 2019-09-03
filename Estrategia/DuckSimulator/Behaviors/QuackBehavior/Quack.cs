using System;

namespace Estrategia
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack!!!");
        }
    }
}