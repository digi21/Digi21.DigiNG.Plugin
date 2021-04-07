using System;

namespace Digi21.DigiNG.Plugin.Search
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LocalizableSearcherAttribute : SearcherAttribute
    {
        public LocalizableSearcherAttribute(Type resourceManagerProvider, string resourceKey) => throw null;
    }
}
