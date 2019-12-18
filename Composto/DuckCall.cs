using System;

namespace Composto
{
    internal class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwack");
        }
    }
}