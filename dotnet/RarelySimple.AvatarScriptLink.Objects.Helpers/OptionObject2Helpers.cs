using System;
using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers
{
    /// <summary>
    /// Provides extension methods for querying and manipulating <see cref="OptionObject2"/> instances.
    /// </summary>
    public static class OptionObject2Helpers
    {
        private const string NoMatchingFieldObjectsMessage = "No matching field objects were found.";
        private const string NoFieldObjectsProvidedMessage = "No field objects were provided.";
        private const string NoFieldNumbersProvidedMessage = "No field numbers were provided.";
        private const string FieldNumberCannotBeEmptyMessage = "Field number cannot be empty.";

        /// <summary>
        /// Gets the entity ID of an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to query.</param>
        /// <returns>The entity ID, or null if not set.</returns>
        public static string? GetEntityId(this OptionObject2 optionObject)
        {
            return optionObject?.EntityID;
        }

        /// <summary>
        /// Gets the error code of an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to query.</param>
        /// <returns>The error code.</returns>
        public static double GetErrorCode(this OptionObject2 optionObject)
        {
            return optionObject?.ErrorCode ?? 0;
        }

        /// <summary>
        /// Gets the error message of an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to query.</param>
        /// <returns>The error message, or null if not set.</returns>
        public static string? GetErrorMessage(this OptionObject2 optionObject)
        {
            return optionObject?.ErrorMesg;
        }

        /// <summary>
        /// Gets the total number of forms in an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to query.</param>
        /// <returns>The number of forms.</returns>
        public static int GetFormCount(this OptionObject2 optionObject)
        {
            return optionObject?.Forms?.Count ?? 0;
        }

        /// <summary>
        /// Determines if an <see cref="OptionObject2"/> has an error.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to query.</param>
        /// <returns>True if the error code is not 0, false otherwise.</returns>
        public static bool HasError(this OptionObject2 optionObject)
        {
            return Math.Abs(optionObject?.ErrorCode ?? 0d) > double.Epsilon;
        }

        /// <summary>
        /// Disables a <see cref="FieldObject"/> in an <see cref="OptionObject2"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldNumber">The field number to disable.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetDisabledField(this OptionObject2 optionObject, string fieldNumber)
        {
            if (fieldNumber == null)
                throw new ArgumentNullException(nameof(fieldNumber));

            if (fieldNumber.Length == 0)
                throw new ArgumentException(FieldNumberCannotBeEmptyMessage, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                form.SetDisabledField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Disables <see cref="FieldObject"/> instances in an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldObjects">The field objects to disable.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetDisabledFields(this OptionObject2 optionObject, List<FieldObject>? fieldObjects)
        {
            if (fieldObjects == null)
                throw new ArgumentNullException(nameof(fieldObjects));

            if (fieldObjects.Count == 0)
                throw new ArgumentException(NoFieldObjectsProvidedMessage, nameof(fieldObjects));

            var fieldNumbers = fieldObjects
                .Where(f => !string.IsNullOrEmpty(f?.FieldNumber))
                .Select(f => f.FieldNumber)
                .Distinct()
                .ToList();

            if (fieldNumbers.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldObjects));

            return optionObject.SetDisabledFields(fieldNumbers);
        }

        /// <summary>
        /// Disables <see cref="FieldObject"/> instances in an <see cref="OptionObject2"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldNumbers">The field numbers to disable.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetDisabledFields(this OptionObject2 optionObject, List<string>? fieldNumbers)
        {
            if (fieldNumbers == null)
                throw new ArgumentNullException(nameof(fieldNumbers));

            if (fieldNumbers.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            var fieldsToSet = fieldNumbers
                .Where(f => !string.IsNullOrEmpty(f))
                .Distinct()
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldNumbers));

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                form.SetDisabledFields(fieldsToSet);
            }

            return optionObject;
        }

        /// <summary>
        /// Enables a <see cref="FieldObject"/> in an <see cref="OptionObject2"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldNumber">The field number to enable.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetEnabledField(this OptionObject2 optionObject, string fieldNumber)
        {
            if (fieldNumber == null)
                throw new ArgumentNullException(nameof(fieldNumber));

            if (fieldNumber.Length == 0)
                throw new ArgumentException(FieldNumberCannotBeEmptyMessage, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                form.SetEnabledField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Enables <see cref="FieldObject"/> instances in an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldObjects">The field objects to enable.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetEnabledFields(this OptionObject2 optionObject, List<FieldObject>? fieldObjects)
        {
            if (fieldObjects == null)
                throw new ArgumentNullException(nameof(fieldObjects));

            if (fieldObjects.Count == 0)
                throw new ArgumentException(NoFieldObjectsProvidedMessage, nameof(fieldObjects));

            var fieldNumbers = fieldObjects
                .Where(f => !string.IsNullOrEmpty(f?.FieldNumber))
                .Select(f => f.FieldNumber)
                .Distinct()
                .ToList();

            if (fieldNumbers.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldObjects));

            return optionObject.SetEnabledFields(fieldNumbers);
        }

        /// <summary>
        /// Enables <see cref="FieldObject"/> instances in an <see cref="OptionObject2"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldNumbers">The field numbers to enable.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetEnabledFields(this OptionObject2 optionObject, List<string>? fieldNumbers)
        {
            if (fieldNumbers == null)
                throw new ArgumentNullException(nameof(fieldNumbers));

            if (fieldNumbers.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            var fieldsToSet = fieldNumbers
                .Where(f => !string.IsNullOrEmpty(f))
                .Distinct()
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldNumbers));

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                form.SetEnabledFields(fieldsToSet);
            }

            return optionObject;
        }

        /// <summary>
        /// Locks a <see cref="FieldObject"/> in an <see cref="OptionObject2"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldNumber">The field number to lock.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetLockedField(this OptionObject2 optionObject, string fieldNumber)
        {
            if (fieldNumber == null)
                throw new ArgumentNullException(nameof(fieldNumber));

            if (fieldNumber.Length == 0)
                throw new ArgumentException(FieldNumberCannotBeEmptyMessage, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                form.SetLockedField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Locks <see cref="FieldObject"/> instances in an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldObjects">The field objects to lock.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetLockedFields(this OptionObject2 optionObject, List<FieldObject>? fieldObjects)
        {
            if (fieldObjects == null)
                throw new ArgumentNullException(nameof(fieldObjects));

            if (fieldObjects.Count == 0)
                throw new ArgumentException(NoFieldObjectsProvidedMessage, nameof(fieldObjects));

            var fieldNumbers = fieldObjects
                .Where(f => !string.IsNullOrEmpty(f?.FieldNumber))
                .Select(f => f.FieldNumber)
                .Distinct()
                .ToList();

            if (fieldNumbers.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldObjects));

            return optionObject.SetLockedFields(fieldNumbers);
        }

        /// <summary>
        /// Locks <see cref="FieldObject"/> instances in an <see cref="OptionObject2"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldNumbers">The field numbers to lock.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetLockedFields(this OptionObject2 optionObject, List<string>? fieldNumbers)
        {
            if (fieldNumbers == null)
                throw new ArgumentNullException(nameof(fieldNumbers));

            if (fieldNumbers.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            var fieldsToSet = fieldNumbers
                .Where(f => !string.IsNullOrEmpty(f))
                .Distinct()
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldNumbers));

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                form.SetLockedFields(fieldsToSet);
            }

            return optionObject;
        }

        /// <summary>
        /// Unlocks a <see cref="FieldObject"/> in an <see cref="OptionObject2"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldNumber">The field number to unlock.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetUnlockedField(this OptionObject2 optionObject, string fieldNumber)
        {
            if (fieldNumber == null)
                throw new ArgumentNullException(nameof(fieldNumber));

            if (fieldNumber.Length == 0)
                throw new ArgumentException(FieldNumberCannotBeEmptyMessage, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                form.SetUnlockedField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Unlocks <see cref="FieldObject"/> instances in an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldObjects">The field objects to unlock.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetUnlockedFields(this OptionObject2 optionObject, List<FieldObject>? fieldObjects)
        {
            if (fieldObjects == null)
                throw new ArgumentNullException(nameof(fieldObjects));

            if (fieldObjects.Count == 0)
                throw new ArgumentException(NoFieldObjectsProvidedMessage, nameof(fieldObjects));

            var fieldNumbers = fieldObjects
                .Where(f => !string.IsNullOrEmpty(f?.FieldNumber))
                .Select(f => f.FieldNumber)
                .Distinct()
                .ToList();

            if (fieldNumbers.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldObjects));

            return optionObject.SetUnlockedFields(fieldNumbers);
        }

        /// <summary>
        /// Unlocks <see cref="FieldObject"/> instances in an <see cref="OptionObject2"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to modify.</param>
        /// <param name="fieldNumbers">The field numbers to unlock.</param>
        /// <returns>The modified OptionObject2.</returns>
        public static OptionObject2? SetUnlockedFields(this OptionObject2 optionObject, List<string>? fieldNumbers)
        {
            if (fieldNumbers == null)
                throw new ArgumentNullException(nameof(fieldNumbers));

            if (fieldNumbers.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            var fieldsToSet = fieldNumbers
                .Where(f => !string.IsNullOrEmpty(f))
                .Distinct()
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(NoFieldNumbersProvidedMessage, nameof(fieldNumbers));

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                form.SetUnlockedFields(fieldsToSet);
            }

            return optionObject;
        }
    }
}
