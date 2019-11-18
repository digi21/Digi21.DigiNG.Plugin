using Digi21.DigiNG.Entities;
using Digi21.Math;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Plugin.Command
{
    public interface ICommand
    {
        [return: MarshalAs(UnmanagedType.U1)]
        bool OnDataDown(Point3D groundPoint);
        [return: MarshalAs(UnmanagedType.U1)]
        bool OnDataUp(Point3D groundPoint);
        void OnEntitySelected(Entity entity, Point3D groundPoint, int firstVertex, int secondVertex);
        void OnInitialize();
        void OnLostFocus();
        void OnMove(Point3D groundPoint, Button button);
        [return: MarshalAs(UnmanagedType.U1)]
        bool OnResetDown(Point3D groundPoint);
        [return: MarshalAs(UnmanagedType.U1)]
        bool OnResetUp(Point3D groundPoint);
        void OnSetFocus();
        [return: MarshalAs(UnmanagedType.U1)]
        bool OnSnapDown(Point3D groundPoint);
        [return: MarshalAs(UnmanagedType.U1)]
        bool OnSnapUp(Point3D groundPoint);
    }
}
