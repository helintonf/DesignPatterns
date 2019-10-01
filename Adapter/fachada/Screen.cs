using System;

namespace Adapter.fachada
{
    internal class Screen
    {
        internal void Down()
        {
            Console.WriteLine("Screen down.");
        }

        internal void Up()
        {
            Console.WriteLine("Screen up.");
        }
    }
}