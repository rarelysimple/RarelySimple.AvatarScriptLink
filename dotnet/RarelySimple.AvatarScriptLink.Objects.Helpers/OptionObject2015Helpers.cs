using System;

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
    }
}
