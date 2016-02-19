namespace JCUtility.Common
{
    using System.Collections.Generic;

    /// <summary>
    /// Extension methods for <see cref="System.Collections.Generic.IDictionary{TKey, TValue}"/>
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Gets the value associated with the specified key or the <paramref name="defaultValue"/> if it does not exist
        /// </summary>
        /// <typeparam name="TKey">The type of dictionary key</typeparam>
        /// <typeparam name="TValue">The type of dictionary value</typeparam>
        /// <param name="dictionary">Source</param>
        /// <param name="key">Key</param>
        /// <param name="defaultValue">The default value to return if <paramref name="key"/> does not exist</param>
        /// <returns>the value associated with the specified key or the <paramref name="defaultValue"/> if it does not exist</returns>
        public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue = default(TValue))
        {
            TValue value;

            if (dictionary.TryGetValue(key, out value))
            {
                return value;
            }

            return defaultValue;
        }
    }
}