using System;

namespace Command
{
    public class LightOnCommand : Command
    {
        public Light Light { get; set; }

        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}