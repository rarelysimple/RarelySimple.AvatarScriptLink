using System;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Manipulators
{
    /// <summary>
    /// Provides extension methods for manipulating <see cref="RowObject"/> instances.
    /// </summary>
    public static class RowObjectManipulators
    {
        /// <summary>
        /// Marks a <see cref="RowObject"/> for addition.
        /// </summary>
        /// <param name="rowObject">The RowObject to manipulate.</param>
        /// <returns>The RowObject for method chaining, or null if input is null.</returns>
        public static RowObject? MarkForAddition(this RowObject? rowObject)
        {
            if (rowObject != null)
            {
                rowObject.RowAction = RowObject.RowActions.Add;
            }
            return rowObject;
        }

        /// <summary>
        /// Marks a <see cref="RowObject"/> for editing.
        /// </summary>
        /// <param name="rowObject">The RowObject to manipulate.</param>
        /// <returns>The RowObject for method chaining, or null if input is null.</returns>
        public static RowObject? MarkForEdit(this RowObject? rowObject)
        {
            if (rowObject != null)
            {
                rowObject.RowAction = RowObject.RowActions.Edit;
            }
            return rowObject;
        }

        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowObject">The RowObject to manipulate.</param>
        /// <returns>The RowObject for method chaining, or null if input is null.</returns>
        public static RowObject? MarkForDeletion(this RowObject? rowObject)
        {
            if (rowObject != null)
            {
                rowObject.RowAction = RowObject.RowActions.Delete;
            }
            return rowObject;
        }

        /// <summary>
        /// Clears the RowAction of a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to manipulate.</param>
        /// <returns>The RowObject for method chaining, or null if input is null.</returns>
        public static RowObject? ClearRowAction(this RowObject? rowObject)
        {
            if (rowObject != null)
            {
                rowObject.RowAction = string.Empty;
            }
            return rowObject;
        }

        /// <summary>
        /// Disables all fields in a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to manipulate.</param>
        /// <returns>The RowObject for method chaining, or null if input is null.</returns>
        public static RowObject? DisableAllFields(this RowObject? rowObject)
        {
            if (rowObject?.HasFields() == true)
            {
                foreach (var field in rowObject.Fields)
                {
                    field?.SetEnabled(false);
                }
            }
            return rowObject;
        }

        /// <summary>
        /// Enables all fields in a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to manipulate.</param>
        /// <returns>The RowObject for method chaining, or null if input is null.</returns>
        public static RowObject? EnableAllFields(this RowObject? rowObject)
        {
            if (rowObject?.HasFields() == true)
            {
                foreach (var field in rowObject.Fields)
                {
                    field?.SetEnabled(true);
                }
            }
            return rowObject;
        }

        /// <summary>
        /// Locks all fields in a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to manipulate.</param>
        /// <returns>The RowObject for method chaining, or null if input is null.</returns>
        public static RowObject? LockAllFields(this RowObject? rowObject)
        {
            if (rowObject?.HasFields() == true)
            {
                foreach (var field in rowObject.Fields)
                {
                    field?.SetLocked(true);
                }
            }
            return rowObject;
        }

        /// <summary>
        /// Unlocks all fields in a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to manipulate.</param>
        /// <returns>The RowObject for method chaining, or null if input is null.</returns>
        public static RowObject? UnlockAllFields(this RowObject? rowObject)
        {
            if (rowObject?.HasFields() == true)
            {
                foreach (var field in rowObject.Fields)
                {
                    field?.SetLocked(false);
                }
            }
            return rowObject;
        }
    }
}
