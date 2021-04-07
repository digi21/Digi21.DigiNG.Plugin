using Digi21.DigiNG.Entities;

namespace Digi21.DigiNG.Plugin.Search
{
    public interface IDynamicProperty
    {
        object Transform(string parameter, Entity entity);
    }
}
