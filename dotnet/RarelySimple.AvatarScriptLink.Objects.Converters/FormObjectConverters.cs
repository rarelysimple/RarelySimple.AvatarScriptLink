namespace RarelySimple.AvatarScriptLink.Objects.Converters
{
    /// <summary>
    /// Provides conversion extensions for <see cref="FormObject"/> instances.
    /// </summary>
    public static class FormObjectConverters
    {
        /// <summary>
        /// Creates a copy of a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="source">The FormObject to convert.</param>
        /// <param name="includeRows">True to copy rows, false to ignore them.</param>
        /// <returns>A new FormObject with copied values, or null if the source is null.</returns>
        public static FormObject? ToFormObject(this FormObject? source, bool includeRows = true)
        {
            if (source == null)
            {
                return null;
            }

            var formObject = new FormObject
            {
                FormId = source.FormId,
                MultipleIteration = source.MultipleIteration
            };

            if (!includeRows)
            {
                return formObject;
            }

            formObject.CurrentRow = source.CurrentRow.ToRowObject();
            if (source.OtherRows != null)
            {
                foreach (var row in source.OtherRows)
                {
                    var convertedRow = row.ToRowObject();
                    if (convertedRow != null)
                    {
                        formObject.OtherRows.Add(convertedRow);
                    }
                }
            }

            return formObject;
        }
    }
}
