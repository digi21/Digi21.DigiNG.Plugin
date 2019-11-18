using System.Runtime.InteropServices;

namespace Digi21.DigiNG
{
    public static class DigitizingLineOptions
    {
        public static bool SmoothLineWhenFinish { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public static bool ParalelizeLineWhenFinish { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public static bool GeneralizeLineWhenFinish { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public static bool CloseLineWhenFinish { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public static double AngularTolerance { get; set; }
        public static double ContinuousModeIncrement { get; set; }
        public static double GeneralizationTolerance { get; set; }
    }
}
