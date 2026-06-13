using System;
using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Validators
{
    /// <summary>
    /// Shared guard helpers for argument validation and normalization used by helper extension methods.
    /// </summary>
    internal static class ArgumentGuards
    {
        internal const string NoMatchingFieldObjectsMessage = StructuralMutationMessages.NoMatchingFieldObjectsMessage;
        internal const string NoFieldObjectsProvidedMessage = "No field objects were provided.";
        internal const string NoFieldNumbersProvidedMessage = "No field numbers were provided.";
        internal const string FieldNumberCannotBeEmptyMessage = "Field number cannot be empty.";

        /// <summary>
        /// Validates a single field number argument.
        /// </summary>
        /// <param name="fieldNumber">The field number value to validate.</param>
        /// <param name="paramName">The parameter name to include in thrown exceptions.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty.</exception>
        public static void ValidateFieldNumber(string fieldNumber, string paramName)
        {
            if (fieldNumber == null)
                throw new ArgumentNullException(paramName);

            if (fieldNumber.Length == 0)
                throw new ArgumentException(FieldNumberCannotBeEmptyMessage, paramName);
        }

        /// <summary>
        /// Validates and normalizes a list of field numbers.
        /// </summary>
        /// <param name="fieldNumbers">The field numbers to validate and normalize.</param>
        /// <param name="paramName">The parameter name to include in thrown exceptions.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty or contains no valid values after normalization.</exception>
        public static List<string> ValidateAndNormalizeFieldNumbers(List<string>? fieldNumbers, string paramName)
        {
            if (fieldNumbers == null)
                throw new ArgumentNullException(paramName);

            if (fieldNumbers.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, paramName);

            var normalized = fieldNumbers
                .Where(f => !string.IsNullOrEmpty(f))
                .Distinct()
                .ToList();

            if (normalized.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, paramName);

            return normalized;
        }

        /// <summary>
        /// Validates a list of field objects and returns distinct field numbers.
        /// </summary>
        /// <param name="fieldObjects">The field objects to validate.</param>
        /// <param name="paramName">The parameter name to include in thrown exceptions.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldObjects"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldObjects"/> is empty or contains no valid field numbers.</exception>
        public static List<string> ValidateAndGetFieldNumbers(List<FieldObject>? fieldObjects, string paramName)
        {
            if (fieldObjects == null)
                throw new ArgumentNullException(paramName);

            if (fieldObjects.Count == 0)
                throw new ArgumentException(NoFieldObjectsProvidedMessage, paramName);

            var fieldNumbers = fieldObjects
                .Where(f => !string.IsNullOrEmpty(f?.FieldNumber))
                .Select(f => f.FieldNumber)
                .Distinct()
                .ToList();

            if (fieldNumbers.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, paramName);

            return fieldNumbers;
        }
    }
}
