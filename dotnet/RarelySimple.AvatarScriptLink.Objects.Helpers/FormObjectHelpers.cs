using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers
{
    /// <summary>
    /// Provides extension methods for querying and manipulating <see cref="FormObject"/> instances.
    /// </summary>
    public static class FormObjectHelpers
    {
        /// <summary>
        /// Gets the form ID of a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <returns>The form ID, or null if not set.</returns>
        public static string? GetFormId(this FormObject formObject)
        {
            return formObject?.FormId;
        }

        /// <summary>
        /// Determines if a <see cref="FormObject"/> supports multiple iteration.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <returns>True if the form supports multiple iteration, false otherwise.</returns>
        public static bool IsMultipleIteration(this FormObject formObject)
        {
            return formObject?.MultipleIteration ?? false;
        }

        /// <summary>
        /// Gets the total number of rows in a <see cref="FormObject"/> (current + other rows).
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <returns>The total number of rows.</returns>
        public static int GetRowCount(this FormObject formObject)
        {
            if (formObject == null)
            {
                return 0;
            }

            int count = 0;
            if (formObject.HasCurrentRow())
            {
                count++;
            }
            if (formObject.HasOtherRows())
            {
                count += formObject.OtherRows.Count;
            }
            return count;
        }

        /// <summary>
        /// Gets the current row ID of a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <returns>The current row ID, or null if not set.</returns>
        public static string? GetCurrentRowId(this FormObject formObject)
        {
            return formObject?.CurrentRow?.RowId;
        }

        /// <summary>
        /// Gets the parent row ID of a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <returns>The parent row ID, or null if not set.</returns>
        public static string? GetParentRowId(this FormObject formObject)
        {
            return formObject?.CurrentRow?.ParentRowId;
        }

        /// <summary>
        /// Gets the field value of a <see cref="FieldObject"/> in the current row of a <see cref="FormObject"/> by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>The field value, or null if not found.</returns>
        public static string? GetFieldValue(this FormObject formObject, string fieldNumber)
        {
            if (formObject?.CurrentRow == null || string.IsNullOrEmpty(fieldNumber))
                return null;

            return formObject.CurrentRow.GetFieldValue(fieldNumber);
        }

        /// <summary>
        /// Gets the field value of a <see cref="FieldObject"/> in a <see cref="FormObject"/> by row ID and field number.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <param name="rowId">The row ID to search for.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>The field value, or null if not found.</returns>
        public static string? GetFieldValue(this FormObject formObject, string rowId, string fieldNumber)
        {
            if (formObject?.CurrentRow == null || string.IsNullOrEmpty(rowId) || string.IsNullOrEmpty(fieldNumber))
                return null;

            if (formObject.CurrentRow.RowId == rowId)
                return formObject.CurrentRow.GetFieldValue(fieldNumber);

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows)
                {
                    if (row.RowId == rowId)
                        return row.GetFieldValue(fieldNumber);
                }
            }

            return null;
        }

        /// <summary>
        /// Gets a list of field values for a specified field number across all rows in a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>A list of field values, or empty list if not found.</returns>
        public static List<string> GetFieldValues(this FormObject formObject, string fieldNumber)
        {
            var values = new List<string>();

            if (formObject?.CurrentRow == null || string.IsNullOrEmpty(fieldNumber))
                return values;

            AddFieldValueIfPresent(values, formObject.CurrentRow, fieldNumber);

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows)
                {
                    AddFieldValueIfPresent(values, row, fieldNumber);
                }
            }

            return values;
        }

        /// <summary>
        /// Adds a field value to a list if the field is present in the row.
        /// </summary>
        /// <param name="values">The list to add the value to.</param>
        /// <param name="row">The RowObject to search.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        private static void AddFieldValueIfPresent(List<string> values, RowObject row, string fieldNumber)
        {
            if (row.IsFieldPresent(fieldNumber))
            {
                var value = row.GetFieldValue(fieldNumber);
                if (value != null)
                    values.Add(value);
            }
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> is present in the current row of a <see cref="FormObject"/> by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is present, false otherwise.</returns>
        public static bool IsFieldPresent(this FormObject formObject, string fieldNumber)
        {
            if (formObject?.CurrentRow == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return formObject.CurrentRow.IsFieldPresent(fieldNumber);
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> in the current row of a <see cref="FormObject"/> is enabled by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is enabled, false if disabled or not found.</returns>
        public static bool IsFieldEnabled(this FormObject formObject, string fieldNumber)
        {
            if (formObject?.CurrentRow == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return formObject.CurrentRow.IsFieldEnabled(fieldNumber);
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> in the current row of a <see cref="FormObject"/> is locked by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is locked, false if not locked or not found.</returns>
        public static bool IsFieldLocked(this FormObject formObject, string fieldNumber)
        {
            if (formObject?.CurrentRow == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return formObject.CurrentRow.IsFieldLocked(fieldNumber);
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> in the current row of a <see cref="FormObject"/> is required by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is required, false if not required or not found.</returns>
        public static bool IsFieldRequired(this FormObject formObject, string fieldNumber)
        {
            if (formObject?.CurrentRow == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return formObject.CurrentRow.IsFieldRequired(fieldNumber);
        }

        /// <summary>
        /// Determines if a <see cref="RowObject"/> in a <see cref="FormObject"/> is marked for deletion by row ID.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <param name="rowId">The row ID to search for.</param>
        /// <returns>True if the row is marked for deletion, false otherwise.</returns>
        public static bool IsRowMarkedForDeletion(this FormObject formObject, string rowId)
        {
            if (formObject == null || formObject.CurrentRow == null || string.IsNullOrEmpty(rowId))
                return false;

            if (formObject.CurrentRow.RowId == rowId)
                return formObject.CurrentRow.IsMarkedForDeletion();

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                return formObject.OtherRows
                    .Any(r => r.RowId == rowId && r.IsMarkedForDeletion());
            }

            return false;
        }

        /// <summary>
        /// Determines if a <see cref="RowObject"/> is present in a <see cref="FormObject"/> by row ID.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <param name="rowId">The row ID to search for.</param>
        /// <returns>True if the row is present, false otherwise.</returns>
        public static bool IsRowPresent(this FormObject formObject, string rowId)
        {
            if (formObject == null || formObject.CurrentRow == null || string.IsNullOrEmpty(rowId))
                return false;

            if (formObject.CurrentRow.RowId == rowId)
                return true;

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                return formObject.OtherRows.Any(r => r.RowId == rowId);
            }

            return false;
        }

        /// <summary>
        /// Sets the field value of a <see cref="FieldObject"/> in the current row of a <see cref="FormObject"/> by field number.
        /// If the form is multiple iteration with other rows, this method does nothing (row must be specified).
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <param name="fieldValue">The new field value.</param>
        /// <returns>The modified FormObject, or the original if the field is not found.</returns>
        public static FormObject? SetFieldValue(this FormObject formObject, string fieldNumber, string fieldValue)
        {
            if (formObject == null || formObject.CurrentRow == null || string.IsNullOrEmpty(fieldNumber))
                return formObject;

            // Prevent ambiguity for MI forms with multiple rows
            if (formObject.MultipleIteration && formObject.HasOtherRows())
                return formObject;

            formObject.CurrentRow.SetFieldValue(fieldNumber, fieldValue);
            return formObject;
        }

        /// <summary>
        /// Sets the field value of a <see cref="FieldObject"/> in a <see cref="FormObject"/> by row ID and field number.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="rowId">The row ID to search for.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <param name="fieldValue">The new field value.</param>
        /// <returns>The modified FormObject, or the original if the row or field is not found.</returns>
        public static FormObject? SetFieldValue(this FormObject formObject, string rowId, string fieldNumber, string fieldValue)
        {
            if (formObject == null || formObject.CurrentRow == null || string.IsNullOrEmpty(rowId) || string.IsNullOrEmpty(fieldNumber))
                return formObject;

            if (formObject.CurrentRow.RowId == rowId)
            {
                formObject.CurrentRow.SetFieldValue(fieldNumber, fieldValue);
                return formObject;
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                var row = formObject.OtherRows.FirstOrDefault(r => r.RowId == rowId);
                if (row != null)
                {
                    row.SetFieldValue(fieldNumber, fieldValue);
                }
            }

            return formObject;
        }
    }
}
