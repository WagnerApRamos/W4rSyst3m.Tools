using System;
using System.Collections.Generic;

namespace W4rSyst3m.Tools.Utilities
{
    public static class Conditions
    {
        public static void Must<T>(
            this T argument,
            Func<T, bool> condition,
            string message)
        {
            if (!condition(argument)) throw new ArgumentException(message, "argument");
        }

        public static void NotNull<T>(this T argument, string argumentName)
        {
            argument.Must(
                a => a.IsNotNull(), 
                "{0} can not be null.".FormatAs(argumentName));
        }

        public static void NotNullOrEmpty(this string argument, string argumentName)
        {
            argument.Must(
                a => !a.IsNullOrEmpty(),
                "{0} can not be either null or empty.".FormatAs(argumentName));
        }

        public static void NotNullOrEmpty<T>(this IEnumerable<T> argument, string argumentName)
            where T : class
        {
            argument.Must(
                a => !a.IsNullOrEmpty(),
                "{0} can not be either null or empty.".FormatAs(argumentName));
        }

        public static void IsEnum(
            this Type type)
        {
            type.Must(t => t.IsEnum,
                "{0} is not a valid System.Enum type".FormatAs(type.FullName));
        }
    }
}
