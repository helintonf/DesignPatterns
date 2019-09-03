using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var factory = ChocolateBoiler.GetInstance();
            var factory2 = ChocolateBoiler.GetInstance();

            factory.Boil();

            factory.Drain();

            factory.Fill();
        }
    }
}
