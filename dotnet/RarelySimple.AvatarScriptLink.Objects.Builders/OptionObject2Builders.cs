namespace RarelySimple.AvatarScriptLink.Objects.Builders
{
    /// <summary>
    /// Provides extension methods for building and creating <see cref="OptionObject2"/> instances.
    /// </summary>
    /// <remarks>
    /// Note: OptionObject2 includes SessionToken but not ContinuationToken as found in other implementations.
    /// </remarks>
    public static class OptionObject2Builders
    {
        /// <summary>
        /// Creates a new <see cref="OptionObject2"/> with the specified entity ID.
        /// </summary>
        /// <param name="entityId">The entity ID for the new OptionObject2.</param>
        /// <returns>A new OptionObject2 with the specified entity ID.</returns>
        public static OptionObject2 CreateOptionObject2(string entityId)
        {
            return OptionObject2.Initialize()
                .WithEntityId(entityId);
        }

        /// <summary>
        /// Sets the EntityID on an <see cref="OptionObject2"/> using a fluent interface.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to configure.</param>
        /// <param name="entityId">The entity ID to set.</param>
        /// <returns>The OptionObject2 for method chaining.</returns>
        public static OptionObject2 WithEntityId(this OptionObject2 optionObject, string entityId)
        {
            optionObject.EntityID = entityId;
            return optionObject;
        }

        /// <summary>
        /// Sets the ErrorCode and ErrorMessage on an <see cref="OptionObject2"/> using a fluent interface.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to configure.</param>
        /// <param name="errorCode">The error code to set.</param>
        /// <param name="errorMessage">The error message to set.</param>
        /// <returns>The OptionObject2 for method chaining.</returns>
        public static OptionObject2 WithErrorCodeAndMessage(this OptionObject2 optionObject, double errorCode, string errorMessage)
        {
            optionObject.ErrorCode = errorCode;
            optionObject.ErrorMesg = errorMessage ?? string.Empty;
            return optionObject;
        }

        /// <summary>
        /// Adds a form to the Forms collection on an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to add to.</param>
        /// <param name="formObject">The form to add.</param>
        /// <returns>The OptionObject2 for method chaining.</returns>
        public static OptionObject2 AddForm(this OptionObject2 optionObject, FormObject formObject)
        {
            if (formObject != null)
            {
                optionObject.Forms.Add(formObject);
            }
            return optionObject;
        }
    }
}
