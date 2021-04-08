using Digi21.DigiNG.Entities;
using Digi21.Math;
using System;

namespace Digi21.DigiNG.Plugin.Command
{
    public abstract class Command : ICommand, IDisposable
    {
        public event EventHandler<Point3DEventArgs> DataDown;
        public event EventHandler<Point3DEventArgs> DataUp;
        public event EventHandler Disposing;
        public event EventHandler<EntitySelectedEventArgs> EntitySelected;
        public event EventHandler Initialize;
        public event EventHandler LostFocus;
        public event EventHandler<MoveEventArgs> Move;
        public event EventHandler<Point3DEventArgs> ResetDown;
        public event EventHandler<Point3DEventArgs> ResetUp;
        public event EventHandler SetFocus;
        public event EventHandler<Point3DEventArgs> SnapDown;
        public event EventHandler<Point3DEventArgs> SnapUp;

        public Command() => throw null;
        public void Dispose() => throw null;
        public virtual bool OnDataDown(Point3D groundPoint) => throw null;
        public virtual bool OnDataUp(Point3D groundPoint) => throw null;
        public virtual void OnEntitySelected(Entity entity, Point3D groundPoint, int firstVertex, int secondVertex) => throw null;
        public virtual void OnInitialize() => throw null;
        public virtual void OnLostFocus() => throw null;
        public virtual void OnMove(Point3D groundPoint, InputDeviceButton button) => throw null;
        public virtual bool OnResetDown(Point3D groundPoint) => throw null;
        public virtual bool OnResetUp(Point3D groundPoint) => throw null;
        public virtual void OnSetFocus() => throw null;
        public virtual bool OnSnapDown(Point3D groundPoint) => throw null;
        public virtual bool OnSnapUp(Point3D groundPoint) => throw null;

        public string[] Args => throw null;
        public bool AllowRepeat { get; set; }
    }
}
