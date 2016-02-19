namespace JCUtility.Common
{
    using System;

    /// <summary>
    /// Utilities for working with <see cref="System.Enum"/> types.
    /// </summary>
    public static class EnumUtils
    {
        /// <summary>
        /// Converts the string representation of the name or numeric value of one or more
        /// enumerated constants to an equivalent enumerated object.
        /// </summary>
        /// <param name="value">An enumeration type</param>
        /// <typeparam name="TEnum">A string containing the name or value to convert</typeparam>
        /// <returns>An object of type <typeparamref name="TEnum"/> whose value is represented by <paramref name="value"/></returns>
        public static TEnum ParseFromString<TEnum>(string value)
        {
            Ensure.Argument.NotNullOrEmpty(value, "enumString");
            return (TEnum)Enum.Parse(typeof(TEnum), value);
        }
    }
}