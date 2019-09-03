using System;

namespace Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Pizza World!");

            var nyStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.Order("cheese");
            Console.WriteLine($"Helinton ordered a {pizza.Name}");

            pizza = chicagoStore.Order("cheese");
            Console.WriteLine($"Helinton ordered a {pizza.Name}");
        }
    }
}