using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loksea
{
    [FlagsAttribute]
    public enum KeyStateFlags
    {
        None = 0,
        CapsLock = 1,
        ScrollLock = 8,
        NumLock = 2,
        Insert = 4
    }
}
