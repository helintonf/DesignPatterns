using System;

namespace Command
{
    internal class VentiladorHighCommand : Command
    {
        public Ventilador Ventilador { get; set; }
        public Speed PrevSpeed { get; set; }

        public VentiladorHighCommand(Ventilador ventilador)
        {
            Ventilador = ventilador;
        }

        public void Execute()
        {
            PrevSpeed = Ventilador.Speed;
            Ventilador.High();
        }

        public void Undo()
        {
            Ventilador.Speed = PrevSpeed;

            Console.WriteLine("UNDO - Speed " + PrevSpeed.ToString());
        }
    }
}