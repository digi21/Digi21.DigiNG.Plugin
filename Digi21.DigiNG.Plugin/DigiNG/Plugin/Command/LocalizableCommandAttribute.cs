using System;

namespace Digi21.DigiNG.Plugin.Command
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LocalizableCommandAttribute : CommandAttribute
    {
        public LocalizableCommandAttribute(Type resourceManagerProvider, string nameResource) => throw null;
        public LocalizableCommandAttribute(Type resourceManagerProvider, string nameResource, string descriptionResource) => throw null;
        public LocalizableCommandAttribute(Type resourceManagerProvider, string nameResource, string descriptionResource, string helpUrlResource) => throw null;
    }
}
