using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
