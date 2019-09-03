using System;

namespace Estrategia
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior { get; set; }
        public IQuackBehavior quackBehavior { get; set; }

        public Duck()
        {
        }

        public abstract void Display();

        public void Fly()
        {
            flyBehavior.Fly();
        }

        public void Quack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float!");
        }
    }
}