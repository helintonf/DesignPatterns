using System;
using System.Collections.Generic;
using System.Text;

namespace Composto
{
    class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
