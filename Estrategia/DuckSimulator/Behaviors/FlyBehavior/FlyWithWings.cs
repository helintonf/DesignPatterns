using System;

namespace Estrategia
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with Wings!!!");
        }
    }
}