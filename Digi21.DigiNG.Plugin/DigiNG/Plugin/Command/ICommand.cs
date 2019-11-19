using Digi21.DigiNG.Entities;
using Digi21.Math;

namespace Digi21.DigiNG.Plugin.Command
{
    public interface ICommand
    {
        bool OnDataDown(Point3D groundPoint);
        bool OnDataUp(Point3D groundPoint);
        void OnEntitySelected(Entity entity, Point3D groundPoint, int firstVertex, int secondVertex);
        void OnInitialize();
        void OnLostFocus();
        void OnMove(Point3D groundPoint, Button button);
        bool OnResetDown(Point3D groundPoint);
        bool OnResetUp(Point3D groundPoint);
        void OnSetFocus();
        bool OnSnapDown(Point3D groundPoint);
        bool OnSnapUp(Point3D groundPoint);
    }
}
