using Digi21.DigiNG.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG
{
    public class Codes
    {
        public Code[] DlgSelectCodes(string title, [MarshalAs(UnmanagedType.U1)] bool allowMultipleCodes) { throw null; }
        public int SelectCodeFromList(string title, Code[] listOfCodes) { throw null; }
        public void ShowCode(Func<string, bool> showThisCode) { throw null; }
        public void ShowCode(IEnumerable<string> codeNames, [MarshalAs(UnmanagedType.U1)] bool visible) { throw null; }
        public void ShowCode(string codeName, [MarshalAs(UnmanagedType.U1)] bool visible) { throw null; }

        public IEnumerable<Code> ActiveCodes { get; set; }
    }
}




