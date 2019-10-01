using System;

namespace Adapter.fachada
{
    internal class Projetor
    {
        internal void On()
        {
            Console.WriteLine("Projetor on.");
        }

        internal void WideScreenMode()
        {
            Console.WriteLine("Projetor set widescreen mode.");
        }

        internal void Off()
        {
            Console.WriteLine("Projetor off.");
        }
    }
}