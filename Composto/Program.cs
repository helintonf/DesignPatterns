using System;

namespace Composto
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuackable mallardDuck = new MallardDuck();
            IQuackable readheadDuck = new ReadDuck();
        }
    }
}
