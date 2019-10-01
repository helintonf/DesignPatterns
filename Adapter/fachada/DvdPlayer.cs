using System;

namespace Adapter.fachada
{
    internal class DvdPlayer
    {
        internal void On()
        {
            Console.WriteLine("DVD Player on.");
        }

        internal void Play(string movie)
        {
            Console.WriteLine("DVD Player played.");
        }

        internal void Stop()
        {
            Console.WriteLine("DVD Player stop.");
        }

        internal void Eject()
        {
            Console.WriteLine("DVD Player ejected.");
        }

        internal void Off()
        {
            Console.WriteLine("DVD Player off.");
        }
    }
}