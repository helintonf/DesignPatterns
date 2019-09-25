using System;

namespace Command
{
    public class StereoOnWithCDCommand : Command
    {
        public Stereo Stereo { get; set; }

        public StereoOnWithCDCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Execute()
        {
            Stereo.On();
        }

        public void Undo()
        {
            Stereo.Off();
        }
    }
}