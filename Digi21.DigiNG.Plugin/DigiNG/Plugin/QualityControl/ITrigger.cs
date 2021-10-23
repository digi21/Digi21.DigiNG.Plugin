using Digi21.DigiNG.Entities;

namespace Digi21.DigiNG.Plugin.QualityControl
{
    public interface ITrigger
    {
        Entity AnalyzeEntity(Entity entity, bool addingEntity);
    }
}
