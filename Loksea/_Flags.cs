using System;
using System.Linq;

namespace Loksea
{
    static class _Flags
    {
        public static long MaxValue<T>() where T : struct, System.Enum
        {
            return Enum.GetValues(typeof(T)).Cast<int>().Sum();
        }
    }
}
