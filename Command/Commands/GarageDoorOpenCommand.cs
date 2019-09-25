namespace Command
{
    internal class GarageDoorOpenCommand : Command
    {
        public GarageDoor GarageDoor { get; set; }

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public void Execute()
        {
            GarageDoor.Up();
        }

        public void Undo()
        {
            GarageDoor.Down();
        }
    }
}