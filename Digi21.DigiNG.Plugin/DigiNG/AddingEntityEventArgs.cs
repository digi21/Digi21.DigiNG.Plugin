﻿using Digi21.DigiNG.Entities;
using System;
using System.Collections.Generic;

namespace Digi21.DigiNG
{
    public class AddingEntityEventArgs : EventArgs
    {
        public AddingEntityEventArgs(Entity entity) => throw null;

        public bool Cancel { get; set; }
        public Entity Entity => throw null;
    }
}
