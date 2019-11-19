using Digi21.Math;

namespace Digi21.DigiNG
{
    public sealed class InputDeviceOptions
    {
        public bool AutoPanningPhotogrammetricWindow { get; set; }
        public bool AutoPanningMouse { get; set; }
        public Point3D OriginalPosition { get; }
        public Point3D Position { get; }
        public InputDevice InputDevice { get; set; }
        public bool LockZ { get; set; }
        public bool LockXY { get; set; }
    }
}
