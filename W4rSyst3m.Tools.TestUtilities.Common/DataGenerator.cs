#region Using

using System;
using System.Linq;
using System.Text;

#endregion

namespace W4rSyst3m.Tools.TestUtilities.Common
{
    public static class DataGenerator
    {
        private const int MaxLength = 80;
        private const int DaysLimit = 365;
        /// <summary>
        /// Generetes random data
        /// </summary>
        /// <typeparam name="T">Type of data will be generated</typeparam>
        /// <returns>returns a date according with T</returns>
        public static T Generate<T>()
        {
            return (T)Generate(typeof(T));
        }

        private static object Generate(Type type)
        {
            if (type == typeof(string)) return Generate(MaxLength);
            else if (type == typeof(Guid)) return Guid.NewGuid();
            else if (type == typeof(int)) return Next(int.MaxValue);
            else if (type == typeof(long)) return (long)Next(int.MaxValue);
            else if (type == typeof(bool)) return GetRand().Next(0, 1) == 1;
            else if (type == typeof(decimal)) return (decimal)GetRand().NextDouble();
            else if (type == typeof(double)) return GetRand().NextDouble();
            else if (type == typeof(byte)) return (byte)Next(byte.MaxValue);
            else if (type == typeof(short)) return (short)Next(short.MaxValue);
            else if (type == typeof(DateTime)) return DateTime.Now.AddDays(GetRand().Next(-DaysLimit, 0));
            else if (type.IsEnum) return GetRandomEnum(type);
            else if (type.IsClass) return ActivateClass(type);

            return Default(type);
        }

        private static string Generate(int max)
        {
            var text = new StringBuilder();
            for (int i = 0; i < GetRand().Next(1, max); i++)
            {
                text.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * GetRand().NextDouble() + 65))));
            }

            return text.ToString();
        }

        private static object GetRandomEnum(Type type)
        {
            var enumValues = Enum.GetValues(type);

            return enumValues.GetValue(GetRand().Next(0, enumValues.Length - 1));
        }

        /// <summary>
        /// Generate a random int
        /// </summary>
        /// <param name="max">Maximun value to be generated</param>
        /// <returns>returns a int value</returns>
        public static int Next(int max)
        {
            return GetRand().Next(1, max);
        }

        /// <summary>
        /// Create a new instance of Random class
        /// </summary>
        /// <returns>return a Random class instanceated </returns>
        public static Random GetRand()
        {
            return new Random((int)DateTime.Now.Ticks);
        }

        private static object ActivateClass(Type type)
        {
            var obj = Activator.CreateInstance(type);

            foreach (var property in type.GetProperties().Where(c => c.CanWrite == true))
            {
                property.SetValue(obj, Generate(property.PropertyType));
            }

            return obj;
        }

        private static object Default(Type type)
        {
            try
            {
                return Activator.CreateInstance(type);
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
