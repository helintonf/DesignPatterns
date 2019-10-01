using Adapter.fachada;
using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Sendo adaptavel!");

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(new Amplifier(), new Tuner(), new DvdPlayer(), new CdPlayer(), new Projetor(), new TheaterLights(), new Screen(), new PopcornPopper());

            homeTheater.WatchMovie("Aladim");
            homeTheater.EndMovie();
        }

        public static void Adapter()
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();

            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("The Duck says...");
            TestDuck(duck);

            Console.WriteLine("The Turkey Adapter says...");
            TestDuck(turkeyAdapter);
        }

        public static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}