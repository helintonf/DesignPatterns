namespace Command
{
    /// <summary>
    /// Invocador
    /// </summary>
    internal class SimpleRemoteControl
    {
        public Command Slot { get; set; }

        public void PressButton()
        {
            Slot.Execute();
        }
    }
}