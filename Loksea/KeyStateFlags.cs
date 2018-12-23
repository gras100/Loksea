using System;

namespace Loksea
{
    [Flags]
    public enum KeyStateFlags
    {
        None = 0,
        CapsLock = 1,
        NumLock = 2,
        Insert = 4,
        ScrollLock = 8
    }
}
