using Digi21.DigiNG.Entities;

namespace Digi21.DigiNG.Plugin.Databases
{
    public interface IDynamicProperty
    {
        object Transform(string parameter, Entity entity);
    }
}
