using System;
using System.Collections.Generic;

namespace W4rSyst3m.Tools.Utilities
{
    public static class Conditions
    {
        /// <summary>
        /// Throw an AgumentException If the condition returns false
        /// </summary>
        /// <typeparam name="T">Type of argument parameter</typeparam>
        /// <param name="argument">argument to be validated</param>
        /// <param name="condition">condition to be verified</param>
        /// <param name="message">Message has to be threw</param>
        public static void Must<T>(
            this T argument,
            Func<T, bool> condition,
            string message)
        {
            if (!condition(argument)) throw new ArgumentException(message, "argument");
        }

        /// <summary>
        /// Throw an AgumentException If the argument is null
        /// </summary>
        /// <typeparam name="T">type of argument</typeparam>
        /// <param name="argument">Argument to be verifed</param>
        /// <param name="argumentName">Name of argument</param>
        public static void NotNull<T>(this T argument, string argumentName)
        {
            argument.Must(
                a => a.IsNotNull(), 
                "{0} can not be null.".FormatAs(argumentName));
        }

        /// <summary>
        /// Throw an AgumentException If the argument is null or empty
        /// </summary>
        /// <param name="argument">String value</param>
        /// <param name="argumentName">Name of argument</param>
        public static void NotNullOrEmpty(this string argument, string argumentName)
        {
            argument.Must(
                a => !a.IsNullOrEmpty(),
                "{0} can not be either null or empty.".FormatAs(argumentName));
        }

        /// <summary>
        /// Throw an AgumentException If the enumerable argument is null or empty
        /// </summary>
        /// <param name="argument">Enumerable value</param>
        /// <param name="argumentName">Name of argument</param>
        public static void NotNullOrEmpty<T>(this IEnumerable<T> argument, string argumentName)
            where T : class
        {
            argument.Must(
                a => !a.IsNullOrEmpty(),
                "{0} can not be either null or empty.".FormatAs(argumentName));
        }

        /// <summary>
        /// throws an ArgumentException if the Type is not a enum
        /// </summary>
        /// <param name="type">Type of object</param>
        public static void IsEnum(
            this object argument)
        {
            argument.GetType().Must(t => t.IsEnum,
                "{0} is not a valid System.Enum type".FormatAs(argument.GetType().FullName));
        }
    }
}
