using System;

namespace Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void GoDuck()
        {
            Duck mallard = new MallardDuck();

            mallard.Fly();
            mallard.Quack();

            Duck model = new ModelDuck();
            model.Fly();
            model.flyBehavior = new FlyRocketPowered();
            model.Fly();


        }

        public void GoGame()
        {
            King king = new King(new SwordBehavior());

            king.Fight();

            king.weapon = new AxeBehavior();

            king.Fight();

            king.weapon = new KnifeBehavior();

            king.Fight();
        }
    }
}
