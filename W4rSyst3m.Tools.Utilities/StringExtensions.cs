using System;

namespace W4rSyst3m.Tools.Utilities
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static T ConvertTo<T>(this string value)
        {
            value.Must(v => !v.IsNullOrEmpty(), "I's can not be either null or empty.");

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public static int ToInt(this string value)
        {
            value.Must(v => !v.IsNullOrEmpty(), "I's can not be either null or empty.");
            return value.ConvertTo<int>();
        }

        public static long ToLong(this string value)
        {
            value.Must(v => !v.IsNullOrEmpty(), "I's can not be either null or empty.");
            return value.ConvertTo<long>();
        }

        public static decimal ToDecimal(this string value)
        {
            value.Must(v => !v.IsNullOrEmpty(), "I's can not be either null or empty.");
            return value.ConvertTo<decimal>();
        }

        public static double ToDouble(this string value)
        {
            value.Must(v => !v.IsNullOrEmpty(), "I's can not be either null or empty.");
            return value.ConvertTo<double>();
        }

        public static string FormatAs(
            this string value, 
            params object[] arguments)
        {
            value.Must(v => !v.IsNullOrEmpty(), "I's can not be either null or empty.");
            return string.Format(value, arguments);
        }

    }
}
