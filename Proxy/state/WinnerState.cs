using System;

namespace Estado.state
{
    public class WinnerState : State
    {
        private readonly GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! You get two gumballs for your quarter");

            if (gumballMachine.Count == 0)
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.State = gumballMachine.SoldOutState;
            }
            else
            {
                gumballMachine.ReleaseBall();
                if (gumballMachine.Count > 0)
                {
                    gumballMachine.ReleaseBall();
                    gumballMachine.State = gumballMachine.NoQuarterState;
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    gumballMachine.State = gumballMachine.SoldOutState;
                }
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