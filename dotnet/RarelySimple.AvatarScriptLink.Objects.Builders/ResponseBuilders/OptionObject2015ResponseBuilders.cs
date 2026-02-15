namespace RarelySimple.AvatarScriptLink.Objects.Builders.ResponseBuilders
{
    /// <summary>
    /// Provides response builder extensions for <see cref="OptionObject2015"/> instances.
    /// </summary>
    public static class OptionObject2015ResponseBuilders
    {
        /// <summary>
        /// Creates a success response <see cref="OptionObject2015"/> with the specified entity ID.
        /// </summary>
        /// <param name="entityId">The entity ID for the response.</param>
        /// <returns>A success response OptionObject2015.</returns>
        public static OptionObject2015 CreateSuccessResponse(string entityId)
        {
            return OptionObject2015.Initialize()
                .WithEntityId(entityId)
                .AsSuccessResponse();
        }

        /// <summary>
        /// Creates a success response <see cref="OptionObject2015"/> with the specified entity ID and session details.
        /// </summary>
        /// <param name="entityId">The entity ID for the response.</param>
        /// <param name="sessionToken">The session token to set.</param>
        /// <param name="optionUserId">The option user ID to set, if provided.</param>
        /// <returns>A success response OptionObject2015.</returns>
        public static OptionObject2015 CreateSuccessResponse(string entityId, string sessionToken, string optionUserId = null)
        {
            var optionObject = CreateSuccessResponse(entityId);
            optionObject.SessionToken = sessionToken;
            if (optionUserId != null)
            {
                optionObject.OptionUserId = optionUserId;
            }
            return optionObject;
        }

        /// <summary>
        /// Creates an error response <see cref="OptionObject2015"/> with the specified entity ID and error details.
        /// </summary>
        /// <param name="entityId">The entity ID for the response.</param>
        /// <param name="errorCode">The error code to set.</param>
        /// <param name="errorMessage">The error message to set.</param>
        /// <returns>An error response OptionObject2015.</returns>
        public static OptionObject2015 CreateErrorResponse(string entityId, double errorCode, string errorMessage)
        {
            return OptionObject2015.Initialize()
                .WithEntityId(entityId)
                .AsErrorResponse(errorCode, errorMessage);
        }

        /// <summary>
        /// Creates an error response <see cref="OptionObject2015"/> with the specified entity ID, error details, and session details.
        /// </summary>
        /// <param name="entityId">The entity ID for the response.</param>
        /// <param name="errorCode">The error code to set.</param>
        /// <param name="errorMessage">The error message to set.</param>
        /// <param name="sessionToken">The session token to set.</param>
        /// <param name="optionUserId">The option user ID to set, if provided.</param>
        /// <returns>An error response OptionObject2015.</returns>
        public static OptionObject2015 CreateErrorResponse(string entityId, double errorCode, string errorMessage, string sessionToken, string optionUserId = null)
        {
            var optionObject = CreateErrorResponse(entityId, errorCode, errorMessage);
            optionObject.SessionToken = sessionToken;
            if (optionUserId != null)
            {
                optionObject.OptionUserId = optionUserId;
            }
            return optionObject;
        }

        /// <summary>
        /// Marks an <see cref="OptionObject2015"/> as a success response.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to configure.</param>
        /// <returns>The OptionObject2015 for method chaining.</returns>
        public static OptionObject2015 AsSuccessResponse(this OptionObject2015 optionObject)
        {
            return optionObject.WithErrorCodeAndMessage(0, string.Empty);
        }

        /// <summary>
        /// Marks an <see cref="OptionObject2015"/> as an error response.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to configure.</param>
        /// <param name="errorCode">The error code to set.</param>
        /// <param name="errorMessage">The error message to set.</param>
        /// <returns>The OptionObject2015 for method chaining.</returns>
        public static OptionObject2015 AsErrorResponse(this OptionObject2015 optionObject, double errorCode, string errorMessage)
        {
            return optionObject.WithErrorCodeAndMessage(errorCode, errorMessage);
        }

        /// <summary>
        /// Creates and adds a response form to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to add to.</param>
        /// <param name="formId">The form ID to assign.</param>
        /// <param name="multipleIteration">True if the form has multiple iteration, false otherwise.</param>
        /// <returns>The created FormObject.</returns>
        public static FormObject AddResponseForm(this OptionObject2015 optionObject, string formId, bool multipleIteration = false)
        {
            var formObject = FormObjectBuilders.CreateFormObject(formId)
                .WithMultipleIteration(multipleIteration);

            optionObject.AddForm(formObject);
            return formObject;
        }
    }
}
