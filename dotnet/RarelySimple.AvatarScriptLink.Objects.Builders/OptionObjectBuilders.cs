namespace RarelySimple.AvatarScriptLink.Objects.Builders
{
    /// <summary>
    /// Provides extension methods for building and creating <see cref="OptionObject"/> instances.
    /// </summary>
    public static class OptionObjectBuilders
    {
        /// <summary>
        /// Creates a new <see cref="OptionObject"/> with the specified entity ID.
        /// </summary>
        /// <param name="entityId">The entity ID for the new OptionObject.</param>
        /// <returns>A new OptionObject with the specified entity ID.</returns>
        public static OptionObject CreateOptionObject(string entityId)
        {
            return OptionObject.Initialize()
                .WithEntityId(entityId);
        }

        /// <summary>
        /// Sets the EntityID on an <see cref="OptionObject"/> using a fluent interface.
        /// </summary>
        /// <param name="optionObject">The OptionObject to configure.</param>
        /// <param name="entityId">The entity ID to set.</param>
        /// <returns>The OptionObject for method chaining.</returns>
        public static OptionObject WithEntityId(this OptionObject optionObject, string entityId)
        {
            optionObject.EntityID = entityId;
            return optionObject;
        }

        /// <summary>
        /// Sets the ErrorCode and ErrorMessage on an <see cref="OptionObject"/> using a fluent interface.
        /// </summary>
        /// <param name="optionObject">The OptionObject to configure.</param>
        /// <param name="errorCode">The error code to set.</param>
        /// <param name="errorMessage">The error message to set.</param>
        /// <returns>The OptionObject for method chaining.</returns>
        public static OptionObject WithErrorCodeAndMessage(this OptionObject optionObject, double errorCode, string errorMessage)
        {
            optionObject.ErrorCode = errorCode;
            optionObject.ErrorMesg = errorMessage ?? string.Empty;
            return optionObject;
        }

        /// <summary>
        /// Adds a form to the Forms collection on an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to add to.</param>
        /// <param name="formObject">The form to add.</param>
        /// <returns>The OptionObject for method chaining.</returns>
        public static OptionObject AddForm(this OptionObject optionObject, FormObject formObject)
        {
            if (formObject != null)
            {
                optionObject.Forms.Add(formObject);
            }
            return optionObject;
        }
    }
}
