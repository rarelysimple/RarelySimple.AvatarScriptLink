namespace RarelySimple.AvatarScriptLink.Objects.Builders.ResponseBuilders
{
    /// <summary>
    /// Provides response builder extensions for <see cref="RowObject"/> instances.
    /// </summary>
    public static class RowObjectResponseBuilders
    {
        /// <summary>
        /// Adds a field to a response row and ensures the row will be included in the payload.
        /// </summary>
        /// <param name="rowObject">The row to add to.</param>
        /// <param name="fieldObject">The field to add.</param>
        /// <returns>The added FieldObject.</returns>
        public static FieldObject AddResponseField(this RowObject rowObject, FieldObject fieldObject)
        {
            EnsureRowActionSet(rowObject);
            if (fieldObject != null)
            {
                rowObject.AddField(fieldObject);
            }
            return fieldObject;
        }

        /// <summary>
        /// Creates and adds a field to a response row and ensures the row will be included in the payload.
        /// </summary>
        /// <param name="rowObject">The row to add to.</param>
        /// <param name="fieldNumber">The field number to assign.</param>
        /// <param name="fieldValue">The field value to assign.</param>
        /// <returns>The created FieldObject.</returns>
        public static FieldObject AddResponseField(this RowObject rowObject, string fieldNumber, string fieldValue)
        {
            var fieldObject = FieldObjectBuilders.CreateFieldObject(fieldNumber)
                .WithFieldValue(fieldValue);

            return rowObject.AddResponseField(fieldObject);
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
