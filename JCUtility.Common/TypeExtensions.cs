namespace JCUtility.Common
{
    using System;

    /// <summary>
    /// Extensions methods for <see cref="System.Type"/>
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Determines whether the <paramref name="type"/> implements <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="type">The current type</param>
        /// <returns>true if the <paramref name="type"/> implements <typeparamref name="T"/>; otherwise false</returns>
        public static bool Implements<T>(this Type type)
        {
            Ensure.Argument.NotNull(type, "type");
            return typeof(T).IsAssignableFrom(type);
        }
    }
}