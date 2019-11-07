using System;

namespace Estado.state
{
    public class SoldState : State
    {
        private readonly GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            if (gumballMachine.Count == 0)
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.State = gumballMachine.SoldOutState;
            }
            else
            {
                gumballMachine.ReleaseBall();
                gumballMachine.State = gumballMachine.NoQuarterState;
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, w're already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice dosn't get you another gumball");
        }
    }
}