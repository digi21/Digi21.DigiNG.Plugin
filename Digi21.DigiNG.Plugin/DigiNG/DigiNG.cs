using Digi21.DigiNG.Cameras;
using Digi21.DigiNG.Entities;
using Digi21.DigiNG.IO;
using Digi21.Math;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;

namespace Digi21.DigiNG
{
    public static class DigiNG
    {
        public static event EventHandler<AddingEntityEventArgs> AddingEntity;
        public static event EventHandler<EventArgs> DestroyingWindow;
        public static event EventHandler<EntityEventArgs> EntityAdded;
        public static event EventHandler<EntityEventArgs> EntityDeleted;
        public static event EventHandler<EventArgs> PostRender;
        public static event EventHandler<EventArgs> PreRender;
        public static event EventHandler<EventArgs> WindowCreated;

        static DigiNG() { throw null; }
        public static void AnimateEntity(Entity entity) { throw null; }
        public static void AnimateEntity(IEnumerable<Entity> entities) { throw null; }
        public static void AnimateEntity(Entity entity, int seconds) { throw null; }
        public static void AnimateEntity(IEnumerable<Entity> entities, int seconds) { throw null; }
        public static void DeanimateAll() { throw null; }
        public static void DeanimateEntity(Entity entity) { throw null; }
        public static void DeanimateEntity(IEnumerable<Entity> entities) { throw null; }
        public static void DrawEntity(Entity entity) { throw null; }
        public static void DrawEntity(IEnumerable<Entity> entities) { throw null; }
        public static void DrawEntity(Entity entity, DrawingMode mode) { throw null; }
        public static void DrawEntity(Entity entity, bool allowPattern) { throw null; }
        public static void DrawEntity(IEnumerable<Entity> entities, DrawingMode mode) { throw null; }
        public static void DrawEntity(IEnumerable<Entity> entities, bool allowPattern) { throw null; }
        public static void DrawEntity(Entity entity, bool allowPattern, DrawingMode mode) { throw null; }
        public static void DrawEntity(Entity entity, bool drawInCadWindow, bool drawInPhotogrammetricWindow) { throw null; }
        public static void DrawEntity(IEnumerable<Entity> entities, bool allowPattern, DrawingMode mode) { throw null; }
        public static void DrawEntity(IEnumerable<Entity> entities, bool drawInCadWindow, bool drawInPhotogrammetricWindow) { throw null; }
        public static void DrawEntity(Entity entity, bool drawInCadWindow, bool drawInPhotogrammetricWindow, DrawingMode mode) { throw null; }
        public static void DrawEntity(Entity entity, bool drawInCadWindow, bool drawInPhotogrammetricWindow, bool allowPattern) { throw null; }
        public static void DrawEntity(IEnumerable<Entity> entities, bool drawInCadWindow, bool drawInPhotogrammetricWindow, DrawingMode mode) { throw null; }
        public static void DrawEntity(IEnumerable<Entity> entities, bool drawInCadWindow, bool drawInPhotogrammetricWindow, bool allowPattern) { throw null; }
        public static void DrawEntity(Entity entity, bool drawInCadWindow, bool drawInPhotogrammetricWindow, bool allowPattern, DrawingMode mode) { throw null; }
        public static void DrawEntity(IEnumerable<Entity> entities, bool drawInCadWindow, bool drawInPhotogrammetricWindow, bool allowPattern, DrawingMode mode) { throw null; }
        public static void NewTransaction() { throw null; }
        public static void RenderScene() { throw null; }
        public static void SelectEntity(Point3D groundPoint) { throw null; }
        public static void SelectEntity(Point3D groundPoint, Func<Entity, bool> predicate) { throw null; }
        public static void SendInputDeviceEvent(Point3D worldCoordinates, InputDeviceButton button) { throw null; }
        public static void SetVisible(Entity entity, bool visible) { throw null; }
        public static bool Undo() { throw null; }

        public static IReadOnlyDrawingFile[] ReferenceFiles { get; }
        public static DrawingFile DrawingFile { get; }
        public static bool LockUndo { get; set; }
        public static GeographicCalculator GeographicCalculator { get; }
        public static string Wkt { get; }
        public static IntPtr DeviceContextHandle { get; }
        public static IntPtr RenderContextHandle { get; }
        public static Size WindowSize { get; }
        public static ActiveParameters ActiveParameters { get; }
        public static InputDeviceOptions InputDeviceOptions { get; }
        public static VisualizationOptions VisualizationOptions { get; }
        public static Camera Camera { get; set; }
        public static Commands Commands { get; }
        public static Digi21.DigiNG.DigiTab.DigiTab DigiTab { get; }
        public static Codes Codes { get; }
        public static LicenseInfo LicenseInfo { get; }

        public static bool GetResultPythonExpression(Entity entity, string expression) { throw null;}
        public static IEnumerable<Entity> SelectByPythonExpression(IEnumerable<Entity> entities, string expression) { throw null; }
    }
}
