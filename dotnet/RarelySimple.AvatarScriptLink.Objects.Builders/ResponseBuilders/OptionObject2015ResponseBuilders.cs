using System;

namespace RarelySimple.AvatarScriptLink.Objects.Builders.ResponseBuilders
{
    /// <summary>
    /// Provides response builder extensions for <see cref="OptionObject2015"/> instances.
    /// </summary>
    public static class OptionObject2015ResponseBuilders
    {
        /// <summary>
        /// Creates a return payload from the source <see cref="OptionObject2015"/> by cloning and removing unedited rows.
        /// </summary>
        /// <param name="optionObject">The source option object.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2015 ToReturnOptionObject(this OptionObject2015 optionObject)
        {
            if (optionObject == null)
            {
                throw new ArgumentNullException(nameof(optionObject));
            }

            var returnOptionObject = optionObject.Clone();
            ResponseFinalizationHelpers.RemoveUneditedRows(returnOptionObject.Forms);
            return returnOptionObject;
        }

        /// <summary>
        /// Creates a return payload from the source <see cref="OptionObject2015"/> by cloning, removing unedited rows, and setting error details.
        /// </summary>
        /// <param name="optionObject">The source option object.</param>
        /// <param name="errorCode">The error code to set on the return payload.</param>
        /// <param name="errorMessage">The error message to set on the return payload.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2015 ToReturnOptionObject(this OptionObject2015 optionObject, double errorCode, string errorMessage)
        {
            var returnOptionObject = optionObject.ToReturnOptionObject();
            returnOptionObject.ErrorCode = errorCode;
            returnOptionObject.ErrorMesg = errorMessage ?? string.Empty;
            return returnOptionObject;
        }

        /// <summary>
        /// Creates a return payload by cloning and pruning against a baseline request object.
        /// </summary>
        /// <param name="optionObject">The working option object.</param>
        /// <param name="baselineOptionObject">The original request option object used as baseline.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2015 ToReturnOptionObject(this OptionObject2015 optionObject, OptionObject2015 baselineOptionObject)
        {
            if (optionObject == null)
            {
                throw new ArgumentNullException(nameof(optionObject));
            }

            if (baselineOptionObject == null)
            {
                return optionObject.ToReturnOptionObject();
            }

            var returnOptionObject = optionObject.Clone();
            ResponseFinalizationHelpers.RemoveUneditedRows(returnOptionObject.Forms, baselineOptionObject.Forms);
            return returnOptionObject;
        }

        /// <summary>
        /// Creates a return payload by cloning and pruning against a baseline request object, then applies error details.
        /// </summary>
        /// <param name="optionObject">The working option object.</param>
        /// <param name="baselineOptionObject">The original request option object used as baseline.</param>
        /// <param name="errorCode">The error code to set on the return payload.</param>
        /// <param name="errorMessage">The error message to set on the return payload.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2015 ToReturnOptionObject(this OptionObject2015 optionObject, OptionObject2015 baselineOptionObject, double errorCode, string errorMessage)
        {
            var returnOptionObject = optionObject.ToReturnOptionObject(baselineOptionObject);
            returnOptionObject.ErrorCode = errorCode;
            returnOptionObject.ErrorMesg = errorMessage ?? string.Empty;
            return returnOptionObject;
        }

        /// <summary>
        /// Creates a return payload from the source <see cref="OptionObject2015"/> by cloning and removing unedited rows.
        /// </summary>
        /// <param name="optionObject">The source option object.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2015 GetReturnOptionObject(this OptionObject2015 optionObject)
        {
            return optionObject.ToReturnOptionObject();
        }

        /// <summary>
        /// Creates a return payload from the source <see cref="OptionObject2015"/> by cloning, removing unedited rows, and setting error details.
        /// </summary>
        /// <param name="optionObject">The source option object.</param>
        /// <param name="errorCode">The error code to set on the return payload.</param>
        /// <param name="errorMessage">The error message to set on the return payload.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2015 GetReturnOptionObject(this OptionObject2015 optionObject, double errorCode, string errorMessage)
        {
            return optionObject.ToReturnOptionObject(errorCode, errorMessage);
        }

        /// <summary>
        /// Creates a return payload by cloning and pruning against a baseline request object.
        /// </summary>
        /// <param name="optionObject">The working option object.</param>
        /// <param name="baselineOptionObject">The original request option object used as baseline.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2015 GetReturnOptionObject(this OptionObject2015 optionObject, OptionObject2015 baselineOptionObject)
        {
            return optionObject.ToReturnOptionObject(baselineOptionObject);
        }

        /// <summary>
        /// Creates a return payload by cloning and pruning against a baseline request object, then applies error details.
        /// </summary>
        /// <param name="optionObject">The working option object.</param>
        /// <param name="baselineOptionObject">The original request option object used as baseline.</param>
        /// <param name="errorCode">The error code to set on the return payload.</param>
        /// <param name="errorMessage">The error message to set on the return payload.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2015 GetReturnOptionObject(this OptionObject2015 optionObject, OptionObject2015 baselineOptionObject, double errorCode, string errorMessage)
        {
            return optionObject.ToReturnOptionObject(baselineOptionObject, errorCode, errorMessage);
        }

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
