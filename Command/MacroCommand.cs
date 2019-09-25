using System;

namespace Command
{
    internal class MacroCommand : Command
    {
        public Command[] Commands { get; set; }

        public MacroCommand(Command[] commands)
        {
            Commands = commands;
        }

        public void Execute()
        {
            for (int i = 0; i < Commands.Length; i++)
            {
                Commands[i].Execute();
            }
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}