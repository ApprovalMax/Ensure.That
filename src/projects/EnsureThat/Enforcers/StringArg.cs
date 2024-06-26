﻿using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureThat.Enforcers
{
    public sealed class StringArg
    {
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public string IsNotNull([ValidatedNotNull, NotNull]string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public string IsNotNullOrWhiteSpace([ValidatedNotNull, NotNull]string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (string.IsNullOrWhiteSpace(value))
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotNullOrWhiteSpace_Failed, paramName, optsFn);

            return value;
        }

        [return: NotNull]
        public string IsNotNullOrEmpty([ValidatedNotNull, NotNull]string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (string.IsNullOrEmpty(value))
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotNullOrEmpty_Failed, paramName, optsFn);

            return value;
        }

        public string IsNotEmptyOrWhiteSpace(string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (value == null)
            {
                return null;
            }

            if (value.Length == 0)
            {
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotEmptyOrWhiteSpace_Failed, paramName, optsFn);
            }
            foreach (var t in value)
            {
                if (!Char.IsWhiteSpace(t))
                {
                    return value; //succeed and return as soon as we see a non-whitespace character
                }
            }
            throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotEmptyOrWhiteSpace_Failed, paramName, optsFn);
        }

        public string IsNotEmpty(string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (value?.Length == 0)
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotEmpty_Failed, paramName, optsFn);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public string HasLength([ValidatedNotNull, NotNull]string value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (value.Length != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_SizeIs_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public string HasLengthBetween([ValidatedNotNull, NotNull]string value, int minLength, int maxLength, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            var length = value.Length;

            if (length < minLength)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_HasLengthBetween_Failed_ToShort, minLength, maxLength, length),
                    paramName,
                    optsFn);

            if (length > maxLength)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_HasLengthBetween_Failed_ToLong, minLength, maxLength, length),
                    paramName,
                    optsFn);

            return value;
        }

        [return: NotNull]
        public string Matches(string value, [RegexPattern] string match, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => Matches(value, new Regex(match), paramName, optsFn);

        [return: NotNull]
        public string Matches(string value, Regex match, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (!match.IsMatch(value))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_Matches_Failed, value, match),
                    paramName,
                    optsFn);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        [Obsolete("Use 'HasLength' instead. This will be removed in an upcoming version.")]
        public string SizeIs([ValidatedNotNull, NotNull] string value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => HasLength(value, expected, paramName, optsFn);

        public string Is(string value, string expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => IsEqualTo(value, expected, paramName, optsFn);

        public string IsEqualTo(string value, string expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (!StringEquals(value, expected))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_IsEqualTo_Failed, value, expected),
                    paramName,
                    optsFn);

            return value;
        }

        public string Is(string value, string expected, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => IsEqualTo(value, expected, comparison, paramName, optsFn);

        public string IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (!StringEquals(value, expected, comparison))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_IsEqualTo_Failed, value, expected),
                    paramName,
                    optsFn);

            return value;
        }

        public string IsNot(string value, string notExpected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => IsNotEqualTo(value, notExpected, paramName, optsFn);

        public string IsNotEqualTo(string value, string notExpected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (StringEquals(value, notExpected))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_IsNotEqualTo_Failed, value, notExpected),
                    paramName,
                    optsFn);

            return value;
        }

        public string IsNot(string value, string notExpected, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
            => IsNotEqualTo(value, notExpected, comparison, paramName, optsFn);

        public string IsNotEqualTo(string value, string notExpected, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (StringEquals(value, notExpected, comparison))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_IsNotEqualTo_Failed, value, notExpected),
                    paramName,
                    optsFn);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public Guid IsGuid([ValidatedNotNull, NotNull]string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (!Guid.TryParse(value, out var parsed))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_IsGuid_Failed, value),
                    paramName,
                    optsFn);

            return parsed;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public string StartsWith([ValidatedNotNull, NotNull]string value, [NotNull] string expectedStartsWith, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (!value.StartsWith(expectedStartsWith))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_StartsWith_Failed, value, expectedStartsWith),
                    paramName,
                    optsFn);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public string StartsWith([ValidatedNotNull, NotNull]string value, [NotNull] string expectedStartsWith, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (!value.StartsWith(expectedStartsWith, comparison))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_StartsWith_Failed, value, expectedStartsWith),
                    paramName,
                    optsFn);

            return value;
        }

        public string IsLt(string value, string limit, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (!StringIsLt(value, limit, comparison))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value, optsFn);

            return value;
        }

        public string IsLte(string value, string limit, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (StringIsGt(value, limit, comparison))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value, optsFn);

            return value;
        }

        public string IsGt(string value, string limit, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (!StringIsGt(value, limit, comparison))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value, optsFn);

            return value;
        }

        public string IsGte(string value, string limit, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (StringIsLt(value, limit, comparison))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value, optsFn);

            return value;
        }

        public string IsInRange(string value, string min, string max, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            if (StringIsLt(value, min, comparison))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value, optsFn);

            if (StringIsGt(value, max, comparison))
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value, optsFn);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public string IsAllLettersOrDigits([ValidatedNotNull, NotNull] string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            for (var i = 0; i < value.Length; i++)
                if (!char.IsLetterOrDigit(value[i]))
                    throw Ensure.ExceptionFactory.ArgumentException(
                        string.Format(ExceptionMessages.Strings_IsAllLettersOrDigits_Failed, value),
                        paramName,
                        optsFn);

            return value;
        }

        private static bool StringEquals(string x, string y)
            => string.Equals(x, y);

        private static bool StringEquals(string x, string y, StringComparison comparison)
            => string.Equals(x, y, comparison);

        private static bool StringIsLt(string x, string y, StringComparison c)
            => string.Compare(x, y, c) < 0;

        private static bool StringIsGt(string x, string y, StringComparison c)
            => string.Compare(x, y, c) > 0;
    }
}
