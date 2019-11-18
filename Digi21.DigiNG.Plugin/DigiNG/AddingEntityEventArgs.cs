using Digi21.DigiNG.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG
{
    public class AddingEntityEventArgs : EventArgs
    {
        public AddingEntityEventArgs(Entity entity, Dictionary<string, IDictionary<string, object>> databaseAttributes) { throw null; }

        public Dictionary<string, IDictionary<string, object>> DatabaseAttributes { get; }
        public bool Cancel { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
        public Entity Entity { get; }
    }
}
