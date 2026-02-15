namespace RarelySimple.AvatarScriptLink.Objects.Builders.ResponseBuilders
{
    /// <summary>
    /// Provides response builder extensions for <see cref="FormObject"/> instances.
    /// </summary>
    public static class FormObjectResponseBuilders
    {
        /// <summary>
        /// Sets the current row and ensures it will be included in a response payload.
        /// </summary>
        /// <param name="formObject">The FormObject to configure.</param>
        /// <param name="rowObject">The row to set as current.</param>
        /// <returns>The FormObject for method chaining.</returns>
        public static FormObject SetResponseCurrentRow(this FormObject formObject, RowObject rowObject)
        {
            EnsureRowActionSet(rowObject);
            formObject.CurrentRow = rowObject;
            return formObject;
        }

        /// <summary>
        /// Creates a current row and ensures it will be included in a response payload.
        /// </summary>
        /// <param name="formObject">The FormObject to configure.</param>
        /// <param name="rowId">The row ID to assign.</param>
        /// <returns>The created RowObject.</returns>
        public static RowObject CreateResponseCurrentRow(this FormObject formObject, string rowId)
        {
            var rowObject = RowObjectBuilders.CreateRowObject(rowId);
            EnsureRowActionSet(rowObject);
            formObject.CurrentRow = rowObject;
            return rowObject;
        }

        /// <summary>
        /// Adds a response row to the OtherRows collection.
        /// </summary>
        /// <param name="formObject">The FormObject to add to.</param>
        /// <param name="rowObject">The row to add.</param>
        /// <returns>The FormObject for method chaining.</returns>
        public static FormObject AddResponseRow(this FormObject formObject, RowObject rowObject)
        {
            EnsureRowActionSet(rowObject);
            formObject.AddRow(rowObject);
            return formObject;
        }

        /// <summary>
        /// Creates and adds a response row to the OtherRows collection.
        /// </summary>
        /// <param name="formObject">The FormObject to add to.</param>
        /// <param name="rowId">The row ID to assign.</param>
        /// <param name="rowAction">The row action to apply (e.g., ADD, EDIT, DELETE).</param>
        /// <returns>The created RowObject.</returns>
        public static RowObject AddResponseRow(this FormObject formObject, string rowId, string rowAction = null)
        {
            var rowObject = RowObjectBuilders.CreateRowObject(rowId);
            if (!string.IsNullOrEmpty(rowAction))
            {
                rowObject.RowAction = rowAction;
            }
            EnsureRowActionSet(rowObject);
            formObject.AddRow(rowObject);
            return rowObject;
        }

        private static void EnsureRowActionSet(RowObject rowObject)
        {
            if (rowObject != null && string.IsNullOrEmpty(rowObject.RowAction))
            {
                rowObject.RowAction = RowObject.RowActions.Edit;
            }
        }
    }
}
