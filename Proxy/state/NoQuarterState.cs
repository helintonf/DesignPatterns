using System;

namespace Estado.state
{
    public class NoQuarterState : State
    {
        private readonly GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.State = gumballMachine.HasQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned but there's no quarter");
        }
    }
}