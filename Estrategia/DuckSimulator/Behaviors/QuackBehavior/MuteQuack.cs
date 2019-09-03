using System;

namespace Estrategia
{
    public class MuteQuack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}