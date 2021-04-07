using Digi21.DigiNG.Entities;
using Digi21.Math;
using System;

namespace Digi21.DigiNG.Plugin.Command
{
    public class EntitySelectedEventArgs : EventArgs
    {
        public EntitySelectedEventArgs(Entity entity, Point3D groundPoint, int firstVertex, int secondVertex) => throw null;

        public int SecondVertex => throw null;
        public int FirstVertex => throw null;
        public Point3D Coordinates => throw null;
        public Entity Entity => throw null;
    }
}
