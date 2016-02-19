namespace JCUtility.Common
{
    using System;

    /// <summary>
    /// Extensions for <see cref="System.String"/>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// A nicer way of calling <see cref="System.String.IsNullOrEmpty(string)"/>
        /// </summary>
        /// <param name="value">The string to test</param>
        /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// A nicer way of calling the inverse of <see cref="System.String.IsNullOrEmpty(string)"/>
        /// </summary>
        /// <param name="value">The string to test</param>
        /// <returns>true if the value parameter is not null nor an empty string (""); otherwise, false.</returns>
        public static bool IsNotNullOrEmpty(this string value)
        {
            return !value.IsNullOrEmpty();
        }

        /// <summary>
        /// A nicer way of calling <see cref="System.String.Format(string, object[])"/>
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="args">An object array that contains zero or more objects to format</param>
        /// <returns>
        /// A copy of format in which the format items have been replaced by the string represntation 
        /// of the corresponding objects in <paramref name="args"/>
        /// </returns>
        public static string FormatWith(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        /// <summary>
        /// Checks if the <paramref name="source"/> contains <paramref name="input"/> based on the provided <paramref name="comparison"/> rules
        /// </summary>
        /// <param name="source">source string</param>
        /// <param name="input">input string</param>
        /// <param name="comparison">comparison rules</param>
        /// <returns>true if the <paramref name="source"/> contains <paramref name="input"/>; otherwise false</returns>
        public static bool Contains(this string source, string input, StringComparison comparison)
        {
            return source.IndexOf(input, comparison) >= 0;
        }

        /// <summary>
        /// Limits the length of the <paramref name="source"/> to the specified <paramref name="maxLength"/>
        /// </summary>
        /// <param name="source">The source string</param>
        /// <param name="maxLength">The maximum length of the desired result</param>
        /// <param name="suffix">The suffix string to append at the end of the output string</param>
        /// <returns>The converted string within limited length with suffix</returns>
        public static string Limit(this string source, int maxLength, string suffix = null)
        {
            if (suffix.IsNullOrEmpty())
            {
                maxLength = maxLength - suffix.Length;
            }

            if (source.Length <= maxLength)
            {
                return source;
            }

            return string.Concat(source.Substring(0, maxLength).Trim(), suffix ?? string.Empty);
        }
    }
}