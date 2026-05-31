using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using RarelySimple.AvatarScriptLink.Objects.Helpers.Validators;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers
{
    /// <summary>
    /// Provides extension methods for querying and manipulating <see cref="FormObject"/> instances.
    /// </summary>
    public static class FormObjectHelpers
    {
        private const int MaximumNumberOfMultipleIterationRows = 9999;

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
        /// Gets the next available row ID for a <see cref="FormObject"/> using the pattern <c>formId||n</c>.
        /// </summary>
        /// <param name="formObject">The form object to evaluate.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="formObject"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the form ID is missing or a row ID cannot be determined.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when another row cannot be added due to form constraints.</exception>
        /// <returns>The next available row ID.</returns>
        public static string GetNextAvailableRowId(this FormObject formObject)
        {
            if (formObject == null)
            {
                throw new ArgumentNullException(nameof(formObject));
            }

            if (string.IsNullOrEmpty(formObject.FormId))
            {
                throw new ArgumentException(StructuralMutationMessages.FormIdCannotBeNullOrEmpty, nameof(formObject));
            }

            var currentRow = formObject.CurrentRow;
            var otherRows = formObject.OtherRows ?? new List<RowObject>();

            if (currentRow != null && !formObject.MultipleIteration)
            {
                throw new ArgumentOutOfRangeException(nameof(formObject), "Cannot add another row to a non-multiple-iteration form.");
            }

            for (int i = 1; i <= MaximumNumberOfMultipleIterationRows; i++)
            {
                var candidateRowId = string.Concat(formObject.FormId, "||", i.ToString(CultureInfo.InvariantCulture));
                var isCurrentMatch = currentRow != null && currentRow.RowId == candidateRowId;
                var isOtherMatch = otherRows.Any(r => r != null && r.RowId == candidateRowId);
                if (!isCurrentMatch && !isOtherMatch)
                {
                    return candidateRowId;
                }
            }

            throw new ArgumentOutOfRangeException(nameof(formObject), "Could not determine next available row ID because no allocatable row IDs remain.");
        }

        /// <summary>
        /// Adds a row to a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formObject">The form to modify.</param>
        /// <param name="rowObject">The row to add.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="formObject"/> or <paramref name="rowObject"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when constraints prevent adding the row.</exception>
        /// <returns>The modified form.</returns>
        public static FormObject AddRowObject(this FormObject formObject, RowObject rowObject)
        {
            if (formObject == null)
            {
                throw new ArgumentNullException(nameof(formObject));
            }

            if (rowObject == null)
            {
                throw new ArgumentNullException(nameof(rowObject));
            }

            if (!formObject.MultipleIteration && formObject.CurrentRow != null)
            {
                throw new ArgumentException("Cannot add another row to a non-multiple-iteration form.", nameof(formObject));
            }

            if (!string.IsNullOrEmpty(rowObject.RowId) && formObject.IsRowPresent(rowObject.RowId))
            {
                throw new ArgumentException("A row with the provided RowId already exists.", nameof(rowObject));
            }

            if (formObject.CurrentRow == null)
            {
                if (string.IsNullOrEmpty(rowObject.RowId))
                {
                    rowObject.RowId = formObject.GetNextAvailableRowId();
                }

                formObject.CurrentRow = rowObject;
                return formObject;
            }

            if (string.IsNullOrEmpty(rowObject.RowId))
            {
                rowObject.RowId = formObject.GetNextAvailableRowId();
            }

            if (formObject.OtherRows == null)
            {
                formObject.OtherRows = new List<RowObject>();
            }

            formObject.OtherRows.Add(rowObject);
            return formObject;
        }

        /// <summary>
        /// Adds a new row to a <see cref="FormObject"/> with row action set to <see cref="RowObject.RowActions.Add"/>.
        /// </summary>
        /// <param name="formObject">The form to modify.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="formObject"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when constraints prevent adding the row, such as non-multiple-iteration forms with an existing current row or duplicate row IDs.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when another row cannot be added due to form constraints.</exception>
        /// <returns>The modified form.</returns>
        public static FormObject AddRowObject(this FormObject formObject)
        {
            return formObject.AddRowObject(new RowObject
            {
                RowAction = RowObject.RowActions.Add
            });
        }

        /// <summary>
        /// Adds a new row to a <see cref="FormObject"/> with a specific row ID and parent row ID.
        /// </summary>
        /// <param name="formObject">The form to modify.</param>
        /// <param name="rowId">The row ID to assign.</param>
        /// <param name="parentRowId">The parent row ID to assign.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="formObject"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when constraints prevent adding the row, such as non-multiple-iteration forms with an existing current row or duplicate row IDs.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when another row cannot be added due to form constraints.</exception>
        /// <returns>The modified form.</returns>
        public static FormObject AddRowObject(this FormObject formObject, string rowId, string parentRowId)
        {
            return formObject.AddRowObject(rowId, parentRowId, RowObject.RowActions.Add);
        }

        /// <summary>
        /// Adds a new row to a <see cref="FormObject"/> with specific row and parent identifiers and row action.
        /// </summary>
        /// <param name="formObject">The form to modify.</param>
        /// <param name="rowId">The row ID to assign.</param>
        /// <param name="parentRowId">The parent row ID to assign.</param>
        /// <param name="rowAction">The row action to assign.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="formObject"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when constraints prevent adding the row, such as non-multiple-iteration forms with an existing current row or duplicate row IDs.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when another row cannot be added due to form constraints.</exception>
        /// <returns>The modified form.</returns>
        public static FormObject AddRowObject(this FormObject formObject, string rowId, string parentRowId, string rowAction)
        {
            return formObject.AddRowObject(new RowObject
            {
                RowId = rowId,
                ParentRowId = parentRowId,
                RowAction = rowAction
            });
        }

        /// <summary>
        /// Adds a new row to a <see cref="FormObject"/> with row action set to <see cref="RowObject.RowActions.Add"/> and the specified parent row ID.
        /// </summary>
        /// <param name="formObject">The form to modify.</param>
        /// <param name="parentRowId">The parent row ID to assign.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="formObject"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when constraints prevent adding the row, such as non-multiple-iteration forms with an existing current row or duplicate row IDs.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when another row cannot be added due to form constraints.</exception>
        /// <returns>The modified form.</returns>
        public static FormObject AddRowObjectWithParentRowId(this FormObject formObject, string parentRowId)
        {
            return formObject.AddRowObject(new RowObject
            {
                ParentRowId = parentRowId,
                RowAction = RowObject.RowActions.Add
            });
        }

        /// <summary>
        /// Marks a row for deletion in a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formObject">The form to modify.</param>
        /// <param name="rowObject">The row to mark for deletion.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="rowObject"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the row ID is missing or no matching row is found.</exception>
        /// <returns>The modified form.</returns>
        public static FormObject DeleteRowObject(this FormObject formObject, RowObject rowObject)
        {
            if (rowObject == null)
            {
                throw new ArgumentNullException(nameof(rowObject));
            }

            return formObject.DeleteRowObject(rowObject.RowId);
        }

        /// <summary>
        /// Marks a row for deletion in a <see cref="FormObject"/> by row ID.
        /// </summary>
        /// <param name="formObject">The form to modify.</param>
        /// <param name="rowId">The row ID to mark for deletion.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="formObject"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="rowId"/> is null/empty or no matching row is found.</exception>
        /// <returns>The modified form.</returns>
        public static FormObject DeleteRowObject(this FormObject formObject, string rowId)
        {
            if (formObject == null)
            {
                throw new ArgumentNullException(nameof(formObject));
            }

            if (string.IsNullOrEmpty(rowId))
            {
                throw new ArgumentException(StructuralMutationMessages.RowIdCannotBeNullOrEmpty, nameof(rowId));
            }

            if (formObject.CurrentRow?.RowId == rowId)
            {
                formObject.CurrentRow.RowAction = RowObject.RowActions.Delete;
                return formObject;
            }

            if (formObject.OtherRows != null)
            {
                var rowIndex = formObject.OtherRows.FindIndex(r => r != null && r.RowId == rowId);
                if (rowIndex >= 0)
                {
                    formObject.OtherRows[rowIndex].RowAction = RowObject.RowActions.Delete;
                    return formObject;
                }
            }

            throw new ArgumentException(StructuralMutationMessages.NoMatchingRowForRowId, nameof(rowId));
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
            if (formObject == null || string.IsNullOrEmpty(rowId))
                return false;

            if (formObject.CurrentRow?.RowId == rowId)
                return true;

            return formObject.OtherRows?.Any(r => r != null && r.RowId == rowId) ?? false;
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

        /// <summary>
        /// Disables a <see cref="FieldObject"/> in a <see cref="FormObject"/> by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumber">The field number to disable.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetDisabledField(this FormObject formObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasFieldInForm = formObject.CurrentRow.IsFieldPresent(fieldNumber)
                || (formObject.MultipleIteration && formObject.HasOtherRows() && formObject.OtherRows.Any(r => r.IsFieldPresent(fieldNumber)));

            if (!hasFieldInForm)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            if (formObject.CurrentRow.IsFieldPresent(fieldNumber))
            {
                formObject.CurrentRow.SetDisabledField(fieldNumber);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows.Where(r => r.IsFieldPresent(fieldNumber)))
                {
                    row.SetDisabledField(fieldNumber);
                }
            }

            return formObject;
        }

        /// <summary>
        /// Disables <see cref="FieldObject"/> instances in a <see cref="FormObject"/> by field numbers.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to disable.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetDisabledFields(this FormObject formObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasAnyField = fieldsToSet.Any(f => formObject.CurrentRow.IsFieldPresent(f))
                || (formObject.MultipleIteration && formObject.HasOtherRows() && fieldsToSet.Any(f => formObject.OtherRows.Any(r => r.IsFieldPresent(f))));

            if (!hasAnyField)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            var currentRowFieldNumbers = fieldsToSet.Where(formObject.CurrentRow.IsFieldPresent).ToList();
            if (currentRowFieldNumbers.Count > 0)
            {
                formObject.CurrentRow.SetDisabledFields(currentRowFieldNumbers);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows)
                {
                    var rowFieldNumbers = fieldsToSet.Where(row.IsFieldPresent).ToList();
                    if (rowFieldNumbers.Count > 0)
                    {
                        row.SetDisabledFields(rowFieldNumbers);
                    }
                }
            }

            return formObject;
        }

        /// <summary>
        /// Enables a <see cref="FieldObject"/> in a <see cref="FormObject"/> by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumber">The field number to enable.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetEnabledField(this FormObject formObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasFieldInForm = formObject.CurrentRow.IsFieldPresent(fieldNumber)
                || (formObject.MultipleIteration && formObject.HasOtherRows() && formObject.OtherRows.Any(r => r.IsFieldPresent(fieldNumber)));

            if (!hasFieldInForm)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            if (formObject.CurrentRow.IsFieldPresent(fieldNumber))
            {
                formObject.CurrentRow.SetEnabledField(fieldNumber);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows.Where(r => r.IsFieldPresent(fieldNumber)))
                {
                    row.SetEnabledField(fieldNumber);
                }
            }

            return formObject;
        }

        /// <summary>
        /// Enables <see cref="FieldObject"/> instances in a <see cref="FormObject"/> by field numbers.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to enable.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetEnabledFields(this FormObject formObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasAnyField = fieldsToSet.Any(f => formObject.CurrentRow.IsFieldPresent(f))
                || (formObject.MultipleIteration && formObject.HasOtherRows() && fieldsToSet.Any(f => formObject.OtherRows.Any(r => r.IsFieldPresent(f))));

            if (!hasAnyField)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            var currentRowFieldNumbers = fieldsToSet.Where(formObject.CurrentRow.IsFieldPresent).ToList();
            if (currentRowFieldNumbers.Count > 0)
            {
                formObject.CurrentRow.SetEnabledFields(currentRowFieldNumbers);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows)
                {
                    var rowFieldNumbers = fieldsToSet.Where(row.IsFieldPresent).ToList();
                    if (rowFieldNumbers.Count > 0)
                    {
                        row.SetEnabledFields(rowFieldNumbers);
                    }
                }
            }

            return formObject;
        }

        /// <summary>
        /// Locks a <see cref="FieldObject"/> in a <see cref="FormObject"/> by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumber">The field number to lock.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetLockedField(this FormObject formObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasFieldInForm = formObject.CurrentRow.IsFieldPresent(fieldNumber)
                || (formObject.MultipleIteration && formObject.HasOtherRows() && formObject.OtherRows.Any(r => r.IsFieldPresent(fieldNumber)));

            if (!hasFieldInForm)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            if (formObject.CurrentRow.IsFieldPresent(fieldNumber))
            {
                formObject.CurrentRow.SetLockedField(fieldNumber);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows.Where(r => r.IsFieldPresent(fieldNumber)))
                {
                    row.SetLockedField(fieldNumber);
                }
            }

            return formObject;
        }

        /// <summary>
        /// Locks <see cref="FieldObject"/> instances in a <see cref="FormObject"/> by field numbers.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to lock.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetLockedFields(this FormObject formObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasAnyField = fieldsToSet.Any(f => formObject.CurrentRow.IsFieldPresent(f))
                || (formObject.MultipleIteration && formObject.HasOtherRows() && fieldsToSet.Any(f => formObject.OtherRows.Any(r => r.IsFieldPresent(f))));

            if (!hasAnyField)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            var currentRowFieldNumbers = fieldsToSet.Where(formObject.CurrentRow.IsFieldPresent).ToList();
            if (currentRowFieldNumbers.Count > 0)
            {
                formObject.CurrentRow.SetLockedFields(currentRowFieldNumbers);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows)
                {
                    var rowFieldNumbers = fieldsToSet.Where(row.IsFieldPresent).ToList();
                    if (rowFieldNumbers.Count > 0)
                    {
                        row.SetLockedFields(rowFieldNumbers);
                    }
                }
            }

            return formObject;
        }

        /// <summary>
        /// Unlocks a <see cref="FieldObject"/> in a <see cref="FormObject"/> by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumber">The field number to unlock.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetUnlockedField(this FormObject formObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasFieldInForm = formObject.CurrentRow.IsFieldPresent(fieldNumber)
                || (formObject.MultipleIteration && formObject.HasOtherRows() && formObject.OtherRows.Any(r => r.IsFieldPresent(fieldNumber)));

            if (!hasFieldInForm)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            if (formObject.CurrentRow.IsFieldPresent(fieldNumber))
            {
                formObject.CurrentRow.SetUnlockedField(fieldNumber);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows.Where(r => r.IsFieldPresent(fieldNumber)))
                {
                    row.SetUnlockedField(fieldNumber);
                }
            }

            return formObject;
        }

        /// <summary>
        /// Unlocks <see cref="FieldObject"/> instances in a <see cref="FormObject"/> by field numbers.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to unlock.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetUnlockedFields(this FormObject formObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasAnyField = fieldsToSet.Any(f => formObject.CurrentRow.IsFieldPresent(f))
                || (formObject.MultipleIteration && formObject.HasOtherRows() && fieldsToSet.Any(f => formObject.OtherRows.Any(r => r.IsFieldPresent(f))));

            if (!hasAnyField)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            var currentRowFieldNumbers = fieldsToSet.Where(formObject.CurrentRow.IsFieldPresent).ToList();
            if (currentRowFieldNumbers.Count > 0)
            {
                formObject.CurrentRow.SetUnlockedFields(currentRowFieldNumbers);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows)
                {
                    var rowFieldNumbers = fieldsToSet.Where(row.IsFieldPresent).ToList();
                    if (rowFieldNumbers.Count > 0)
                    {
                        row.SetUnlockedFields(rowFieldNumbers);
                    }
                }
            }

            return formObject;
        }

        /// <summary>
        /// Marks a <see cref="FieldObject"/> in a <see cref="FormObject"/> as required by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumber">The field number to mark as required.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetRequiredField(this FormObject formObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasFieldInForm = formObject.CurrentRow.IsFieldPresent(fieldNumber)
                || (formObject.MultipleIteration && formObject.HasOtherRows() && formObject.OtherRows.Any(r => r.IsFieldPresent(fieldNumber)));

            if (!hasFieldInForm)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            if (formObject.CurrentRow.IsFieldPresent(fieldNumber))
            {
                formObject.CurrentRow.SetRequiredField(fieldNumber);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows.Where(r => r.IsFieldPresent(fieldNumber)))
                {
                    row.SetRequiredField(fieldNumber);
                }
            }

            return formObject;
        }

        /// <summary>
        /// Marks <see cref="FieldObject"/> instances in a <see cref="FormObject"/> as required by field numbers.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to mark as required.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetRequiredFields(this FormObject formObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasAnyField = fieldsToSet.Any(f => formObject.CurrentRow.IsFieldPresent(f))
                || (formObject.MultipleIteration && formObject.HasOtherRows() && fieldsToSet.Any(f => formObject.OtherRows.Any(r => r.IsFieldPresent(f))));

            if (!hasAnyField)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            var currentRowFieldNumbers = fieldsToSet.Where(formObject.CurrentRow.IsFieldPresent).ToList();
            if (currentRowFieldNumbers.Count > 0)
            {
                formObject.CurrentRow.SetRequiredFields(currentRowFieldNumbers);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows)
                {
                    var rowFieldNumbers = fieldsToSet.Where(row.IsFieldPresent).ToList();
                    if (rowFieldNumbers.Count > 0)
                    {
                        row.SetRequiredFields(rowFieldNumbers);
                    }
                }
            }

            return formObject;
        }

        /// <summary>
        /// Marks a <see cref="FieldObject"/> in a <see cref="FormObject"/> as optional by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumber">The field number to mark as optional.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumber"/> is empty or when no matching field exists.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetOptionalField(this FormObject formObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasFieldInForm = formObject.CurrentRow.IsFieldPresent(fieldNumber)
                || (formObject.MultipleIteration && formObject.HasOtherRows() && formObject.OtherRows.Any(r => r.IsFieldPresent(fieldNumber)));

            if (!hasFieldInForm)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            if (formObject.CurrentRow.IsFieldPresent(fieldNumber))
            {
                formObject.CurrentRow.SetOptionalField(fieldNumber);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows.Where(r => r.IsFieldPresent(fieldNumber)))
                {
                    row.SetOptionalField(fieldNumber);
                }
            }

            return formObject;
        }

        /// <summary>
        /// Marks <see cref="FieldObject"/> instances in a <see cref="FormObject"/> as optional by field numbers.
        /// </summary>
        /// <param name="formObject">The FormObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to mark as optional.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fieldNumbers"/> is empty, contains invalid values, or no matching fields exist.</exception>
        /// <returns>The modified FormObject.</returns>
        public static FormObject? SetOptionalFields(this FormObject formObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (formObject == null || formObject.CurrentRow == null)
                return formObject;

            var hasAnyField = fieldsToSet.Any(f => formObject.CurrentRow.IsFieldPresent(f))
                || (formObject.MultipleIteration && formObject.HasOtherRows() && fieldsToSet.Any(f => formObject.OtherRows.Any(r => r.IsFieldPresent(f))));

            if (!hasAnyField)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            var currentRowFieldNumbers = fieldsToSet.Where(formObject.CurrentRow.IsFieldPresent).ToList();
            if (currentRowFieldNumbers.Count > 0)
            {
                formObject.CurrentRow.SetOptionalFields(currentRowFieldNumbers);
            }

            if (formObject.MultipleIteration && formObject.HasOtherRows())
            {
                foreach (var row in formObject.OtherRows)
                {
                    var rowFieldNumbers = fieldsToSet.Where(row.IsFieldPresent).ToList();
                    if (rowFieldNumbers.Count > 0)
                    {
                        row.SetOptionalFields(rowFieldNumbers);
                    }
                }
            }

            return formObject;
        }
    }
}
