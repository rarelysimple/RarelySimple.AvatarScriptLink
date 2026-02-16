namespace RarelySimple.AvatarScriptLink.Objects.Converters
{
    /// <summary>
    /// Provides conversion extensions for <see cref="FieldObject"/> instances.
    /// </summary>
    public static class FieldObjectConverters
    {
        /// <summary>
        /// Creates a copy of a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="source">The FieldObject to convert.</param>
        /// <returns>A new FieldObject with copied values, or null if the source is null.</returns>
        public static FieldObject? ToFieldObject(this FieldObject? source)
        {
            if (source == null)
            {
                return null;
            }

            return new FieldObject
            {
                FieldNumber = source.FieldNumber,
                FieldValue = source.FieldValue,
                Enabled = source.Enabled,
                Lock = source.Lock,
                Required = source.Required
            };
        }
    }
}
