using System;

namespace Digi21.DigiNG.Plugin.Command
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class RelatedCommandAttribute : Attribute
    {
        public RelatedCommandAttribute() => throw null;

        public string Name { get; set; }
    }
}
