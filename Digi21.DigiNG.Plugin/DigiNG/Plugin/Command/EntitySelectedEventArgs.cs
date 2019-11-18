using Digi21.DigiNG.Entities;
using Digi21.Math;
using System;

namespace Digi21.DigiNG.Plugin.Command
{
    public class EntitySelectedEventArgs : EventArgs
    {
        public EntitySelectedEventArgs(Entity entity, Point3D groundPoint, int firstVertex, int secondVertex) { throw null; }

        public int SecondVertex { get; }
        public int FirstVertex { get; }
        public Point3D Coordinates { get; }
        public Entity Entity { get; }
    }
}
