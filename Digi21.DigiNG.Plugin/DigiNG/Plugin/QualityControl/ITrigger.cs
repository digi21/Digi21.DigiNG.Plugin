using Digi21.DigiNG.Entities;
using System.Collections.Generic;

namespace Digi21.DigiNG.Plugin.QualityControl
{
    public interface ITrigger
    {
        Entity AnalyzeEntity(Entity entity, IDictionary<string, IDictionary<string, object>> databaseAttributes, bool addingEntity);
    }
}
