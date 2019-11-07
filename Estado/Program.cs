using Estado.state;
using System;

namespace Estado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello State!");

            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);
            Console.WriteLine("");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            
            //Console.WriteLine(gumballMachine);
            //Console.WriteLine("");

            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();


            Console.WriteLine(gumballMachine);
            Console.WriteLine("");

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();


            Console.WriteLine(gumballMachine);
            Console.WriteLine("");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();


            Console.WriteLine(gumballMachine);
            Console.WriteLine("");

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);


        }


        public static void StateOld()
        {
            Console.WriteLine("Hello State!");

            GumballMachineOld gumballMachine = new GumballMachineOld(5);

            Console.WriteLine(gumballMachine);
            Console.WriteLine("");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();


            Console.WriteLine(gumballMachine);
            Console.WriteLine("");

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();


            Console.WriteLine(gumballMachine);
            Console.WriteLine("");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();


            Console.WriteLine(gumballMachine);
            Console.WriteLine("");

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);
        }
    }
}
