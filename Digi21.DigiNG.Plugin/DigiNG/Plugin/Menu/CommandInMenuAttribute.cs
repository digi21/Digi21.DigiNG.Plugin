using System;

namespace Digi21.DigiNG.Plugin.Menu
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandInMenuAttribute : Attribute
    {
        public CommandInMenuAttribute(string title, MenuItemGroup group) { throw null; }

        public MenuItemGroup Group { get; set; }
        public string Title { get; set; }
    }
}
