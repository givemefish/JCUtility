﻿namespace JCUtility.Common
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <summary>
    /// Extension methods for <see cref="System.Collections.Generic.IEnumerable{T}"/>
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Performs an action on each value of the enumerable
        /// </summary>
        /// <typeparam name="T">Element type</typeparam>
        /// <param name="enumerable">Sequence on which to perform action</param>
        /// <param name="action">Action to perform on every item</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when given null <paramref name="enumerable"/> or <paramref name="action"/>
        /// </exception>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            Ensure.Argument.NotNull(enumerable, "enumerable");
            Ensure.Argument.NotNull(action, "action");

            foreach (T value in enumerable)
            {
                action(value);
            }
        }

        /// <summary>
        /// Convenience method for retrieving a specific page of items within a collection
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="source">Source</param>
        /// <param name="pageIndex">The index of the page to get</param>
        /// <param name="pageSize">The size of te pages</param>
        /// <returns>Specific page of items within a collection</returns>
        public static IEnumerable<T> Getpage<T>(this IEnumerable<T> source, int pageIndex, int pageSize)
        {
            Ensure.Argument.NotNull(source, "source");
            Ensure.Argument.Is(pageIndex >= 0, "The page index cannot be negative.");
            Ensure.Argument.Is(pageSize >= 0, "The page size must be greater than zero.");

            return source.Skip(pageIndex * pageSize).Take(pageSize);
        }

        /// <summary>
        /// Converts an enumerable into a readonly collection
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="enumerable">Source</param>
        /// <returns>Readonly collection of <paramref name="enumerable"/></returns>
        public static IEnumerable<T> ToReadOnlyCollection<T>(this IEnumerable<T> enumerable)
        {
            return new ReadOnlyCollection<T>(enumerable.ToList());
        }

        /// <summary>
        /// Validates that the <paramref name="enumerable"/> is not null and contains items.
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="enumerable">Source</param>
        /// <returns>true if the <paramref name="enumerable"/> is not null and contains items; otherwise, false</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable != null && enumerable.Any();
        }
    }
}