using System;

namespace Digi21.DigiNG.Plugin.Menu
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LocalizableCommandInMenuAttribute : CommandInMenuAttribute
    {
        public LocalizableCommandInMenuAttribute(Type resourceManagerProvider, string titleResource, MenuItemGroup group) : base(string.Empty, MenuItemGroup.DatabaseGroup1) => throw null;
    }
}
