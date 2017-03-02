using System;
using System.Collections.Generic;
using System.Linq;

namespace W4rSyst3m.Tools.Utilities
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
        {
            return list.IsNull() || !list.Any();
        }

        public static bool IsNotNullNorEmpty<T>(this IEnumerable<T> list)
        {
            return !list.IsNullOrEmpty();
        }

        public static bool Contains(
            this IEnumerable<string> list, 
            string value,
            StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase)
        {
            value.NotNullOrEmpty("value");

            if (list.IsNullOrEmpty()) return false;

            return list.Any(a => a.Equals(value, stringComparison));
        }
    }
}
