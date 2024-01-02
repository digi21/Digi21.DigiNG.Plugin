using Digi21.Digi3D;
using Digi21.Math;
using System.Drawing;
using Digi21.Tasks;

namespace Digi21.DigiNG.Plugin.TaskPanel
{
    public class TaskGotoPoint : TaskBase
    {
        public TaskGotoPoint() => throw null;
        public TaskGotoPoint(Point3D coordinates, string title, TaskSeverity severity) => throw null;
        public TaskGotoPoint(Point3D coordinates, Color color, int size, string title, TaskSeverity severity) => throw null;
        public TaskGotoPoint(Point3D coordinates, string title, TaskSeverity severity, string drawingFile, string module) => throw null;
        public TaskGotoPoint(Point3D coordinates, string title, TaskSeverity severity, string drawingFile, string module, ITask[] childs) => throw null;
        public TaskGotoPoint(Point3D coordinates, Color color, int size, string title, TaskSeverity severity, string drawingFile, string module) => throw null;
        public TaskGotoPoint(Point3D coordinates, Color color, int size, string title, TaskSeverity severity, string drawingFile, string module, ITask[] childs) => throw null;
        public override void Execute() => throw null;

        public int Size { get; set; }
        public Color Color { get; set; }

        public Point3D GetCoordinates() => throw null;
        public void SetCoordinates(Point3D value) => throw null;
    }
}
