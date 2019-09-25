using System;

namespace Command
{
    internal class VentiladorMediumCommand : Command
    {
        public Ventilador Ventilador { get; set; }
        public Speed PrevSpeed { get; set; }

        public VentiladorMediumCommand(Ventilador ventilador)
        {
            Ventilador = ventilador;
        }

        public void Execute()
        {
            PrevSpeed = Ventilador.Speed;
            Ventilador.Medium();
        }

        public void Undo()
        {
            Ventilador.Speed = PrevSpeed;
            Console.WriteLine("UNDO - Speed " + PrevSpeed.ToString());
        }
    }
}