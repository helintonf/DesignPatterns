namespace Command
{
    internal class RemoteControl
    {
        public Command[] OnCommands { get; set; }
        public Command[] OffCommands { get; set; }
        public Command UndoCommand { get; set; }

        public RemoteControl()
        {
            OnCommands = new Command[7];
            OffCommands = new Command[7];

            Command noCommand = new NoCommand();

            for (int i = 0; i < 7; i++)
            {
                OnCommands[i] = noCommand;
                OffCommands[i] = noCommand;
            }

            UndoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonPushed(int slot)
        {
            OnCommands[slot].Execute();
            UndoCommand = OnCommands[slot];
        }

        public void OffButtonPushed(int slot)
        {
            OffCommands[slot].Execute();
            UndoCommand = OffCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            UndoCommand.Undo();
        }

        public override string ToString()
        {
            string[] result = new string[OnCommands.Length];

            for (int i = 0; i < OnCommands.Length; i++)
            {
                result[i] = string.Join(',', $@"[slot {i + 1}] {OnCommands[i].GetType().Name} - {OffCommands[i].GetType().Name}");
            }

            return string.Join("\n", result);
        }
    }
}