using System;
using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers
{
    /// <summary>
    /// Provides extension methods for querying and manipulating <see cref="OptionObject2015"/> instances.
    /// </summary>
    public static class OptionObject2015Helpers
    {
        /// <summary>
        /// Gets the entity ID of an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to query.</param>
        /// <returns>The entity ID, or null if not set.</returns>
        public static string? GetEntityId(this OptionObject2015 optionObject)
        {
            return optionObject?.EntityID;
        }

        /// <summary>
        /// Gets the error code of an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to query.</param>
        /// <returns>The error code.</returns>
        public static double GetErrorCode(this OptionObject2015 optionObject)
        {
            return optionObject?.ErrorCode ?? 0;
        }

        /// <summary>
        /// Gets the error message of an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to query.</param>
        /// <returns>The error message, or null if not set.</returns>
        public static string? GetErrorMessage(this OptionObject2015 optionObject)
        {
            return optionObject?.ErrorMesg;
        }

        /// <summary>
        /// Gets the total number of forms in an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to query.</param>
        /// <returns>The number of forms.</returns>
        public static int GetFormCount(this OptionObject2015 optionObject)
        {
            return optionObject?.Forms?.Count ?? 0;
        }

        /// <summary>
        /// Gets the session token of an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to query.</param>
        /// <returns>The session token, or null if not set.</returns>
        public static string? GetSessionToken(this OptionObject2015 optionObject)
        {
            return optionObject?.SessionToken;
        }

        /// <summary>
        /// Gets the option user ID of an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to query.</param>
        /// <returns>The option user ID, or null if not set.</returns>
        public static string? GetOptionUserId(this OptionObject2015 optionObject)
        {
            return optionObject?.OptionUserId;
        }

        /// <summary>
        /// Determines if an <see cref="OptionObject2015"/> has an error.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to query.</param>
        /// <returns>True if the error code is not 0, false otherwise.</returns>
        public static bool HasError(this OptionObject2015 optionObject)
        {
            return Math.Abs(optionObject?.ErrorCode ?? 0d) > double.Epsilon;
        }

        /// <summary>
        /// Disables a <see cref="FieldObject"/> in an <see cref="OptionObject2015"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumber">The field number to disable.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetDisabledField(this OptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(fieldNumber))
                return optionObject;

            foreach (var form in optionObject.Forms)
            {
                form.SetDisabledField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Disables <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldObjects">The field objects to disable.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetDisabledFields(this OptionObject2015 optionObject, List<FieldObject>? fieldObjects)
        {
            if (fieldObjects == null || fieldObjects.Count == 0)
                return optionObject;

            var fieldNumbers = fieldObjects
                .Where(f => !string.IsNullOrEmpty(f?.FieldNumber))
                .Select(f => f.FieldNumber)
                .ToList();

            return optionObject.SetDisabledFields(fieldNumbers);
        }

        /// <summary>
        /// Disables <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumbers">The field numbers to disable.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetDisabledFields(this OptionObject2015 optionObject, List<string>? fieldNumbers)
        {
            if (optionObject == null || optionObject.Forms == null || fieldNumbers == null || fieldNumbers.Count == 0)
                return optionObject;

            foreach (var form in optionObject.Forms)
            {
                form.SetDisabledFields(fieldNumbers);
            }

            return optionObject;
        }

        /// <summary>
        /// Enables a <see cref="FieldObject"/> in an <see cref="OptionObject2015"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumber">The field number to enable.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetEnabledField(this OptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null || optionObject.Forms == null || string.IsNullOrEmpty(fieldNumber))
                return optionObject;

            foreach (var form in optionObject.Forms)
            {
                form.SetEnabledField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Enables <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldObjects">The field objects to enable.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetEnabledFields(this OptionObject2015 optionObject, List<FieldObject>? fieldObjects)
        {
            if (fieldObjects == null || fieldObjects.Count == 0)
                return optionObject;

            var fieldNumbers = fieldObjects
                .Where(f => !string.IsNullOrEmpty(f?.FieldNumber))
                .Select(f => f.FieldNumber)
                .ToList();

            return optionObject.SetEnabledFields(fieldNumbers);
        }

        /// <summary>
        /// Enables <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumbers">The field numbers to enable.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetEnabledFields(this OptionObject2015 optionObject, List<string>? fieldNumbers)
        {
            if (optionObject == null || optionObject.Forms == null || fieldNumbers == null || fieldNumbers.Count == 0)
                return optionObject;

            foreach (var form in optionObject.Forms)
            {
                form.SetEnabledFields(fieldNumbers);
            }

            return optionObject;
        }
    }
}
