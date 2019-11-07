using System;

namespace Estado
{
    public enum State
    {
        SOLD_OUT = 0,
        NO_QUARTER = 1,
        HAS_QUARTER = 2,
        SOLD = 3
    }

    public class GumballMachineOld
    {
        public GumballMachineOld(int count)
        {
            Count = count;
            if (count > 0)
                State = State.NO_QUARTER;
            else
                State = State.SOLD_OUT;
        }

        public State State { get; set; }

        public int Count { get; set; }

        /// <summary>
        /// Inserção da moeda.
        /// </summary>
        public void InsertQuarter()
        {
            switch (State)
            {
                case State.HAS_QUARTER:
                    Console.WriteLine("You can't insert another quarter");
                    break;

                case State.NO_QUARTER:
                    State = State.HAS_QUARTER;
                    Console.WriteLine("You inserted a quarter");
                    break;

                case State.SOLD_OUT:
                    Console.WriteLine("You can't insert a quarter, the machine is sold out");
                    break;

                case State.SOLD:
                    Console.WriteLine("Please wait, w're already giving you a gumball");
                    break;
            }
        }

        /// <summary>
        /// Devolução da moeda.
        /// </summary>
        public void EjectQuarter()
        {
            switch (State)
            {
                case State.HAS_QUARTER:
                    Console.WriteLine("Quarter returned");
                    State = State.NO_QUARTER;
                    break;

                case State.NO_QUARTER:
                    //State = State.HAS_QUARTER;
                    Console.WriteLine("You haven't inserted a quarter");
                    break;

                case State.SOLD:
                    Console.WriteLine("Sorry, you already turned the crank");
                    break;

                case State.SOLD_OUT:
                    Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
                    break;
            }
        }

        /// <summary>
        /// Acionamento da alavanca.
        /// </summary>
        public void TurnCrank()
        {
            switch (State)
            {
                case State.HAS_QUARTER:
                    Console.WriteLine("You turned...");
                    State = State.SOLD;
                    Dispense();
                    break;

                case State.NO_QUARTER:
                    Console.WriteLine("You turned but there's no quarter");
                    break;

                case State.SOLD:
                    Console.WriteLine("Turning twice dosn't get you another gumball");
                    break;

                case State.SOLD_OUT:
                    Console.WriteLine("You turned, but there are no gumballs");
                    break;
            }
        }

        /// <summary>
        /// Entrega da goma.
        /// </summary>
        private void Dispense()
        {
            switch (State)
            {
                case State.HAS_QUARTER:
                    Console.WriteLine("No gumball dispensed");
                    break;

                case State.NO_QUARTER:
                    Console.WriteLine("You need to pay first");
                    break;

                case State.SOLD:
                    Console.WriteLine("A gumball comes rolling out the slot");
                    Count -= 1;
                    if (Count == 0)
                    {
                        Console.WriteLine("Oops, out of gumballs!");
                        State = State.SOLD_OUT;
                    }
                    else
                    {
                        State = State.NO_QUARTER;
                    }
                    break;

                case State.SOLD_OUT:
                    Console.WriteLine("No gumball dispensed");
                    break;
            }
        }

        public override string ToString()
        {
            return $@"Quantidade: {Count} - Estado: {State.ToString()}";
        }
    }
}