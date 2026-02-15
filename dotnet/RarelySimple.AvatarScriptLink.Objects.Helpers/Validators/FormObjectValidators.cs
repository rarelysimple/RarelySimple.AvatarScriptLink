using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Validators
{
    /// <summary>
    /// Provides extension methods for validating <see cref="FormObject"/> instances.
    /// </summary>
    public static class FormObjectValidators
    {
        /// <summary>
        /// Determines if a <see cref="FormObject"/> has a specific field by field number.
        /// </summary>
        /// <param name="formObject">The FormObject to validate.</param>
        /// <param name="fieldNumber">The field number to search for.</param>
        /// <returns>True if the form contains a field with the specified field number, false otherwise.</returns>
        public static bool HasField(this FormObject formObject, string fieldNumber)
        {
            if (formObject?.HasCurrentRow() == true)
            {
                return formObject.CurrentRow.Fields.Any(f => f.FieldNumber == fieldNumber);
            }
            return false;
        }

        /// <summary>
        /// Determines if a <see cref="FormObject"/> has any rows.
        /// </summary>
        /// <param name="formObject">The FormObject to validate.</param>
        /// <returns>True if the form has at least one row (current or other), false otherwise.</returns>
        public static bool HasAnyRows(this FormObject formObject)
        {
            return formObject?.HasCurrentRow() == true || formObject?.HasOtherRows() == true;
        }

        /// <summary>
        /// Determines if a <see cref="FormObject"/> is empty (no rows or fields).
        /// </summary>
        /// <param name="formObject">The FormObject to validate.</param>
        /// <returns>True if the form has no rows, false otherwise.</returns>
        public static bool IsEmpty(this FormObject formObject)
        {
            return !formObject?.HasAnyRows() == true;
        }

        /// <summary>
        /// Gets the count of total fields across all rows in a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formObject">The FormObject to query.</param>
        /// <returns>The total number of fields across all rows.</returns>
        public static int GetTotalFieldCount(this FormObject formObject)
        {
            int count = 0;

            if (formObject?.HasCurrentRow() == true)
            {
                count += formObject.CurrentRow.GetFieldCount();
            }

            if (formObject?.HasOtherRows() == true)
            {
                count += formObject.OtherRows.Sum(row => row?.GetFieldCount() ?? 0);
            }

            return count;
        }
    }
}
