using Estado.state;
using System;

namespace Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Man man = new Man();

            man.Name = "helinton";

            var ownerProxy = GetOwnerProxy(man);

            Console.WriteLine(ownerProxy.Name);


        }

        public static void Monitor()
        {
            Console.WriteLine("Wellcome to Gumball Machine");

            Console.Write("Gumball Machine name: ");

            var name = Console.ReadLine();

            Console.Write("Gumball Machine inventory: ");

            var inventory = int.Parse(Console.ReadLine());

            GumballMachine gumballMachine = new GumballMachine(name, inventory);

            GumballMonitor gumballMonitor = new GumballMonitor(gumballMachine);

            gumballMonitor.Report();
        }

        public static Person GetOwnerProxy(Person person)
        {
           return  (Person)Activator.CreateInstance(typeof(OwnerInvocationHandler), person);
        }
    }
}