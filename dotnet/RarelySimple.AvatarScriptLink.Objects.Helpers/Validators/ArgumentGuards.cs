using System;
using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Validators
{
    /// <summary>
    /// Shared guard helpers for argument validation and normalization used by helper extension methods.
    /// </summary>
    public static class ArgumentGuards
    {
        internal const string NoMatchingFieldObjectsMessage = "No matching field objects were found.";
        private const string NoFieldObjectsProvidedMessage = "No field objects were provided.";
        private const string NoFieldNumbersProvidedMessage = "No field numbers were provided.";
        private const string FieldNumberCannotBeEmptyMessage = "Field number cannot be empty.";

        public static void ValidateFieldNumber(string fieldNumber, string paramName)
        {
            if (fieldNumber == null)
                throw new ArgumentNullException(paramName);

            if (fieldNumber.Length == 0)
                throw new ArgumentException(FieldNumberCannotBeEmptyMessage, paramName);
        }

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
