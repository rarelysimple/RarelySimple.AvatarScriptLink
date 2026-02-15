namespace RarelySimple.AvatarScriptLink.Objects.Converters
{
    /// <summary>
    /// Provides conversion extensions for <see cref="RowObject"/> instances.
    /// </summary>
    public static class RowObjectConverters
    {
        /// <summary>
        /// Creates a copy of a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="source">The RowObject to convert.</param>
        /// <param name="includeFields">True to copy fields, false to ignore them.</param>
        /// <returns>A new RowObject with copied values, or null if the source is null.</returns>
        public static RowObject? ToRowObject(this RowObject? source, bool includeFields = true)
        {
            if (source == null)
            {
                return null;
            }

            var rowObject = new RowObject
            {
                RowId = source.RowId,
                ParentRowId = source.ParentRowId,
                RowAction = source.RowAction
            };

            if (includeFields && source.Fields != null)
            {
                foreach (var field in source.Fields)
                {
                    var convertedField = field.ToFieldObject();
                    if (convertedField != null)
                    {
                        rowObject.Fields.Add(convertedField);
                    }
                }
            }

            return rowObject;
        }
    }
}
