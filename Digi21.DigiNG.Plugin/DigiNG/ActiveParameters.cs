using System;
using Digi21.Math;

namespace Digi21.DigiNG
{
    public sealed class ActiveParameters
    {
        public double Equidistance { get; set; }
        public double TextHeight { get; set; }
        public double SecondaryActiveDistance { get; set; }
        public double PrincipalActiveDistance { get; set; }
        [Obsolete("This attribute is deprecated. Use Scale instead")]
        public double ActiveScale { get; set; }
        public Point3D Scale { get; set; }
        public double ActiveAngle { get; set; }
    }
}
