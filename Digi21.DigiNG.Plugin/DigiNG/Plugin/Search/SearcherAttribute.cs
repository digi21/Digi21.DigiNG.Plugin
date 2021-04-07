using System;

namespace Digi21.DigiNG.Plugin.Search
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SearcherAttribute : Attribute
    {
        public SearcherAttribute() => throw null;

        public string Title { get; set; }
    }
}
