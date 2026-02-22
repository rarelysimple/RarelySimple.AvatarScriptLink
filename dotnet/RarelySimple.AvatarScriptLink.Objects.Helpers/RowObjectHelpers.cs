using System.Collections.Generic;
using System.Linq;
using RarelySimple.AvatarScriptLink.Objects.Helpers.Manipulators;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers
{
    /// <summary>
    /// Provides extension methods for querying and manipulating <see cref="RowObject"/> instances.
    /// </summary>
    public static class RowObjectHelpers
    {
        /// <summary>
        /// Gets the row ID of a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to query.</param>
        /// <returns>The row ID, or null if not set.</returns>
        public static string? GetRowId(this RowObject rowObject)
        {
            return rowObject?.RowId;
        }

        /// <summary>
        /// Gets the parent row ID of a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to query.</param>
        /// <returns>The parent row ID, or null if not set.</returns>
        public static string? GetParentRowId(this RowObject rowObject)
        {
            return rowObject?.ParentRowId;
        }

        /// <summary>
        /// Gets the row action of a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to query.</param>
        /// <returns>The row action, or null if not set.</returns>
        public static string? GetRowAction(this RowObject rowObject)
        {
            return rowObject?.RowAction;
        }

        /// <summary>
        /// Determines if a <see cref="RowObject"/> is marked for deletion.
        /// </summary>
        /// <param name="rowObject">The RowObject to query.</param>
        /// <returns>True if the row is marked for deletion, false otherwise.</returns>
        public static bool IsMarkedForDeletion(this RowObject rowObject)
        {
            return rowObject?.RowAction == "DELETE";
        }

        /// <summary>
        /// Gets the number of fields in a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to query.</param>
        /// <returns>The number of fields.</returns>
        public static int GetFieldCount(this RowObject rowObject)
        {
            return rowObject?.Fields?.Count ?? 0;
        }

        /// <summary>
        /// Gets the field value of a <see cref="FieldObject"/> in a <see cref="RowObject"/> by field number.
        /// </summary>
        /// <param name="rowObject">The RowObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>The field value, or null if not found.</returns>
        public static string? GetFieldValue(this RowObject rowObject, string fieldNumber)
        {
            if (rowObject == null || rowObject.Fields == null || string.IsNullOrEmpty(fieldNumber))
                return null;

            return rowObject.Fields
                .FirstOrDefault(f => f.FieldNumber == fieldNumber)?
                .FieldValue;
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> is present in a <see cref="RowObject"/> by field number.
        /// </summary>
        /// <param name="rowObject">The RowObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is present, false otherwise.</returns>
        public static bool IsFieldPresent(this RowObject rowObject, string fieldNumber)
        {
            if (rowObject == null || rowObject.Fields == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return rowObject.Fields.Any(f => f.FieldNumber == fieldNumber);
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> in a <see cref="RowObject"/> is enabled by field number.
        /// </summary>
        /// <param name="rowObject">The RowObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is enabled, false if disabled or not found.</returns>
        public static bool IsFieldEnabled(this RowObject rowObject, string fieldNumber)
        {
            if (rowObject == null || rowObject.Fields == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return rowObject.Fields
                .Where(f => f.FieldNumber == fieldNumber)
                .Select(f => f.IsEnabled())
                .FirstOrDefault();
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> in a <see cref="RowObject"/> is locked by field number.
        /// </summary>
        /// <param name="rowObject">The RowObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is locked, false if not locked or not found.</returns>
        public static bool IsFieldLocked(this RowObject rowObject, string fieldNumber)
        {
            if (rowObject == null || rowObject.Fields == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return rowObject.Fields
                .Where(f => f.FieldNumber == fieldNumber)
                .Select(f => f.IsLocked())
                .FirstOrDefault();
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> in a <see cref="RowObject"/> is required by field number.
        /// </summary>
        /// <param name="rowObject">The RowObject to query.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the field is required, false if not required or not found.</returns>
        public static bool IsFieldRequired(this RowObject rowObject, string fieldNumber)
        {
            if (rowObject == null || rowObject.Fields == null || string.IsNullOrEmpty(fieldNumber))
                return false;

            return rowObject.Fields
                .Where(f => f.FieldNumber == fieldNumber)
                .Select(f => f.IsRequired())
                .FirstOrDefault();
        }

        /// <summary>
        /// Sets the field value of a <see cref="FieldObject"/> in a <see cref="RowObject"/> by field number.
        /// If the field is not present, this method does nothing.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <param name="fieldValue">The new field value.</param>
        /// <returns>The modified RowObject, or the original if the field is not found.</returns>
        public static RowObject? SetFieldValue(this RowObject rowObject, string fieldNumber, string fieldValue)
        {
            if (rowObject == null || rowObject.Fields == null || string.IsNullOrEmpty(fieldNumber))
                return rowObject;

            var field = rowObject.Fields.FirstOrDefault(f => f.FieldNumber == fieldNumber);
            if (field != null)
            {
                field.SetValue(fieldValue);
                if (rowObject.RowAction == "")
                    rowObject.RowAction = "EDIT";
            }
            return rowObject;
        }

        /// <summary>
        /// Disables all <see cref="FieldObject"/> instances in a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? DisableAllFieldObjects(this RowObject rowObject)
        {
            return DisableAllFieldObjects(rowObject, null);
        }

        /// <summary>
        /// Disables a <see cref="FieldObject"/> in a <see cref="RowObject"/> by field number.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <param name="fieldNumber">The field number to disable.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? SetDisabledField(this RowObject rowObject, string fieldNumber)
        {
            if (rowObject == null || rowObject.Fields == null || string.IsNullOrEmpty(fieldNumber))
                return rowObject;

            var field = rowObject.Fields.FirstOrDefault(f => f.FieldNumber == fieldNumber);
            if (field == null)
                return rowObject;

            field.Disable();

            if (rowObject.RowAction == "")
                rowObject.RowAction = "EDIT";

            return rowObject;
        }

        /// <summary>
        /// Disables <see cref="FieldObject"/> instances in a <see cref="RowObject"/> by field numbers.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to disable.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? SetDisabledFields(this RowObject rowObject, List<string>? fieldNumbers)
        {
            if (rowObject == null || rowObject.Fields == null || fieldNumbers == null || fieldNumbers.Count == 0)
                return rowObject;

            var changed = false;
            foreach (var field in rowObject.Fields.Where(f => fieldNumbers.Contains(f.FieldNumber)))
            {
                field.Disable();
                changed = true;
            }

            if (changed && rowObject.RowAction == "")
                rowObject.RowAction = "EDIT";

            return rowObject;
        }

        /// <summary>
        /// Enables a <see cref="FieldObject"/> in a <see cref="RowObject"/> by field number.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <param name="fieldNumber">The field number to enable.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? SetEnabledField(this RowObject rowObject, string fieldNumber)
        {
            if (rowObject == null || rowObject.Fields == null || string.IsNullOrEmpty(fieldNumber))
                return rowObject;

            var field = rowObject.Fields.FirstOrDefault(f => f.FieldNumber == fieldNumber);
            if (field == null)
                return rowObject;

            field.Enable();

            if (rowObject.RowAction == "")
                rowObject.RowAction = "EDIT";

            return rowObject;
        }

        /// <summary>
        /// Enables <see cref="FieldObject"/> instances in a <see cref="RowObject"/> by field numbers.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <param name="fieldNumbers">The field numbers to enable.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? SetEnabledFields(this RowObject rowObject, List<string>? fieldNumbers)
        {
            if (rowObject == null || rowObject.Fields == null || fieldNumbers == null || fieldNumbers.Count == 0)
                return rowObject;

            var changed = false;
            foreach (var field in rowObject.Fields.Where(f => fieldNumbers.Contains(f.FieldNumber)))
            {
                field.Enable();
                changed = true;
            }

            if (changed && rowObject.RowAction == "")
                rowObject.RowAction = "EDIT";

            return rowObject;
        }

        /// <summary>
        /// Disables all <see cref="FieldObject"/> instances in a <see cref="RowObject"/>, except for the field numbers specified in the exclusion list.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <param name="excludedFieldNumbers">The field numbers to exclude from disabling.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? DisableAllFieldObjects(this RowObject rowObject, List<string>? excludedFieldNumbers)
        {
            if (rowObject == null || rowObject.Fields == null)
                return rowObject;

            var excluded = excludedFieldNumbers ?? new List<string>();
            foreach (var field in rowObject.Fields.Where(f => !excluded.Contains(f.FieldNumber)))
            {
                field.Disable();
            }

            if (rowObject.RowAction == "")
                rowObject.RowAction = "EDIT";

            return rowObject;
        }

        /// <summary>
        /// Enables all <see cref="FieldObject"/> instances in a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? EnableAllFieldObjects(this RowObject rowObject)
        {
            return EnableAllFieldObjects(rowObject, null);
        }

        /// <summary>
        /// Enables all <see cref="FieldObject"/> instances in a <see cref="RowObject"/>, except for the field numbers specified in the exclusion list.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <param name="excludedFieldNumbers">The field numbers to exclude from enabling.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? EnableAllFieldObjects(this RowObject rowObject, List<string>? excludedFieldNumbers)
        {
            if (rowObject == null || rowObject.Fields == null)
                return rowObject;

            var excluded = excludedFieldNumbers ?? new List<string>();
            foreach (var field in rowObject.Fields.Where(f => !excluded.Contains(f.FieldNumber)))
            {
                field.Enable();
            }

            if (rowObject.RowAction == "")
                rowObject.RowAction = "EDIT";

            return rowObject;
        }

        /// <summary>
        /// Locks all <see cref="FieldObject"/> instances in a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? LockAllFieldObjects(this RowObject rowObject)
        {
            return LockAllFieldObjects(rowObject, null);
        }

        /// <summary>
        /// Locks all <see cref="FieldObject"/> instances in a <see cref="RowObject"/>, except for the field numbers specified in the exclusion list.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <param name="excludedFieldNumbers">The field numbers to exclude from locking.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? LockAllFieldObjects(this RowObject rowObject, List<string>? excludedFieldNumbers)
        {
            if (rowObject == null || rowObject.Fields == null)
                return rowObject;

            var excluded = excludedFieldNumbers ?? new List<string>();
            foreach (var field in rowObject.Fields.Where(f => !excluded.Contains(f.FieldNumber)))
            {
                field.Lock();
            }

            if (rowObject.RowAction == "")
                rowObject.RowAction = "EDIT";

            return rowObject;
        }

        /// <summary>
        /// Unlocks all <see cref="FieldObject"/> instances in a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? UnlockAllFieldObjects(this RowObject rowObject)
        {
            return UnlockAllFieldObjects(rowObject, null);
        }

        /// <summary>
        /// Unlocks all <see cref="FieldObject"/> instances in a <see cref="RowObject"/>, except for the field numbers specified in the exclusion list.
        /// </summary>
        /// <param name="rowObject">The RowObject to modify.</param>
        /// <param name="excludedFieldNumbers">The field numbers to exclude from unlocking.</param>
        /// <returns>The modified RowObject.</returns>
        public static RowObject? UnlockAllFieldObjects(this RowObject rowObject, List<string>? excludedFieldNumbers)
        {
            if (rowObject == null || rowObject.Fields == null)
                return rowObject;

            var excluded = excludedFieldNumbers ?? new List<string>();
            foreach (var field in rowObject.Fields.Where(f => !excluded.Contains(f.FieldNumber)))
            {
                field.Unlock();
            }

            if (rowObject.RowAction == "")
                rowObject.RowAction = "EDIT";

            return rowObject;
        }
    }
}
