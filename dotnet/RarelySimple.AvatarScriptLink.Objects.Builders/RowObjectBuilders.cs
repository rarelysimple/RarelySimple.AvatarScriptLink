namespace RarelySimple.AvatarScriptLink.Objects.Builders
{
    /// <summary>
    /// Provides extension methods for building and creating <see cref="RowObject"/> instances.
    /// </summary>
    public static class RowObjectBuilders
    {
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with the specified row ID.
        /// </summary>
        /// <param name="rowId">The row ID for the new RowObject.</param>
        /// <returns>A new RowObject with the specified row ID.</returns>
        public static RowObject CreateRowObject(string rowId)
        {
            return RowObject.Initialize()
                .WithRowId(rowId);
        }

        /// <summary>
        /// Sets the RowId on a <see cref="RowObject"/> using a fluent interface.
        /// </summary>
        /// <param name="rowObject">The RowObject to configure.</param>
        /// <param name="rowId">The row ID to set.</param>
        /// <returns>The RowObject for method chaining.</returns>
        public static RowObject WithRowId(this RowObject rowObject, string rowId)
        {
            rowObject.RowId = rowId;
            return rowObject;
        }

        /// <summary>
        /// Sets the ParentRowId on a <see cref="RowObject"/> using a fluent interface.
        /// </summary>
        /// <param name="rowObject">The RowObject to configure.</param>
        /// <param name="parentRowId">The parent row ID to set.</param>
        /// <returns>The RowObject for method chaining.</returns>
        public static RowObject WithParentRowId(this RowObject rowObject, string parentRowId)
        {
            rowObject.ParentRowId = parentRowId;
            return rowObject;
        }

        /// <summary>
        /// Sets the RowAction on a <see cref="RowObject"/> using a fluent interface.
        /// </summary>
        /// <param name="rowObject">The RowObject to configure.</param>
        /// <param name="rowAction">The row action to set (e.g., "ADD", "EDIT", "DELETE").</param>
        /// <returns>The RowObject for method chaining.</returns>
        public static RowObject WithRowAction(this RowObject rowObject, string rowAction)
        {
            rowObject.RowAction = rowAction;
            return rowObject;
        }

        /// <summary>
        /// Adds a field to the Fields collection on a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="rowObject">The RowObject to add to.</param>
        /// <param name="fieldObject">The field to add.</param>
        /// <returns>The RowObject for method chaining.</returns>
        public static RowObject AddField(this RowObject rowObject, FieldObject fieldObject)
        {
            if (fieldObject != null)
            {
                rowObject.Fields.Add(fieldObject);
            }
            return rowObject;
        }
    }
}
