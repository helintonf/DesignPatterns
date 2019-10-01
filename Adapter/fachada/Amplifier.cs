using System;

namespace Adapter.fachada
{
    internal class Amplifier
    {
        public DvdPlayer Dvd { get; internal set; }
        public int Volume { get; internal set; }

        internal void On()
        {
            Console.WriteLine("Amlifier on.");
        }

        internal void SetSurroundSound()
        {
            Console.WriteLine("Surround on.");
        }

        internal void Off()
        {
            Console.WriteLine("Amlifier off.");
        }
    }
}