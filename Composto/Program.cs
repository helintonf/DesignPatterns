using System;

namespace Composto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            Simulate(duckFactory);

            Console.WriteLine("Duck Simulator");
        }

        public static void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable readheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable duckRubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine($"Duck Simulator: With Composite - Flocks");

            Flock flockOfDucks = new Flock();

            flockOfDucks.Quackers.Add(readheadDuck);
            flockOfDucks.Quackers.Add(duckCall);
            flockOfDucks.Quackers.Add(duckRubberDuck);
            flockOfDucks.Quackers.Add(gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuackable mallardDuckOne = duckFactory.CreateMallardDuck();
            IQuackable mallardDuckTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardDuckThree = duckFactory.CreateMallardDuck();
            IQuackable mallardDuckFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Quackers.Add(mallardDuckOne);
            flockOfMallards.Quackers.Add(mallardDuckTwo);
            flockOfMallards.Quackers.Add(mallardDuckThree);
            flockOfMallards.Quackers.Add(mallardDuckFour);

            flockOfDucks.Quackers.Add(flockOfMallards);

            Console.WriteLine($"Duck Simulator: Whole Flock Simulation");

            Simulate(flockOfDucks);

            Console.WriteLine($"Duck Simulator: Mallard Flock Simulation");

            Simulate(flockOfMallards);

            Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
        }

        public static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}