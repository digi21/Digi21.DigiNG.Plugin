using Digi21.Math;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG
{
    public sealed class InputDeviceOptions
    {
        public bool AutoPanningPhotogrammetricWindow { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public bool AutoPanningMouse { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public Point3D OriginalPosition { get; }
        public Point3D Position { get; }
        public InputDevice InputDevice { get; set; }
        public bool LockZ { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public bool LockXY { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
    }
}
