namespace RarelySimple.AvatarScriptLink.Objects.Builders.ResponseBuilders
{
    /// <summary>
    /// Provides response builder extensions for <see cref="OptionObject"/> instances.
    /// </summary>
    public static class OptionObjectResponseBuilders
    {
        /// <summary>
        /// Creates a success response <see cref="OptionObject"/> with the specified entity ID.
        /// </summary>
        /// <param name="entityId">The entity ID for the response.</param>
        /// <returns>A success response OptionObject.</returns>
        public static OptionObject CreateSuccessResponse(string entityId)
        {
            return OptionObject.Initialize()
                .WithEntityId(entityId)
                .AsSuccessResponse();
        }

        /// <summary>
        /// Creates an error response <see cref="OptionObject"/> with the specified entity ID and error details.
        /// </summary>
        /// <param name="entityId">The entity ID for the response.</param>
        /// <param name="errorCode">The error code to set.</param>
        /// <param name="errorMessage">The error message to set.</param>
        /// <returns>An error response OptionObject.</returns>
        public static OptionObject CreateErrorResponse(string entityId, double errorCode, string errorMessage)
        {
            return OptionObject.Initialize()
                .WithEntityId(entityId)
                .AsErrorResponse(errorCode, errorMessage);
        }

        /// <summary>
        /// Marks an <see cref="OptionObject"/> as a success response.
        /// </summary>
        /// <param name="optionObject">The OptionObject to configure.</param>
        /// <returns>The OptionObject for method chaining.</returns>
        public static OptionObject AsSuccessResponse(this OptionObject optionObject)
        {
            return optionObject.WithErrorCodeAndMessage(0, string.Empty);
        }

        /// <summary>
        /// Marks an <see cref="OptionObject"/> as an error response.
        /// </summary>
        /// <param name="optionObject">The OptionObject to configure.</param>
        /// <param name="errorCode">The error code to set.</param>
        /// <param name="errorMessage">The error message to set.</param>
        /// <returns>The OptionObject for method chaining.</returns>
        public static OptionObject AsErrorResponse(this OptionObject optionObject, double errorCode, string errorMessage)
        {
            return optionObject.WithErrorCodeAndMessage(errorCode, errorMessage);
        }

        /// <summary>
        /// Creates and adds a response form to an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject to add to.</param>
        /// <param name="formId">The form ID to assign.</param>
        /// <param name="multipleIteration">True if the form has multiple iteration, false otherwise.</param>
        /// <returns>The created FormObject.</returns>
        public static FormObject AddResponseForm(this OptionObject optionObject, string formId, bool multipleIteration = false)
        {
            var formObject = FormObjectBuilders.CreateFormObject(formId)
                .WithMultipleIteration(multipleIteration);

            optionObject.AddForm(formObject);
            return formObject;
        }
    }
}
