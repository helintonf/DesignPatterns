using System;

namespace Composto
{
    internal class QuackCounter : IQuackable
    {
        public IQuackable Duck { get; set; }
        public static int NumberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            Duck = duck;
        }

        public void Quack()
        {
            Duck.Quack();
            NumberOfQuacks++;
        }
    }
}