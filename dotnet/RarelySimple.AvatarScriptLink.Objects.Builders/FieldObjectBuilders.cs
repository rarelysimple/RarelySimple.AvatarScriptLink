namespace RarelySimple.AvatarScriptLink.Objects.Builders
{
    /// <summary>
    /// Provides extension methods for building and creating <see cref="FieldObject"/> instances.
    /// </summary>
    public static class FieldObjectBuilders
    {
        /// <summary>
        /// Creates a new <see cref="FieldObject"/> with the specified field number.
        /// </summary>
        /// <param name="fieldNumber">The field number for the new FieldObject.</param>
        /// <returns>A new FieldObject with the specified field number.</returns>
        public static FieldObject CreateFieldObject(string fieldNumber)
        {
            return FieldObject.Initialize()
                .WithFieldNumber(fieldNumber);
        }

        /// <summary>
        /// Sets the FieldNumber on a <see cref="FieldObject"/> using a fluent interface.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to configure.</param>
        /// <param name="fieldNumber">The field number to set.</param>
        /// <returns>The FieldObject for method chaining.</returns>
        public static FieldObject WithFieldNumber(this FieldObject fieldObject, string fieldNumber)
        {
            fieldObject.FieldNumber = fieldNumber;
            return fieldObject;
        }

        /// <summary>
        /// Sets the FieldValue on a <see cref="FieldObject"/> using a fluent interface.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to configure.</param>
        /// <param name="fieldValue">The field value to set.</param>
        /// <returns>The FieldObject for method chaining.</returns>
        public static FieldObject WithFieldValue(this FieldObject fieldObject, string fieldValue)
        {
            fieldObject.FieldValue = fieldValue;
            return fieldObject;
        }

        /// <summary>
        /// Sets the Enabled status on a <see cref="FieldObject"/> using a fluent interface.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to configure.</param>
        /// <param name="enabled">True to enable the field, false to disable it.</param>
        /// <returns>The FieldObject for method chaining.</returns>
        public static FieldObject AsEnabled(this FieldObject fieldObject, bool enabled)
        {
            fieldObject.SetEnabled(enabled);
            return fieldObject;
        }

        /// <summary>
        /// Sets the Locked status on a <see cref="FieldObject"/> using a fluent interface.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to configure.</param>
        /// <param name="locked">True to lock the field, false to unlock it.</param>
        /// <returns>The FieldObject for method chaining.</returns>
        public static FieldObject AsLocked(this FieldObject fieldObject, bool locked)
        {
            fieldObject.SetLocked(locked);
            return fieldObject;
        }

        /// <summary>
        /// Sets the Required status on a <see cref="FieldObject"/> using a fluent interface.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to configure.</param>
        /// <param name="required">True to mark the field as required, false to mark as optional.</param>
        /// <returns>The FieldObject for method chaining.</returns>
        public static FieldObject AsRequired(this FieldObject fieldObject, bool required)
        {
            fieldObject.SetRequired(required);
            return fieldObject;
        }
    }
}
