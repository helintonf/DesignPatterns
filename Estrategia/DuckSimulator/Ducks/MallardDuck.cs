using System;

namespace Estrategia
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}