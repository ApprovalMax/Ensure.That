using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EnsureThat;
using Xunit;

namespace UnitTests
{
    public class EnsureCollectionParamsTests : UnitTestBase
    {
        [Fact]
        public void HasItems_WhenEmptyIReadonlyCollection_ThrowsArgumentException()
        {
            IReadOnlyCollection<int> emptyCollection = new ReadOnlyCollection<int>(new List<int>());

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyCollection, ParamName),
                () => EnsureArg.HasItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyIReadOnlyCollection_ShouldNotThrow()
        {
            IReadOnlyCollection<int> collection = new ReadOnlyCollection<int>(new List<int> { 1, 2, 3 });

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(collection, ParamName),
                () => EnsureArg.HasItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyIReadOnlyList_ThrowsArgumentException()
        {
            IReadOnlyList<int> emptyList = new List<int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyList, ParamName),
                () => EnsureArg.HasItems(emptyList, ParamName),
                () => Ensure.That(emptyList, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyIReadOnlyList_ShouldNotThrow()
        {
            IReadOnlyList<int> collection = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(collection, ParamName),
                () => EnsureArg.HasItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyICollection_ThrowsArgumentException()
        {
            ICollection<int> emptyCollection = new Collection<int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyCollection, ParamName),
                () => EnsureArg.HasItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyICollection_ShouldNotThrow()
        {
            ICollection<int> collection = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(collection, ParamName),
                () => EnsureArg.HasItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyCollection_ThrowsArgumentException()
        {
            var emptyCollection = new Collection<int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyCollection, ParamName),
                () => EnsureArg.HasItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyCollection_ShouldNotThrow()
        {
            var collection = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(collection, ParamName),
                () => EnsureArg.HasItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullArray_ThrowsArgumentNullException()
        {
            var nullArray = null as int[];

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullArray, ParamName),
                () => EnsureArg.HasItems(nullArray, ParamName),
                () => Ensure.That(nullArray, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullCollection_ThrowsArgumentNullException()
        {
            var nullCollection = null as Collection<int>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullCollection, ParamName),
                () => EnsureArg.HasItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullICollection_ThrowsArgumentNullException()
        {
            var nullCollection = null as ICollection<int>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullCollection, ParamName),
                () => EnsureArg.HasItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullList_ThrowsArgumentNullException()
        {
            var nullList = null as List<int>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullList, ParamName),
                () => EnsureArg.HasItems(nullList, ParamName),
                () => Ensure.That(nullList, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullIList_ThrowsArgumentNullException()
        {
            var nullList = null as IList<int>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullList, ParamName),
                () => EnsureArg.HasItems(nullList, ParamName),
                () => Ensure.That(nullList, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullDictionary_ThrowsArgumentNullException()
        {
            var nullDictionary = null as Dictionary<int, string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullDictionary, ParamName),
                () => EnsureArg.HasItems(nullDictionary, ParamName),
                () => Ensure.That(nullDictionary, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNullIDictionary_ThrowsArgumentNullException()
        {
            var nullDictionary = null as IDictionary<int, string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasItems(nullDictionary, ParamName),
                () => EnsureArg.HasItems(nullDictionary, ParamName),
                () => Ensure.That(nullDictionary, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyArray_ThrowsArgumentException()
        {
            var emptyArray = new int[] { };

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyArray, ParamName),
                () => EnsureArg.HasItems(emptyArray, ParamName),
                () => Ensure.That(emptyArray, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyArray_ShouldNotThrow()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(values, ParamName),
                () => EnsureArg.HasItems(values, ParamName),
                () => Ensure.That(values, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyIList_ThrowsArgumentException()
        {
            IList<int> emptyList = new List<int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyList, ParamName),
                () => EnsureArg.HasItems(emptyList, ParamName),
                () => Ensure.That(emptyList, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyIList_ShouldNotThrow()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(values, ParamName),
                () => EnsureArg.HasItems(values, ParamName),
                () => Ensure.That(values, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyList_ThrowsArgumentException()
        {
            var emptyList = new List<int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyList, ParamName),
                () => EnsureArg.HasItems(emptyList, ParamName),
                () => Ensure.That(emptyList, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyList_ShouldNotThrow()
        {
            var values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(values, ParamName),
                () => EnsureArg.HasItems(values, ParamName),
                () => Ensure.That(values, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyIDictionary_ThrowsArgumentException()
        {
            IDictionary<string, int> emptyDict = new Dictionary<string, int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyDict, ParamName),
                () => EnsureArg.HasItems(emptyDict, ParamName),
                () => Ensure.That(emptyDict, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyIDictionary_ShouldNotThrow()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(dict, ParamName),
                () => EnsureArg.HasItems(dict, ParamName),
                () => Ensure.That(dict, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenEmptyDictionary_ThrowsArgumentException()
        {
            var emptyDict = new Dictionary<string, int>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasItems(emptyDict, ParamName),
                () => EnsureArg.HasItems(emptyDict, ParamName),
                () => Ensure.That(emptyDict, ParamName).HasItems());
        }

        [Fact]
        public void HasItems_WhenNonEmptyDictionary_ShouldNotThrow()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.HasItems(dict, ParamName),
                () => EnsureArg.HasItems(dict, ParamName),
                () => Ensure.That(dict, ParamName).HasItems());
        }

        [Fact]
        public void SizeIs_When_matching_length_of_array_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(values, values.Length, ParamName),
                () => EnsureArg.SizeIs(values, values.Length, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Length));
        }

        [Fact]
        public void SizeIs_When_non_matching_length_of_array_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3 };
            var expected = values.Length + 1;

            AssertSizeIsWrong(
                values.Length,
                expected,
                () => Ensure.Collection.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_List_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(values, values.Count, ParamName),
                () => EnsureArg.SizeIs(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_List_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.Collection.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_IList_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(values, values.Count, ParamName),
                () => EnsureArg.SizeIs(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_IList_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.Collection.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_Collection_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(values, values.Count, ParamName),
                () => EnsureArg.SizeIs(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_Collection_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.Collection.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_ICollection_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(values, values.Count, ParamName),
                () => EnsureArg.SizeIs(values, values.Count, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(values.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_ICollection_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3 };
            var expected = values.Count + 1;

            AssertSizeIsWrong(
                values.Count,
                expected,
                () => Ensure.Collection.SizeIs(values, expected, ParamName),
                () => EnsureArg.SizeIs(values, expected, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(dict, dict.Count, ParamName),
                () => EnsureArg.SizeIs(dict, dict.Count, ParamName),
                () => Ensure.That(dict, ParamName).SizeIs(dict.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count + 1;

            AssertSizeIsWrong(
                dict.Count,
                expected,
                () => Ensure.Collection.SizeIs(dict, expected, ParamName),
                () => EnsureArg.SizeIs(dict, expected, ParamName),
                () => Ensure.That(dict, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_matching_count_of_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.SizeIs(dict, dict.Count, ParamName),
                () => EnsureArg.SizeIs(dict, dict.Count, ParamName),
                () => Ensure.That(dict, ParamName).SizeIs(dict.Count));
        }

        [Fact]
        public void SizeIs_When_non_matching_count_of_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } }; ;
            var expected = dict.Count + 1;

            AssertSizeIsWrong(
                dict.Count,
                expected,
                () => Ensure.Collection.SizeIs(dict, expected, ParamName),
                () => EnsureArg.SizeIs(dict, expected, ParamName),
                () => Ensure.That(dict, ParamName).SizeIs(expected));
        }

        [Fact]
        public void SizeIs_When_Array_is_null_It_should_throw_ArgumentNullException()
        {
            int[] values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_ICollection_is_null_It_should_throw_ArgumentNullException()
        {
            ICollection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_Collection_is_null_It_should_throw_ArgumentNullException()
        {
            Collection<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_IList_is_null_It_should_throw_ArgumentNullException()
        {
            IList<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_List_is_null_It_should_throw_ArgumentNullException()
        {
            List<int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void SizeIs_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> values = null;

            AssertIsNotNull(
                () => Ensure.Collection.SizeIs(values, 1, ParamName),
                () => EnsureArg.SizeIs(values, 1, ParamName),
                () => Ensure.That(values, ParamName).SizeIs(1));
        }

        [Fact]
        public void ContainsKey_When_key_does_not_exist_in_Dictionary_It_throws_ArgumentException()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };
            const string expectedKey = "Foo";

            AssertContainsKey(
                expectedKey,
                () => Ensure.Collection.ContainsKey(dict, expectedKey, ParamName),
                () => EnsureArg.ContainsKey(dict, expectedKey, ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey(expectedKey));
        }

        [Fact]
        public void ContainsKey_When_key_exists_in_Dictionary_It_should_not_throw()
        {
            var dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.ContainsKey(dict, "B", ParamName),
                () => EnsureArg.ContainsKey(dict, "B", ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey("B"));
        }

        [Fact]
        public void ContainsKey_When_key_does_not_exist_in_IDictionary_It_throws_ArgumentException()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };
            const string expectedKey = "Foo";

            AssertContainsKey(
                expectedKey,
                () => Ensure.Collection.ContainsKey(dict, expectedKey, ParamName),
                () => EnsureArg.ContainsKey(dict, expectedKey, ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey(expectedKey));
        }

        [Fact]
        public void ContainsKey_When_key_exists_in_IDictionary_It_should_not_throw()
        {
            IDictionary<string, int> dict = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };

            ShouldNotThrow(
                () => Ensure.Collection.ContainsKey(dict, "B", ParamName),
                () => EnsureArg.ContainsKey(dict, "B", ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey("B"));
        }

        [Fact]
        public void ContainsKey_When_Dictionary_is_null_It_should_throw_ArgumentNullException()
        {
            Dictionary<string, int> dict = null;

            AssertIsNotNull(
                () => Ensure.Collection.ContainsKey(dict, "B", ParamName),
                () => EnsureArg.ContainsKey(dict, "B", ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey("B"));
        }

        [Fact]
        public void ContainsKey_When_IDictionary_is_null_It_should_throw_ArgumentNullException()
        {
            IDictionary<string, int> dict = null;

            AssertIsNotNull(
                () => Ensure.Collection.ContainsKey(dict,"B", ParamName),
                () => EnsureArg.ContainsKey(dict, "B", ParamName),
                () => Ensure.That(dict, ParamName).ContainsKey("B"));
        }

        [Fact]
        public void HasAny_When_IList_predicate_yields_none_It_throws_ArgumentException()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_IList_predicate_yields_something_It_should_not_throw()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 1;

            ShouldNotThrow(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_List_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_List_predicate_yields_something_It_should_not_throw()
        {
            var values = new List<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 1;

            ShouldNotThrow(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_ICollection_predicate_yields_none_It_throws_ArgumentException()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_ICollection_predicate_yields_something_It_should_not_throw()
        {
            ICollection<int> values = new Collection<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 1;

            ShouldNotThrow(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Collection_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new Collection<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Collection_predicate_yields_something_It_should_not_throw()
        {
            var values = new Collection<int> { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 1;

            ShouldNotThrow(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Array_predicate_yields_none_It_throws_ArgumentException()
        {
            var values = new[] { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 0;

            AssertAnyPredicateYieldedNone(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Array_predicate_yields_something_It_should_not_throw()
        {
            var values = new[] { 1, 2, 3, 4 };
            Func<int, bool> predicate = i => i == 1;

            ShouldNotThrow(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Array_is_null_It_throws_ArgumentNullException()
        {
            int[] values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Collection_is_null_It_throws_ArgumentNullException()
        {
            Collection<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_ICollection_is_null_It_throws_ArgumentNullException()
        {
            ICollection<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_List_is_null_It_throws_ArgumentNullException()
        {
            List<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_IList_is_null_It_throws_ArgumentNullException()
        {
            IList<int> values = null;
            Func<int, bool> predicate = i => i == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_Dictionary_is_null_It_throws_ArgumentNullException()
        {
            Dictionary<int, int> values = null;
            Func<KeyValuePair<int, int>, bool> predicate = i => i.Value == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAny_When_IDictionary_is_null_It_throws_ArgumentNullException()
        {
            IDictionary<int, int> values = null;
            Func<KeyValuePair<int, int>, bool> predicate = i => i.Value == 0;

            AssertIsNotNull(
                () => Ensure.Collection.HasAny(values, predicate, ParamName),
                () => EnsureArg.HasAny(values, predicate, ParamName),
                () => Ensure.That(values, ParamName).HasAny(predicate));
        }

        [Fact]
        public void HasAllNotNullItems_WhenNullICollection_ThrowsArgumentNullException()
        {
            var nullCollection = null as ICollection<string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotNullItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenEmptyICollection_ThrowsArgumentException()
        {
            ICollection<string> emptyCollection = new Collection<string>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotNullItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithNullItemsCollection))]
        public void HasAllNotNullItems_WhenWithNullItemICollection_ThrowsArgumentException(string[] testCollection)
        {
            ICollection<string> collectionWithNullItem = new Collection<string>(testCollection);

            AssertHasNullItemsCollection(
                () => Ensure.Collection.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => EnsureArg.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => Ensure.That(collectionWithNullItem, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithoutNullItemsCollection))]
        public void HasAllNotNullItems_WhenNonWithNullItemICollection_ShouldNotThrow(string[] testCollection)
        {
            ICollection<string> collection = new Collection<string>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotNullItems(collection, ParamName),
                () => EnsureArg.HasAllNotNullItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenNullIReadOnlyCollection_ThrowsArgumentNullException()
        {
            var nullCollection = null as IReadOnlyCollection<string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotNullItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenEmptyIReadOnlyCollection_ThrowsArgumentException()
        {
            IReadOnlyCollection<string> emptyCollection = new List<string>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotNullItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithNullItemsCollection))]
        public void HasAllNotNullItems_WhenWithNullItemIReadOnlyCollection_ThrowsArgumentException(string[] testCollection)
        {
            IReadOnlyCollection<string> collectionWithNullItem = new List<string>(testCollection);

            AssertHasNullItemsCollection(
                () => Ensure.Collection.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => EnsureArg.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => Ensure.That(collectionWithNullItem, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithoutNullItemsCollection))]
        public void HasAllNotNullItems_WhenNonWithNullItemIReadOnlyCollection_ShouldNotThrow(string[] testCollection)
        {
            IReadOnlyCollection<string> collection = new List<string>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotNullItems(collection, ParamName),
                () => EnsureArg.HasAllNotNullItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenNullIReadOnlyList_ThrowsArgumentNullException()
        {
            var nullCollection = null as IReadOnlyList<string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotNullItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenEmptyIReadOnlyList_ThrowsArgumentException()
        {
            IReadOnlyList<string> emptyCollection = new List<string>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotNullItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithNullItemsCollection))]
        public void HasAllNotNullItems_WhenWithNullItemIReadOnlyList_ThrowsArgumentException(string[] testCollection)
        {
            IReadOnlyList<string> collectionWithNullItem = new List<string>(testCollection);

            AssertHasNullItemsCollection(
                () => Ensure.Collection.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => EnsureArg.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => Ensure.That(collectionWithNullItem, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithoutNullItemsCollection))]
        public void HasAllNotNullItems_WhenNonWithNullItemIReadOnlyList_ShouldNotThrow(string[] testCollection)
        {
            IReadOnlyList<string> collection = new List<string>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotNullItems(collection, ParamName),
                () => EnsureArg.HasAllNotNullItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenNullISet_ThrowsArgumentNullException()
        {
            var nullCollection = null as ISet<string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotNullItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenEmptyISet_ThrowsArgumentException()
        {
            ISet<string> emptyCollection = new HashSet<string>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotNullItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithNullItemsCollection))]
        public void HasAllNotNullItems_WhenWithNullItemISet_ThrowsArgumentException(string[] testCollection)
        {
            ISet<string> collectionWithNullItem = new HashSet<string>(testCollection);

            AssertHasNullItemsCollection(
                () => Ensure.Collection.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => EnsureArg.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => Ensure.That(collectionWithNullItem, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithoutNullItemsCollection))]
        public void HasAllNotNullItems_WhenNonWithNullItemISet_ShouldNotThrow(string[] testCollection)
        {
            ISet<string> collection = new HashSet<string>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotNullItems(collection, ParamName),
                () => EnsureArg.HasAllNotNullItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenNullArray_ThrowsArgumentNullException()
        {
            var nullCollection = null as string[];

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotNullItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenEmptyArray_ThrowsArgumentException()
        {
            string[] emptyCollection = [];

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotNullItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithNullItemsCollection))]
        public void HasAllNotNullItems_WhenWithNullItemArray_ThrowsArgumentException(string[] testCollection)
        {
            var collectionWithNullItem = testCollection.ToArray();

            AssertHasNullItemsCollection(
                () => Ensure.Collection.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => EnsureArg.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => Ensure.That(collectionWithNullItem, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithoutNullItemsCollection))]
        public void HasAllNotNullItems_WhenNonWithNullItemArray_ShouldNotThrow(string[] testCollection)
        {
            var collection = testCollection.ToArray();

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotNullItems(collection, ParamName),
                () => EnsureArg.HasAllNotNullItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenNullIList_ThrowsArgumentNullException()
        {
            var nullCollection = null as IList<string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotNullItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenEmptyIList_ThrowsArgumentException()
        {
            IList<string> emptyCollection = new List<string>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotNullItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithNullItemsCollection))]
        public void HasAllNotNullItems_WhenWithNullItemIList_ThrowsArgumentException(string[] testCollection)
        {
            IList<string> collectionWithNullItem = new List<string>(testCollection);

            AssertHasNullItemsCollection(
                () => Ensure.Collection.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => EnsureArg.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => Ensure.That(collectionWithNullItem, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithoutNullItemsCollection))]
        public void HasAllNotNullItems_WhenNonWithNullItemIList_ShouldNotThrow(string[] testCollection)
        {
            IList<string> collection = new List<string>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotNullItems(collection, ParamName),
                () => EnsureArg.HasAllNotNullItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenNullCollection_ThrowsArgumentNullException()
        {
            var nullCollection = null as Collection<string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotNullItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenEmptyCollection_ThrowsArgumentException()
        {
            var emptyCollection = new Collection<string>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotNullItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithNullItemsCollection))]
        public void HasAllNotNullItems_WhenWithNullItemCollection_ThrowsArgumentException(string[] testCollection)
        {
            var collectionWithNullItem = new Collection<string>(testCollection);

            AssertHasNullItemsCollection(
                () => Ensure.Collection.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => EnsureArg.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => Ensure.That(collectionWithNullItem, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithoutNullItemsCollection))]
        public void HasAllNotNullItems_WhenNonWithNullItemCollection_ShouldNotThrow(string[] testCollection)
        {
            var collection = new Collection<string>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotNullItems(collection, ParamName),
                () => EnsureArg.HasAllNotNullItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenNullList_ThrowsArgumentNullException()
        {
            var nullCollection = null as List<string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotNullItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenEmptyList_ThrowsArgumentException()
        {
            var emptyCollection = new List<string>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotNullItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithNullItemsCollection))]
        public void HasAllNotNullItems_WhenWithNullItemList_ThrowsArgumentException(string[] testCollection)
        {
            var collectionWithNullItem = new List<string>(testCollection);

            AssertHasNullItemsCollection(
                () => Ensure.Collection.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => EnsureArg.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => Ensure.That(collectionWithNullItem, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithoutNullItemsCollection))]
        public void HasAllNotNullItems_WhenNonWithNullItemList_ShouldNotThrow(string[] testCollection)
        {
            var collection = new List<string>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotNullItems(collection, ParamName),
                () => EnsureArg.HasAllNotNullItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenNullHashSet_ThrowsArgumentNullException()
        {
            var nullCollection = null as HashSet<string>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotNullItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotNullItems_WhenEmptyHashSet_ThrowsArgumentException()
        {
            var emptyCollection = new HashSet<string>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotNullItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotNullItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithNullItemsCollection))]
        public void HasAllNotNullItems_WhenWithNullItemHashSet_ThrowsArgumentException(string[] testCollection)
        {
            var collectionWithNullItem = new HashSet<string>(testCollection);

            AssertHasNullItemsCollection(
                () => Ensure.Collection.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => EnsureArg.HasAllNotNullItems(collectionWithNullItem, ParamName),
                () => Ensure.That(collectionWithNullItem, ParamName).HasAllNotNullItems());
        }

        [Theory]
        [ClassData(typeof(WithoutNullItemsCollection))]
        public void HasAllNotNullItems_WhenNonWithNullItemHashSet_ShouldNotThrow(string[] testCollection)
        {
            var collection = new HashSet<string>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotNullItems(collection, ParamName),
                () => EnsureArg.HasAllNotNullItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotNullItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenDefaultICollection_ThrowsArgumentDefaultException()
        {
            var nullCollection = null as ICollection<Guid>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotDefaultItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenEmptyICollection_ThrowsArgumentException()
        {
            ICollection<Guid> emptyCollection = new Collection<Guid>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenWithDefaultItemICollection_ThrowsArgumentException(Guid[] testCollection)
        {
            ICollection<Guid> collectionWithDefaultItem = new Collection<Guid>(testCollection);

            AssertHasDefaultItemsCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => Ensure.That(collectionWithDefaultItem, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithoutDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenNonWithDefaultItemICollection_ShouldNotThrow(Guid[] testCollection)
        {
            ICollection<Guid> collection = new Collection<Guid>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotDefaultItems(collection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenDefaultIReadOnlyCollection_ThrowsArgumentDefaultException()
        {
            var nullCollection = null as IReadOnlyCollection<Guid>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotDefaultItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenEmptyIReadOnlyCollection_ThrowsArgumentException()
        {
            IReadOnlyCollection<Guid> emptyCollection = new List<Guid>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenWithDefaultItemIReadOnlyCollection_ThrowsArgumentException(Guid[] testCollection)
        {
            IReadOnlyCollection<Guid> collectionWithDefaultItem = new List<Guid>(testCollection);

            AssertHasDefaultItemsCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => Ensure.That(collectionWithDefaultItem, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithoutDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenNonWithDefaultItemIReadOnlyCollection_ShouldNotThrow(Guid[] testCollection)
        {
            IReadOnlyCollection<Guid> collection = new List<Guid>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotDefaultItems(collection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenDefaultIReadOnlyList_ThrowsArgumentDefaultException()
        {
            var nullCollection = null as IReadOnlyList<Guid>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotDefaultItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenEmptyIReadOnlyList_ThrowsArgumentException()
        {
            IReadOnlyList<Guid> emptyCollection = new List<Guid>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenWithDefaultItemIReadOnlyList_ThrowsArgumentException(Guid[] testCollection)
        {
            IReadOnlyList<Guid> collectionWithDefaultItem = new List<Guid>(testCollection);

            AssertHasDefaultItemsCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => Ensure.That(collectionWithDefaultItem, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithoutDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenNonWithDefaultItemIReadOnlyList_ShouldNotThrow(Guid[] testCollection)
        {
            IReadOnlyList<Guid> collection = new List<Guid>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotDefaultItems(collection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenDefaultISet_ThrowsArgumentDefaultException()
        {
            var nullCollection = null as ISet<Guid>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotDefaultItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenEmptyISet_ThrowsArgumentException()
        {
            ISet<Guid> emptyCollection = new HashSet<Guid>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenWithDefaultItemISet_ThrowsArgumentException(Guid[] testCollection)
        {
            ISet<Guid> collectionWithDefaultItem = new HashSet<Guid>(testCollection);

            AssertHasDefaultItemsCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => Ensure.That(collectionWithDefaultItem, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithoutDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenNonWithDefaultItemISet_ShouldNotThrow(Guid[] testCollection)
        {
            ISet<Guid> collection = new HashSet<Guid>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotDefaultItems(collection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenDefaultArray_ThrowsArgumentDefaultException()
        {
            var nullCollection = null as Guid[];

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotDefaultItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenEmptyArray_ThrowsArgumentException()
        {
            Guid[] emptyCollection = [];

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenWithDefaultItemArray_ThrowsArgumentException(Guid[] testCollection)
        {
            var collectionWithDefaultItem = testCollection.ToArray();

            AssertHasDefaultItemsCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => Ensure.That(collectionWithDefaultItem, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithoutDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenNonWithDefaultItemArray_ShouldNotThrow(Guid[] testCollection)
        {
            var collection = testCollection.ToArray();

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotDefaultItems(collection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenDefaultIList_ThrowsArgumentDefaultException()
        {
            var nullCollection = null as IList<Guid>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotDefaultItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenEmptyIList_ThrowsArgumentException()
        {
            IList<Guid> emptyCollection = new List<Guid>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenWithDefaultItemIList_ThrowsArgumentException(Guid[] testCollection)
        {
            IList<Guid> collectionWithDefaultItem = new List<Guid>(testCollection);

            AssertHasDefaultItemsCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => Ensure.That(collectionWithDefaultItem, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithoutDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenNonWithDefaultItemIList_ShouldNotThrow(Guid[] testCollection)
        {
            IList<Guid> collection = new List<Guid>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotDefaultItems(collection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenDefaultCollection_ThrowsArgumentDefaultException()
        {
            var nullCollection = null as Collection<Guid>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotDefaultItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenEmptyCollection_ThrowsArgumentException()
        {
            var emptyCollection = new Collection<Guid>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenWithDefaultItemCollection_ThrowsArgumentException(Guid[] testCollection)
        {
            var collectionWithDefaultItem = new Collection<Guid>(testCollection);

            AssertHasDefaultItemsCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => Ensure.That(collectionWithDefaultItem, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithoutDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenNonWithDefaultItemCollection_ShouldNotThrow(Guid[] testCollection)
        {
            var collection = new Collection<Guid>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotDefaultItems(collection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenDefaultList_ThrowsArgumentDefaultException()
        {
            var nullCollection = null as List<Guid>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotDefaultItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenEmptyList_ThrowsArgumentException()
        {
            var emptyCollection = new List<Guid>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenWithDefaultItemList_ThrowsArgumentException(Guid[] testCollection)
        {
            var collectionWithDefaultItem = new List<Guid>(testCollection);

            AssertHasDefaultItemsCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => Ensure.That(collectionWithDefaultItem, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithoutDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenNonWithDefaultItemList_ShouldNotThrow(Guid[] testCollection)
        {
            var collection = new List<Guid>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotDefaultItems(collection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenDefaultHashSet_ThrowsArgumentDefaultException()
        {
            var nullCollection = null as HashSet<Guid>;

            AssertIsNotNull(
                () => Ensure.Collection.HasAllNotDefaultItems(nullCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(nullCollection, ParamName),
                () => Ensure.That(nullCollection, ParamName).HasAllNotDefaultItems());
        }

        [Fact]
        public void HasAllNotDefaultItems_WhenEmptyHashSet_ThrowsArgumentException()
        {
            var emptyCollection = new HashSet<Guid>();

            AssertIsEmptyCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(emptyCollection, ParamName),
                () => Ensure.That(emptyCollection, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenWithDefaultItemHashSet_ThrowsArgumentException(Guid[] testCollection)
        {
            var collectionWithDefaultItem = new HashSet<Guid>(testCollection);

            AssertHasDefaultItemsCollection(
                () => Ensure.Collection.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collectionWithDefaultItem, ParamName),
                () => Ensure.That(collectionWithDefaultItem, ParamName).HasAllNotDefaultItems());
        }

        [Theory]
        [ClassData(typeof(WithoutDefaultItemsCollection))]
        public void HasAllNotDefaultItems_WhenNonWithDefaultItemHashSet_ShouldNotThrow(Guid[] testCollection)
        {
            var collection = new HashSet<Guid>(testCollection);

            ShouldNotThrow(
                () => Ensure.Collection.HasAllNotDefaultItems(collection, ParamName),
                () => EnsureArg.HasAllNotDefaultItems(collection, ParamName),
                () => Ensure.That(collection, ParamName).HasAllNotDefaultItems());
        }

        private void AssertIsEmptyCollection(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_HasItemsFailed, actions);

        private void AssertHasNullItemsCollection(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_HasAllNotNullItems_Failed, actions);

        private void AssertHasDefaultItemsCollection(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_HasAllNotDefaultItems_Failed, actions);

        private void AssertIsNotNull(params Action[] actions) => ShouldThrow<ArgumentNullException>(ExceptionMessages.Common_IsNotNull_Failed, actions);

        private void AssertSizeIsWrong(int actualSize, int expectedSize, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_SizeIs_Failed, expectedSize, actualSize), actions);

        private void AssertContainsKey(string expectedKey, params Action[] actions)
            => ShouldThrow<ArgumentException>(string.Format(ExceptionMessages.Collections_ContainsKey_Failed, expectedKey), actions);

        private void AssertAnyPredicateYieldedNone(params Action[] actions) => ShouldThrow<ArgumentException>(ExceptionMessages.Collections_Any_Failed, actions);

        public class WithNullItemsCollection : TheoryData<string[]>
        {
            public WithNullItemsCollection()
            {
                Add([null]);
                Add([null, null]);
                Add(["not null", null, "not null"]);
                Add(["not null", null, null]);
            }
        }

        public class WithoutNullItemsCollection : TheoryData<string[]>
        {
            public WithoutNullItemsCollection()
            {
                Add(["not null"]);
                Add(["not null", "not null"]);
                Add(["not null", "not null", "not null"]);
            }
        }

        public class WithDefaultItemsCollection : TheoryData<Guid[]>
        {
            public WithDefaultItemsCollection()
            {
                Add([Guid.Empty]);
                Add([Guid.Empty, Guid.Empty]);
                Add([Guid.NewGuid(), Guid.Empty, Guid.NewGuid()]);
                Add([Guid.NewGuid(), Guid.Empty, Guid.Empty]);
            }
        }

        public class WithoutDefaultItemsCollection : TheoryData<Guid[]>
        {
            public WithoutDefaultItemsCollection()
            {
                Add([Guid.NewGuid()]);
                Add([Guid.NewGuid(), Guid.NewGuid()]);
                Add([Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()]);
            }
        }
    }
}
