using Digi21.DigiNG.Entities;
using System;
using System.Collections.Generic;

namespace Digi21.DigiNG
{
    public class AddingEntityEventArgs : EventArgs
    {
        public AddingEntityEventArgs(Entity entity, Dictionary<string, IDictionary<string, object>> databaseAttributes) => throw null;

        public Dictionary<string, IDictionary<string, object>> DatabaseAttributes => throw null;
        public bool Cancel { get; set; }
        public Entity Entity => throw null;
    }
}
