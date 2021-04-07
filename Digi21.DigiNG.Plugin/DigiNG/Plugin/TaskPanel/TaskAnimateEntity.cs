using Digi21.Digi3D;
using Digi21.DigiNG.Entities;

namespace Digi21.DigiNG.Plugin.TaskPanel
{
    public class TaskAnimateEntity : TaskBase
    {
        public TaskAnimateEntity() => throw null;
        public TaskAnimateEntity(Entity entity, int seconds, string title, TaskSeverity severity) => throw null;
        public TaskAnimateEntity(Entity entity, int seconds, string title, TaskSeverity severity, string drawingFile, string module) => throw null;
        public TaskAnimateEntity(Entity entity, int seconds, string title, TaskSeverity severity, string drawingFile, string module, ITask[] childs) => throw null;
        public override void Execute() => throw null;

        public int Seconds { get; set; }
        public Entity Entity { get; set; }
    }
}
