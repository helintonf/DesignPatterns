using System;

namespace Adapter.fachada
{
    internal class TheaterLights
    {
        internal void Dim(int v)
        {
            Console.WriteLine("Dim set on." + v);
        }

        internal void On()
        {
            Console.WriteLine("lights on.");
        }
    }
}