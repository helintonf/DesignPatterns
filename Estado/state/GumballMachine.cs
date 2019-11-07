using System;

namespace Estado.state
{
    public class GumballMachine
    {
        public NoQuarterState NoQuarterState { get; set; }
        public SoldOutState SoldOutState { get; set; }
        public HasQuarterState HasQuarterState { get; set; }
        public SoldState SoldState { get; set; }
        public WinnerState WinnerState { get; set; }

        public GumballMachine(int count)
        {
            NoQuarterState = new NoQuarterState(this);
            SoldOutState = new SoldOutState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            Count = count;
            if (count > 0)
                State = NoQuarterState;
            else
                State = SoldOutState;
        }

        public State State { get; set; }

        public int Count { get; set; }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot");

            if (Count != 0)
                Count -= 1;
        }

        public override string ToString()
        {
            return $@"Quantidade: {Count} - Estado: {State.GetType().Name}";
        }
    }
}