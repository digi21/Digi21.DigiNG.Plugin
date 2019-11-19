using System.Drawing;

namespace Digi21.DigiNG
{
    public sealed class VisualizationOptions
    {
        public double Overlap { get; set; }
        public bool ShowPatternInPhotogrammetricWindow { get; set; }
        public double DrawingScale { get; set; }
        public bool ShowPattern { get; set; }
        public bool ShowDeletedEntities { get; set; }
        public bool EnableShadows { get; set; }
        public bool ShowFillInPolygons { get; set; }
        public int CursorSize { get; set; }
        public Color BackgroundColor { get; set; }
    }
}
