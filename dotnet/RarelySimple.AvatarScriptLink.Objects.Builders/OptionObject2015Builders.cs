namespace RarelySimple.AvatarScriptLink.Objects.Builders
{
    /// <summary>
    /// Provides extension methods for building and creating <see cref="OptionObject2015"/> instances.
    /// </summary>
    /// <remarks>
    /// Note: OptionObject2015 includes SessionToken which is not present in OptionObject2.
    /// </remarks>
    public static class OptionObject2015Builders
    {
        /// <summary>
        /// Creates a new <see cref="OptionObject2015"/> with the specified entity ID.
        /// </summary>
        /// <param name="entityId">The entity ID for the new OptionObject2015.</param>
        /// <returns>A new OptionObject2015 with the specified entity ID.</returns>
        public static OptionObject2015 CreateOptionObject2015(string entityId)
        {
            return OptionObject2015.Initialize()
                .WithEntityId(entityId);
        }

        /// <summary>
        /// Sets the EntityID on an <see cref="OptionObject2015"/> using a fluent interface.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to configure.</param>
        /// <param name="entityId">The entity ID to set.</param>
        /// <returns>The OptionObject2015 for method chaining.</returns>
        public static OptionObject2015 WithEntityId(this OptionObject2015 optionObject, string entityId)
        {
            optionObject.EntityID = entityId;
            return optionObject;
        }

        /// <summary>
        /// Sets the ErrorCode and ErrorMessage on an <see cref="OptionObject2015"/> using a fluent interface.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to configure.</param>
        /// <param name="errorCode">The error code to set.</param>
        /// <param name="errorMessage">The error message to set.</param>
        /// <returns>The OptionObject2015 for method chaining.</returns>
        public static OptionObject2015 WithErrorCodeAndMessage(this OptionObject2015 optionObject, double errorCode, string errorMessage)
        {
            optionObject.ErrorCode = errorCode;
            optionObject.ErrorMesg = errorMessage ?? string.Empty;
            return optionObject;
        }

        /// <summary>
        /// Adds a form to the Forms collection on an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to add to.</param>
        /// <param name="formObject">The form to add.</param>
        /// <returns>The OptionObject2015 for method chaining.</returns>
        public static OptionObject2015 AddForm(this OptionObject2015 optionObject, FormObject formObject)
        {
            if (formObject != null)
            {
                optionObject.Forms.Add(formObject);
            }
            return optionObject;
        }

        /// <summary>
        /// Sets the SessionToken on an <see cref="OptionObject2015"/> using a fluent interface.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to configure.</param>
        /// <param name="sessionToken">The session token to set.</param>
        /// <returns>The OptionObject2015 for method chaining.</returns>
        public static OptionObject2015 WithSessionToken(this OptionObject2015 optionObject, string sessionToken)
        {
            optionObject.SessionToken = sessionToken;
            return optionObject;
        }

        /// <summary>
        /// Sets the OptionUserId on an <see cref="OptionObject2015"/> using a fluent interface.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to configure.</param>
        /// <param name="userId">The option user ID to set.</param>
        /// <returns>The OptionObject2015 for method chaining.</returns>
        public static OptionObject2015 WithOptionUserId(this OptionObject2015 optionObject, string userId)
        {
            optionObject.OptionUserId = userId;
            return optionObject;
        }
    }
}
