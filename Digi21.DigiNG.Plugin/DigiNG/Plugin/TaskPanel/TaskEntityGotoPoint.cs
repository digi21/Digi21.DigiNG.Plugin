using Digi21.Digi3D;
using Digi21.DigiNG.Entities;
using Digi21.Math;
using System.Drawing;

namespace Digi21.DigiNG.Plugin.TaskPanel
{
    public class TaskEntityGotoPoint : TaskGotoPoint
    {
        public TaskEntityGotoPoint() => throw null;
        public TaskEntityGotoPoint(Point3D coordinates, Entity entity, int seconds, string title, TaskSeverity severity) => throw null;
        public TaskEntityGotoPoint(Point3D coordinates, Entity entity, int seconds, string title, TaskSeverity severity, string drawingFile, string module) => throw null;
        public TaskEntityGotoPoint(Point3D coordinates, Color color, int size, Entity entity, int seconds, string title, TaskSeverity severity) => throw null;
        public TaskEntityGotoPoint(Point3D coordinates, Entity entity, int seconds, string title, TaskSeverity severity, string drawingFile, string module, ITask[] childs) => throw null;
        public TaskEntityGotoPoint(Point3D coordinates, Color color, int size, Entity entity, int seconds, string title, TaskSeverity severity, string drawingFile, string module) => throw null;
        public TaskEntityGotoPoint(Point3D coordinates, Color color, int size, Entity entity, int seconds, string title, TaskSeverity severity, string drawingFile, string module, ITask[] childs) => throw null;
        public override void Execute() => throw null;

        public int Seconds { get; set; }
        public Entity Entity { get; set; }
    }
}
