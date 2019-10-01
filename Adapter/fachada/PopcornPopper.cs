using System;

namespace Adapter.fachada
{
    internal class PopcornPopper
    {
        internal void On()
        {
            Console.WriteLine("Popper on.");
        }

        internal void Pop()
        {
            Console.WriteLine("Popper pop.");
        }

        internal void Off()
        {
            Console.WriteLine("Popper off.");
        }
    }
}