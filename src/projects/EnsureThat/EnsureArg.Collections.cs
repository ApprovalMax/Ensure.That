using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using EnsureThat.Annotations;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T HasItems<T>([ValidatedNotNull, NotNull] T value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> HasItems<T>([ValidatedNotNull, NotNull]ICollection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyCollection<T> HasItems<T>([ValidatedNotNull, NotNull]IReadOnlyCollection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyList<T> HasItems<T>([ValidatedNotNull, NotNull]IReadOnlyList<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ISet<T> HasItems<T>([ValidatedNotNull, NotNull]ISet<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] HasItems<T>([ValidatedNotNull, NotNull]T[] value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> HasItems<T>([ValidatedNotNull, NotNull] IList<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIs<T>([ValidatedNotNull, NotNull]T[] value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] SizeIs<T>([ValidatedNotNull, NotNull]T[] value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIs<T>([ValidatedNotNull, NotNull]T value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T SizeIs<T>([ValidatedNotNull, NotNull]T value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class, ICollection
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIs<T>([ValidatedNotNull, NotNull]ICollection<T> value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> SizeIs<T>([ValidatedNotNull, NotNull]ICollection<T> value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIs<T>([ValidatedNotNull, NotNull] IList<T> value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> SizeIs<T>([ValidatedNotNull, NotNull]IList<T> value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.ContainsKey(value, expectedKey, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> HasAny<T>([ValidatedNotNull, NotNull] IList<T> value, Func<T, bool> predicate, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> HasAny<T>([ValidatedNotNull, NotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] HasAny<T>([ValidatedNotNull, NotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Ensure.Collection.HasAny(value, predicate, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static Collection<T> HasAllNotNullItems<T>([ValidatedNotNull, NotNull]Collection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Collection.HasAllNotNullItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> HasAllNotNullItems<T>([ValidatedNotNull, NotNull]ICollection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Collection.HasAllNotNullItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyCollection<T> HasAllNotNullItems<T>([ValidatedNotNull, NotNull]IReadOnlyCollection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Collection.HasAllNotNullItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyList<T> HasAllNotNullItems<T>([ValidatedNotNull, NotNull]IReadOnlyList<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Collection.HasAllNotNullItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ISet<T> HasAllNotNullItems<T>([ValidatedNotNull, NotNull]ISet<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Collection.HasAllNotNullItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] HasAllNotNullItems<T>([ValidatedNotNull, NotNull]T[] value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Collection.HasAllNotNullItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static List<T> HasAllNotNullItems<T>([ValidatedNotNull, NotNull]List<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Collection.HasAllNotNullItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> HasAllNotNullItems<T>([ValidatedNotNull, NotNull] IList<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Collection.HasAllNotNullItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static HashSet<T> HasAllNotNullItems<T>([ValidatedNotNull, NotNull] HashSet<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Collection.HasAllNotNullItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static Collection<T> HasAllNotDefaultItems<T>([ValidatedNotNull, NotNull]Collection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Collection.HasAllNotDefaultItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ICollection<T> HasAllNotDefaultItems<T>([ValidatedNotNull, NotNull]ICollection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Collection.HasAllNotDefaultItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyCollection<T> HasAllNotDefaultItems<T>([ValidatedNotNull, NotNull]IReadOnlyCollection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Collection.HasAllNotDefaultItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyList<T> HasAllNotDefaultItems<T>([ValidatedNotNull, NotNull]IReadOnlyList<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Collection.HasAllNotDefaultItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static ISet<T> HasAllNotDefaultItems<T>([ValidatedNotNull, NotNull]ISet<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Collection.HasAllNotDefaultItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T[] HasAllNotDefaultItems<T>([ValidatedNotNull, NotNull]T[] value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Collection.HasAllNotDefaultItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static List<T> HasAllNotDefaultItems<T>([ValidatedNotNull, NotNull]List<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Collection.HasAllNotDefaultItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IList<T> HasAllNotDefaultItems<T>([ValidatedNotNull, NotNull] IList<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Collection.HasAllNotDefaultItems(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static HashSet<T> HasAllNotDefaultItems<T>([ValidatedNotNull, NotNull] HashSet<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Collection.HasAllNotDefaultItems(value, paramName, optsFn);
    }
}
