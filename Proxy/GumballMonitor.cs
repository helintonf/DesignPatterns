using System;

namespace Estado.state
{
    public class GumballMonitor
    {
        public GumballMachine Machine { get; set; }

        public GumballMonitor(GumballMachine gumballMachine)
        {
            Machine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine($@"Gumball Machine: {Machine.Location}");
            Console.WriteLine($@"Current iventory: {Machine.Count} gumballs");
            Console.WriteLine($@"Current state: {Machine.State.GetType().Name} gumballs");
        }
    }
}