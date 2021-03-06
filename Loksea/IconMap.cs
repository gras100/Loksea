﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

namespace Loksea
{
    static class IconMap
    {
        private static Dictionary<KeyStateFlags, Icon> map = new Dictionary<KeyStateFlags, Icon>();
        
        static IconMap()
        {
            CultureInfo ci = Properties.Resources.Culture;
            for(int i = 0; i <= _Flags.MaxValue<KeyStateFlags>(); i++)
            {
                String iconName = "LockSea_" + getFileFlagsToken(i);
                Icon icon = (Icon) Properties.Resources.ResourceManager.GetObject(iconName, ci);
                map.Add((KeyStateFlags)i, icon);
            }
        }

        private static String getFileFlagsToken(KeyStateFlags flags)
        {
            return getFileFlagsToken((long)flags);
        }

        static String getFileFlagsToken(long flags)
        {
            // e.g. 10 -> 0010 -> 0100 -> nynn
            return _String.Reversed(Convert.ToString(flags, 2).PadLeft(4, '0')).Replace("1", "y").Replace("0", "n");
        }

        public static Icon get(KeyStateFlags value)
        {
            return map[value];
        }
    }
}
