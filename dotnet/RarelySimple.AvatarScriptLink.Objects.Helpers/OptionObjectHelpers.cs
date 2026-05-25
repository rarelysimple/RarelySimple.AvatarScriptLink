using System;
using System.Collections.Generic;
using System.Linq;
using RarelySimple.AvatarScriptLink.Objects.Helpers.Validators;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers
{
    /// <summary>
    /// Provides extension methods for querying and manipulating <see cref="OptionObject"/> instances.
    /// </summary>
    public static class OptionObjectHelpers
    {
        /// <summary>
        /// Gets the entity ID of an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <returns>The entity ID, or null if not set.</returns>
        public static string? GetEntityId(this OptionObject optionObject)
        {
            return optionObject?.EntityID;
        }

        /// <summary>
        /// Gets the error code of an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <returns>The error code.</returns>
        public static double GetErrorCode(this OptionObject optionObject)
        {
            return optionObject?.ErrorCode ?? 0;
        }

        /// <summary>
        /// Gets the error message of an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <returns>The error message, or null if not set.</returns>
        public static string? GetErrorMessage(this OptionObject optionObject)
        {
            return optionObject?.ErrorMesg;
        }

        /// <summary>
        /// Gets the total number of forms in an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <returns>The number of forms.</returns>
        public static int GetFormCount(this OptionObject optionObject)
        {
            return optionObject?.Forms?.Count ?? 0;
        }

        /// <summary>
        /// Gets a <see cref="FormObject"/> in an <see cref="OptionObject"/> by form ID.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="formId">The form ID to search for.</param>
        /// <returns>The matching form object, or null if not found.</returns>
        public static FormObject? GetFormObject(this OptionObject optionObject, string formId)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(formId))
                return null;

            return optionObject.Forms.FirstOrDefault(f => f.FormId == formId);
        }

        /// <summary>
        /// Determines if an <see cref="OptionObject"/> has an error.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <returns>True if the error code is not 0, false otherwise.</returns>
        public static bool HasError(this OptionObject optionObject)
        {
            return Math.Abs(optionObject?.ErrorCode ?? 0d) > double.Epsilon;
        }

        /// <summary>
        /// Gets the current row ID of a <see cref="FormObject"/> in an <see cref="OptionObject"/> by form ID.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="formId">The form ID to search for.</param>
        /// <returns>The current row ID, or null if not found.</returns>
        public static string? GetCurrentRowId(this OptionObject optionObject, string formId)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(formId))
                return null;

            return optionObject.Forms
                .FirstOrDefault(f => f.FormId == formId)?
                .GetCurrentRowId();
        }

        /// <summary>
        /// Gets the parent row ID of a <see cref="FormObject"/> in an <see cref="OptionObject"/> by form ID.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="formId">The form ID to search for.</param>
        /// <returns>The parent row ID, or null if not found.</returns>
        public static string? GetParentRowId(this OptionObject optionObject, string formId)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(formId))
                return null;

            return optionObject.Forms
                .FirstOrDefault(f => f.FormId == formId)?
                .GetParentRowId();
        }

        /// <summary>
        /// Gets the field value of a <see cref="FieldObject"/> in an <see cref="OptionObject"/> by field number (searches all forms).
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>The field value, or null if not found.</returns>
        public static string? GetFieldValue(this OptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(fieldNumber))
                return null;

            return optionObject.Forms
                .Where(f => f.IsFieldPresent(fieldNumber))
                .Select(f => f.GetFieldValue(fieldNumber))
                .FirstOrDefault();
        }

        /// <summary>
        /// Gets the field value of a <see cref="FieldObject"/> in an <see cref="OptionObject"/> by form ID, row ID, and field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="formId">The form ID to search for.</param>
        /// <param name="rowId">The row ID to search for.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>The field value, or null if not found.</returns>
        public static string? GetFieldValue(this OptionObject optionObject, string formId, string rowId, string fieldNumber)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(formId) || string.IsNullOrEmpty(rowId) || string.IsNullOrEmpty(fieldNumber))
                return null;

            return optionObject.Forms
                .FirstOrDefault(f => f.FormId == formId)?
                .GetFieldValue(rowId, fieldNumber);
        }

        /// <summary>
        /// Gets a list of field values for a specified field number across all rows in all forms in an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>A list of field values, or empty list if not found.</returns>
        public static List<string> GetFieldValues(this OptionObject optionObject, string fieldNumber)
        {
            var values = new List<string>();

            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(fieldNumber))
                return values;

            foreach (var form in optionObject.Forms.Where(f => f.IsFieldPresent(fieldNumber)))
            {
                var formValues = form.GetFieldValues(fieldNumber);
                values.AddRange(formValues);
            }

            return values;
        }

        /// <summary>
        /// Determines if a <see cref="FormObject"/> in an <see cref="OptionObject"/> supports multiple iteration by form ID.
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="formId">The form ID to search for.</param>
        /// <returns>True if the form supports multiple iteration, false otherwise.</returns>
        public static bool GetMultipleIterationStatus(this OptionObject optionObject, string formId)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(formId))
                return false;

            return optionObject.Forms
                .FirstOrDefault(f => f.FormId == formId)?
                .IsMultipleIteration() ?? false;
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> is present in an <see cref="OptionObject"/> by field number (searches all forms).
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is present, false otherwise.</returns>
        public static bool IsFieldPresent(this OptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber));
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> in an <see cref="OptionObject"/> is enabled by field number (searches all forms).
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is enabled, false if disabled or not found.</returns>
        public static bool IsFieldEnabled(this OptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return optionObject.Forms
                .Where(f => f.IsFieldPresent(fieldNumber))
                .Select(f => f.IsFieldEnabled(fieldNumber))
                .FirstOrDefault();
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> in an <see cref="OptionObject"/> is locked by field number (searches all forms).
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is locked, false if not locked or not found.</returns>
        public static bool IsFieldLocked(this OptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return optionObject.Forms
                .Where(f => f.IsFieldPresent(fieldNumber))
                .Select(f => f.IsFieldLocked(fieldNumber))
                .FirstOrDefault();
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> in an <see cref="OptionObject"/> is required by field number (searches all forms).
        /// </summary>
        /// <param name="optionObject">The OptionObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is required, false if not required or not found.</returns>
        public static bool IsFieldRequired(this OptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return optionObject.Forms
                .Where(f => f.IsFieldPresent(fieldNumber))
                .Select(f => f.IsFieldRequired(fieldNumber))
                .FirstOrDefault();
        }

        /// <summary>
        /// Disables a <see cref="FieldObject"/> in an <see cref="OptionObject"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumber">The field number to disable.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetDisabledField(this OptionObject optionObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                form.SetDisabledField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Disables <see cref="FieldObject"/> instances in an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldObjects">The field objects to disable.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldObjects"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldObjects"/> is empty, contains invalid field numbers, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetDisabledFields(this OptionObject optionObject, List<FieldObject>? fieldObjects)
        {
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

            return optionObject.SetDisabledFields(fieldNumbers);
        }

        /// <summary>
        /// Disables <see cref="FieldObject"/> instances in an <see cref="OptionObject"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to disable.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetDisabledFields(this OptionObject optionObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetDisabledFields(formFieldNumbers);
            }

            return optionObject;
        }

        /// <summary>
        /// Enables a <see cref="FieldObject"/> in an <see cref="OptionObject"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumber">The field number to enable.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetEnabledField(this OptionObject optionObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                form.SetEnabledField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Enables <see cref="FieldObject"/> instances in an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldObjects">The field objects to enable.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldObjects"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldObjects"/> is empty, contains invalid field numbers, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetEnabledFields(this OptionObject optionObject, List<FieldObject>? fieldObjects)
        {
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

            return optionObject.SetEnabledFields(fieldNumbers);
        }

        /// <summary>
        /// Enables <see cref="FieldObject"/> instances in an <see cref="OptionObject"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to enable.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetEnabledFields(this OptionObject optionObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetEnabledFields(formFieldNumbers);
            }

            return optionObject;
        }

        /// <summary>
        /// Locks a <see cref="FieldObject"/> in an <see cref="OptionObject"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumber">The field number to lock.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetLockedField(this OptionObject optionObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                form.SetLockedField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Locks <see cref="FieldObject"/> instances in an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldObjects">The field objects to lock.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldObjects"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldObjects"/> is empty, contains invalid field numbers, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetLockedFields(this OptionObject optionObject, List<FieldObject>? fieldObjects)
        {
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

            return optionObject.SetLockedFields(fieldNumbers);
        }

        /// <summary>
        /// Locks <see cref="FieldObject"/> instances in an <see cref="OptionObject"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to lock.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetLockedFields(this OptionObject optionObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetLockedFields(formFieldNumbers);
            }

            return optionObject;
        }

        /// <summary>
        /// Unlocks a <see cref="FieldObject"/> in an <see cref="OptionObject"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumber">The field number to unlock.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetUnlockedField(this OptionObject optionObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                form.SetUnlockedField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Unlocks <see cref="FieldObject"/> instances in an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldObjects">The field objects to unlock.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldObjects"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldObjects"/> is empty, contains invalid field numbers, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetUnlockedFields(this OptionObject optionObject, List<FieldObject>? fieldObjects)
        {
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

            return optionObject.SetUnlockedFields(fieldNumbers);
        }

        /// <summary>
        /// Unlocks <see cref="FieldObject"/> instances in an <see cref="OptionObject"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to unlock.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetUnlockedFields(this OptionObject optionObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetUnlockedFields(formFieldNumbers);
            }

            return optionObject;
        }

        /// <summary>
        /// Marks a <see cref="FieldObject"/> in an <see cref="OptionObject"/> as required by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumber">The field number to mark as required.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetRequiredField(this OptionObject optionObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                if (!form.IsFieldPresent(fieldNumber))
                    continue;

                form.SetRequiredField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Marks <see cref="FieldObject"/> instances in an <see cref="OptionObject"/> as required.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldObjects">The field objects to mark as required.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldObjects"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldObjects"/> is empty, contains invalid field numbers, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetRequiredFields(this OptionObject optionObject, List<FieldObject>? fieldObjects)
        {
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

            return optionObject.SetRequiredFields(fieldNumbers);
        }

        /// <summary>
        /// Marks <see cref="FieldObject"/> instances in an <see cref="OptionObject"/> as required by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to mark as required.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetRequiredFields(this OptionObject optionObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetRequiredFields(formFieldNumbers);
            }

            return optionObject;
        }

        /// <summary>
        /// Marks a <see cref="FieldObject"/> in an <see cref="OptionObject"/> as optional by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumber">The field number to mark as optional.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetOptionalField(this OptionObject optionObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                if (!form.IsFieldPresent(fieldNumber))
                    continue;

                form.SetOptionalField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Marks <see cref="FieldObject"/> instances in an <see cref="OptionObject"/> as optional.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldObjects">The field objects to mark as optional.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldObjects"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldObjects"/> is empty, contains invalid field numbers, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetOptionalFields(this OptionObject optionObject, List<FieldObject>? fieldObjects)
        {
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

            return optionObject.SetOptionalFields(fieldNumbers);
        }

        /// <summary>
        /// Marks <see cref="FieldObject"/> instances in an <see cref="OptionObject"/> as optional by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to mark as optional.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified OptionObject.</returns>
        public static OptionObject? SetOptionalFields(this OptionObject optionObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetOptionalFields(formFieldNumbers);
            }

            return optionObject;
        }
    }
}
