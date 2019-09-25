using System;

namespace Command
{
    public class LightOffCommand : Command
    {
        public Light Light { get; set; }

        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.Off();
        }

        public void Undo()
        {
            Light.On();
        }
    }
}