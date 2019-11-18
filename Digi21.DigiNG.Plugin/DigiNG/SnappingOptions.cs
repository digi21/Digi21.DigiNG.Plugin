using System.Runtime.InteropServices;

namespace Digi21.DigiNG
{
    public static class SnappingOptions
    {
        public static bool GoToSnap { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public static bool Verify { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public static bool ExhaustiveAutosearchMode { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public static bool AutosearchMode { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public static bool InsertVertexWhenSnap { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public static bool CutLinesWhenSnap { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public static bool FinalizeLineWhenSnap { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
    }
}
