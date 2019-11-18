using Digi21.DigiNG.Entities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Digi21.DigiNG.Plugin.Search
{
    public interface ISearcher
    {
        IEnumerable<Entity> Search(IEnumerable<Entity> entities);

        Form Form { get; }
    }
}
