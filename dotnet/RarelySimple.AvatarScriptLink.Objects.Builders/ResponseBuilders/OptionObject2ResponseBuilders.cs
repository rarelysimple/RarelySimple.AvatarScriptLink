using System;

namespace RarelySimple.AvatarScriptLink.Objects.Builders.ResponseBuilders
{
    /// <summary>
    /// Provides response builder extensions for <see cref="OptionObject2"/> instances.
    /// </summary>
    public static class OptionObject2ResponseBuilders
    {
        /// <summary>
        /// Creates a return payload from the source <see cref="OptionObject2"/> by cloning and removing unedited rows.
        /// </summary>
        /// <param name="optionObject">The source option object.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2 ToReturnOptionObject(this OptionObject2 optionObject)
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
        /// Creates a return payload from the source <see cref="OptionObject2"/> by cloning, removing unedited rows, and setting error details.
        /// </summary>
        /// <param name="optionObject">The source option object.</param>
        /// <param name="errorCode">The error code to set on the return payload.</param>
        /// <param name="errorMessage">The error message to set on the return payload.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2 ToReturnOptionObject(this OptionObject2 optionObject, double errorCode, string errorMessage)
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
        public static OptionObject2 ToReturnOptionObject(this OptionObject2 optionObject, OptionObject2 baselineOptionObject)
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
        public static OptionObject2 ToReturnOptionObject(this OptionObject2 optionObject, OptionObject2 baselineOptionObject, double errorCode, string errorMessage)
        {
            var returnOptionObject = optionObject.ToReturnOptionObject(baselineOptionObject);
            returnOptionObject.ErrorCode = errorCode;
            returnOptionObject.ErrorMesg = errorMessage ?? string.Empty;
            return returnOptionObject;
        }

        /// <summary>
        /// Creates a return payload from the source <see cref="OptionObject2"/> by cloning and removing unedited rows.
        /// </summary>
        /// <param name="optionObject">The source option object.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2 GetReturnOptionObject(this OptionObject2 optionObject)
        {
            return optionObject.ToReturnOptionObject();
        }

        /// <summary>
        /// Creates a return payload from the source <see cref="OptionObject2"/> by cloning, removing unedited rows, and setting error details.
        /// </summary>
        /// <param name="optionObject">The source option object.</param>
        /// <param name="errorCode">The error code to set on the return payload.</param>
        /// <param name="errorMessage">The error message to set on the return payload.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2 GetReturnOptionObject(this OptionObject2 optionObject, double errorCode, string errorMessage)
        {
            return optionObject.ToReturnOptionObject(errorCode, errorMessage);
        }

        /// <summary>
        /// Creates a return payload by cloning and pruning against a baseline request object.
        /// </summary>
        /// <param name="optionObject">The working option object.</param>
        /// <param name="baselineOptionObject">The original request option object used as baseline.</param>
        /// <returns>A finalized return payload.</returns>
        public static OptionObject2 GetReturnOptionObject(this OptionObject2 optionObject, OptionObject2 baselineOptionObject)
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
        public static OptionObject2 GetReturnOptionObject(this OptionObject2 optionObject, OptionObject2 baselineOptionObject, double errorCode, string errorMessage)
        {
            return optionObject.ToReturnOptionObject(baselineOptionObject, errorCode, errorMessage);
        }

        /// <summary>
        /// Creates a success response <see cref="OptionObject2"/> with the specified entity ID.
        /// </summary>
        /// <param name="entityId">The entity ID for the response.</param>
        /// <returns>A success response OptionObject2.</returns>
        public static OptionObject2 CreateSuccessResponse(string entityId)
        {
            return OptionObject2.Initialize()
                .WithEntityId(entityId)
                .AsSuccessResponse();
        }

        /// <summary>
        /// Creates an error response <see cref="OptionObject2"/> with the specified entity ID and error details.
        /// </summary>
        /// <param name="entityId">The entity ID for the response.</param>
        /// <param name="errorCode">The error code to set.</param>
        /// <param name="errorMessage">The error message to set.</param>
        /// <returns>An error response OptionObject2.</returns>
        public static OptionObject2 CreateErrorResponse(string entityId, double errorCode, string errorMessage)
        {
            return OptionObject2.Initialize()
                .WithEntityId(entityId)
                .AsErrorResponse(errorCode, errorMessage);
        }

        /// <summary>
        /// Marks an <see cref="OptionObject2"/> as a success response.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to configure.</param>
        /// <returns>The OptionObject2 for method chaining.</returns>
        public static OptionObject2 AsSuccessResponse(this OptionObject2 optionObject)
        {
            return optionObject.WithErrorCodeAndMessage(0, string.Empty);
        }

        /// <summary>
        /// Marks an <see cref="OptionObject2"/> as an error response.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to configure.</param>
        /// <param name="errorCode">The error code to set.</param>
        /// <param name="errorMessage">The error message to set.</param>
        /// <returns>The OptionObject2 for method chaining.</returns>
        public static OptionObject2 AsErrorResponse(this OptionObject2 optionObject, double errorCode, string errorMessage)
        {
            return optionObject.WithErrorCodeAndMessage(errorCode, errorMessage);
        }

        /// <summary>
        /// Creates and adds a response form to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2 to add to.</param>
        /// <param name="formId">The form ID to assign.</param>
        /// <param name="multipleIteration">True if the form has multiple iteration, false otherwise.</param>
        /// <returns>The created FormObject.</returns>
        public static FormObject AddResponseForm(this OptionObject2 optionObject, string formId, bool multipleIteration = false)
        {
            var formObject = FormObjectBuilders.CreateFormObject(formId)
                .WithMultipleIteration(multipleIteration);

            optionObject.AddForm(formObject);
            return formObject;
        }
    }
}
