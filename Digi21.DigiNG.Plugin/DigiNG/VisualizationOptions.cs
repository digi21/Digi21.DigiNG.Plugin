using System.Drawing;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG
{
    public sealed class VisualizationOptions
    {
        public double Overlap { get; set; }
        public bool ShowPatternInPhotogrammetricWindow { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public double DrawingScale { get; set; }
        public bool ShowPattern { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public bool ShowDeletedEntities { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public bool EnableShadows { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public bool ShowFillInPolygons { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public int CursorSize { get; set; }
        public Color BackgroundColor { get; set; }
    }
}
