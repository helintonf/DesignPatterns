using System;

namespace Estrategia
{
    public class ModelDuck : Duck
    {

        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("i'm a model duck!");
        }
    }
}