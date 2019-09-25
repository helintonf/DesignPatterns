using System;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Ventilador ventilador = new Ventilador("Sala");

            VentiladorHighCommand highCommand = new VentiladorHighCommand(ventilador);

            VentiladorMediumCommand mediumCommand = new VentiladorMediumCommand(ventilador);

            VentiladorOffCommand offCommand = new VentiladorOffCommand(ventilador);

            remoteControl.SetCommand(0, mediumCommand, offCommand);
            remoteControl.SetCommand(1, highCommand, offCommand);

            remoteControl.OnButtonPushed(0);

            remoteControl.OffButtonPushed(0);

            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonPushed(1);
            remoteControl.UndoButtonWasPushed();

            Console.Write(remoteControl.ToString());
        }

        public void Undo()
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light();

            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            remoteControl.SetCommand(0, lightOn, lightOff);

            remoteControl.OnButtonPushed(0);
            remoteControl.OffButtonPushed(0);

            remoteControl.UndoButtonWasPushed();

            Console.Write(remoteControl.ToString());
        }

        public void ExecuteSimple()
        {
            SimpleRemoteControl remoteControl = new SimpleRemoteControl();

            Light light = new Light();

            LightOnCommand lightOn = new LightOnCommand(light);

            remoteControl.Slot = lightOn;

            remoteControl.PressButton();

            GarageDoor garageDoor = new GarageDoor();

            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

            remoteControl.Slot = garageDoorOpen;

            remoteControl.PressButton();
        }
    }
}