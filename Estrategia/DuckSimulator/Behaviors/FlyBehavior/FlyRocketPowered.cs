using System;

namespace Estrategia
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!!!");
        }
    }
}