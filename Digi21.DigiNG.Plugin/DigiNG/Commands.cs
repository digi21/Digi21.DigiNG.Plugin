using System.Runtime.InteropServices;
using System.Windows.Input;

namespace Digi21.DigiNG
{
    public class Commands
    {
        public void AddToHistorical(string command) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public bool Pop() { throw null; }
        public void Push(string command) { throw null; }
        public void Push(string command, [MarshalAs(UnmanagedType.U1)] bool allowRepeat) { throw null; }

        public bool AllowRepeat { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public bool LockRepeat { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public ICommand Top { get; }
        public bool ExecuteCommandsWhenReady { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
    }
}
