using System;

namespace Command
{
    internal class Ventilador
    {
        public string Location { get; set; }
        public Speed Speed { get; set; }

        public Ventilador(string location)
        {
            Location = location;
            Speed = Speed.OFF;
        }

        public void Off()
        {
            Speed = Speed.OFF;
            Console.WriteLine("Speed Off");
        }

        public void Low()
        {
            Speed = Speed.LOW;
            Console.WriteLine("Speed Low");
        }

        public void Medium()
        {
            Speed = Speed.MEDIUM;
            Console.WriteLine("Speed Medium");
        }

        public void High()
        {
            Speed = Speed.HIGH;
            Console.WriteLine("Speed High");
        }
    }

    public enum Speed
    {
        OFF,
        LOW,
        MEDIUM,
        HIGH,
    }
}