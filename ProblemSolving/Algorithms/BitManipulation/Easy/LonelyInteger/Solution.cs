using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LonelyInteger
{
    public static class Solution
    {
        public static int Lonelyinteger(int[] a)
        {
            return a.Aggregate(0, (current, d) => current ^ d);
        }
    }
}
