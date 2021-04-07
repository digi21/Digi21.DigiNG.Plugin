using System;

namespace Digi21.DigiNG.Plugin.Command
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandAttribute : Attribute
    {
        public CommandAttribute() => throw null;

        public string HelpUrl { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
