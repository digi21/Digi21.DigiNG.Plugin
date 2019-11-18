using Digi21.DigiNG.Plugin.Command;

namespace Digi21.DigiNG
{
    public class Commands
    {
        public void AddToHistorical(string command) { throw null; }
        public bool Pop() { throw null; }
        public void Push(string command) { throw null; }
        public void Push(string command, bool allowRepeat) { throw null; }

        public bool AllowRepeat { get; set; }
        public bool LockRepeat { get; set; }
        public ICommand Top { get; }
        public bool ExecuteCommandsWhenReady { get; set; }
    }
}
