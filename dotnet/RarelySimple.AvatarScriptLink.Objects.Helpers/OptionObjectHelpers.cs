using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}
