using System;

namespace Command
{
    internal class VentiladorOffCommand : Command
    {
        public Ventilador Ventilador { get; set; }
        public Speed PrevSpeed { get; set; }

        public VentiladorOffCommand(Ventilador ventilador)
        {
            Ventilador = ventilador;
        }

        public void Execute()
        {
            PrevSpeed = Ventilador.Speed;
            Ventilador.Off();
        }

        public void Undo()
        {
            Ventilador.Speed = PrevSpeed;
            Console.WriteLine("UNDO - Speed " + PrevSpeed.ToString());
        }
    }
}