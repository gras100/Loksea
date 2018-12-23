using System;

namespace Loksea
{
    class _String
    {
        public static String Reversed(String str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }
    }
}
