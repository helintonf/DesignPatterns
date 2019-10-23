using System;

namespace Gabarito
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Preparando a bebida!");

            Coffee coffee = new Coffee();

            coffee.PrepareRecipe();
        }
    }
}