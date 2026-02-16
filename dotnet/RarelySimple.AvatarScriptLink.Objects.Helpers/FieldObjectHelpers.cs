namespace RarelySimple.AvatarScriptLink.Objects.Helpers
{
    /// <summary>
    /// Provides extension methods for querying and manipulating <see cref="FieldObject"/> instances.
    /// </summary>
    public static class FieldObjectHelpers
    {
        /// <summary>
        /// Gets the field value of a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to query.</param>
        /// <returns>The field value, or null if not set.</returns>
        public static string? GetValue(this FieldObject fieldObject)
        {
            return fieldObject?.FieldValue;
        }

        /// <summary>
        /// Sets the field value of a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to modify.</param>
        /// <param name="value">The value to set.</param>
        public static void SetValue(this FieldObject fieldObject, string value)
        {
            if (fieldObject != null)
            {
                fieldObject.FieldValue = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Clears the field value of a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to modify.</param>
        public static void ClearValue(this FieldObject fieldObject)
        {
            if (fieldObject != null)
            {
                fieldObject.FieldValue = string.Empty;
            }
        }
    }
}
