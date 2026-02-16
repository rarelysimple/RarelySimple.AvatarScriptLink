using System;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Manipulators
{
    /// <summary>
    /// Provides extension methods for manipulating <see cref="FieldObject"/> instances.
    /// </summary>
    public static class FieldObjectManipulators
    {
        /// <summary>
        /// Enables a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to manipulate.</param>
        /// <returns>The FieldObject for method chaining, or null if input is null.</returns>
        public static FieldObject? Enable(this FieldObject? fieldObject)
        {
            if (fieldObject != null)
            {
                fieldObject.SetEnabled(true);
            }
            return fieldObject;
        }

        /// <summary>
        /// Disables a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to manipulate.</param>
        /// <returns>The FieldObject for method chaining, or null if input is null.</returns>
        public static FieldObject? Disable(this FieldObject? fieldObject)
        {
            if (fieldObject != null)
            {
                fieldObject.SetEnabled(false);
            }
            return fieldObject;
        }

        /// <summary>
        /// Locks a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to manipulate.</param>
        /// <returns>The FieldObject for method chaining, or null if input is null.</returns>
        public static FieldObject? Lock(this FieldObject? fieldObject)
        {
            if (fieldObject != null)
            {
                fieldObject.SetLocked(true);
            }
            return fieldObject;
        }

        /// <summary>
        /// Unlocks a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to manipulate.</param>
        /// <returns>The FieldObject for method chaining, or null if input is null.</returns>
        public static FieldObject? Unlock(this FieldObject? fieldObject)
        {
            if (fieldObject != null)
            {
                fieldObject.SetLocked(false);
            }
            return fieldObject;
        }

        /// <summary>
        /// Marks a <see cref="FieldObject"/> as required.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to manipulate.</param>
        /// <returns>The FieldObject for method chaining, or null if input is null.</returns>
        public static FieldObject? MarkRequired(this FieldObject? fieldObject)
        {
            if (fieldObject != null)
            {
                fieldObject.SetRequired(true);
            }
            return fieldObject;
        }

        /// <summary>
        /// Marks a <see cref="FieldObject"/> as optional.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to manipulate.</param>
        /// <returns>The FieldObject for method chaining, or null if input is null.</returns>
        public static FieldObject? MarkOptional(this FieldObject? fieldObject)
        {
            if (fieldObject != null)
            {
                fieldObject.SetRequired(false);
            }
            return fieldObject;
        }
    }
}
