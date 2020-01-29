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

            Console.WriteLine($"Duck Simulator");

            Simulate(mallardDuck);
            Simulate(readheadDuck);
            Simulate(duckCall);
            Simulate(duckRubberDuck);
            Simulate(gooseDuck);

            Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} times");
        }

        public static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}