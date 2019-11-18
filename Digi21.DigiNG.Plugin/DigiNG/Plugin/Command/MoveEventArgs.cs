using Digi21.Math;
using System;

namespace Digi21.DigiNG.Plugin.Command
{
    public class MoveEventArgs : EventArgs
    {
        public MoveEventArgs(Point3D coordinates, Button button) { throw null; }

        public Button Button { get; }
        public Point3D Coordinates { get; }
    }
}
