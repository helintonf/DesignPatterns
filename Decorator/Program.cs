using System;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("StarbuzzCoffe!");

            Beverage beverage = new Expresso();

            Console.WriteLine("Expresso");
            Console.WriteLine($@"{beverage.GetDescription()}, $ {beverage.Cost()}");

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);

            Console.WriteLine("Dark");
            Console.WriteLine($@"{beverage1.GetDescription()}, $ {beverage1.Cost()}");

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);

            Console.WriteLine("HouseBlend");
            Console.WriteLine($@"{beverage2.GetDescription()}, $ {beverage2.Cost()}");

            Console.ReadKey();
        }
    }
}