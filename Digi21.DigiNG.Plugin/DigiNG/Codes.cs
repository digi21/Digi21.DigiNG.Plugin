using Digi21.DigiNG.Entities;
using System;
using System.Collections.Generic;

namespace Digi21.DigiNG
{
    public class Codes
    {
        public Code[] DlgSelectCodes(string title, bool allowMultipleCodes) { throw null; }
        public int SelectCodeFromList(string title, Code[] listOfCodes) { throw null; }
        public void ShowCode(Func<string, bool> showThisCode) { throw null; }
        public void ShowCode(IEnumerable<string> codeNames, bool visible) { throw null; }
        public void ShowCode(string codeName, bool visible) { throw null; }

        public IEnumerable<Code> ActiveCodes { get; set; }
    }
}




