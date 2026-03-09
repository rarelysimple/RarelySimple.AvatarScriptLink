using System;
using System.Collections.Generic;
using System.Linq;
using RarelySimple.AvatarScriptLink.Objects.Helpers.Validators;

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
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

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
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

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
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetDisabledFields(formFieldNumbers);
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
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

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
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

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
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetEnabledFields(formFieldNumbers);
            }

            return optionObject;
        }

        /// <summary>
        /// Locks a <see cref="FieldObject"/> in an <see cref="OptionObject2015"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumber">The field number to lock.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetLockedField(this OptionObject2015 optionObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                form.SetLockedField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Locks <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldObjects">The field objects to lock.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetLockedFields(this OptionObject2015 optionObject, List<FieldObject>? fieldObjects)
        {
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

            return optionObject.SetLockedFields(fieldNumbers);
        }

        /// <summary>
        /// Locks <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumbers">The field numbers to lock.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetLockedFields(this OptionObject2015 optionObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetLockedFields(formFieldNumbers);
            }

            return optionObject;
        }

        /// <summary>
        /// Unlocks a <see cref="FieldObject"/> in an <see cref="OptionObject2015"/> by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumber">The field number to unlock.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetUnlockedField(this OptionObject2015 optionObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                form.SetUnlockedField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Unlocks <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldObjects">The field objects to unlock.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetUnlockedFields(this OptionObject2015 optionObject, List<FieldObject>? fieldObjects)
        {
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

            return optionObject.SetUnlockedFields(fieldNumbers);
        }

        /// <summary>
        /// Unlocks <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/> by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumbers">The field numbers to unlock.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetUnlockedFields(this OptionObject2015 optionObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetUnlockedFields(formFieldNumbers);
            }

            return optionObject;
        }

        /// <summary>
        /// Marks a <see cref="FieldObject"/> in an <see cref="OptionObject2015"/> as required by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumber">The field number to mark as required.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetRequiredField(this OptionObject2015 optionObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                if (!form.IsFieldPresent(fieldNumber))
                    continue;

                form.SetRequiredField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Marks <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/> as required.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldObjects">The field objects to mark as required.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetRequiredFields(this OptionObject2015 optionObject, List<FieldObject>? fieldObjects)
        {
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

            return optionObject.SetRequiredFields(fieldNumbers);
        }

        /// <summary>
        /// Marks <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/> as required by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumbers">The field numbers to mark as required.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetRequiredFields(this OptionObject2015 optionObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetRequiredFields(formFieldNumbers);
            }

            return optionObject;
        }

        /// <summary>
        /// Marks a <see cref="FieldObject"/> in an <see cref="OptionObject2015"/> as optional by field number.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumber">The field number to mark as optional.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetOptionalField(this OptionObject2015 optionObject, string fieldNumber)
        {
            ArgumentGuards.ValidateFieldNumber(fieldNumber, nameof(fieldNumber));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            if (!optionObject.Forms.Any(f => f.IsFieldPresent(fieldNumber)))
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumber));

            foreach (var form in optionObject.Forms)
            {
                if (!form.IsFieldPresent(fieldNumber))
                    continue;

                form.SetOptionalField(fieldNumber);
            }

            return optionObject;
        }

        /// <summary>
        /// Marks <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/> as optional.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldObjects">The field objects to mark as optional.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetOptionalFields(this OptionObject2015 optionObject, List<FieldObject>? fieldObjects)
        {
            var fieldNumbers = ArgumentGuards.ValidateAndGetFieldNumbers(fieldObjects, nameof(fieldObjects));

            return optionObject.SetOptionalFields(fieldNumbers);
        }

        /// <summary>
        /// Marks <see cref="FieldObject"/> instances in an <see cref="OptionObject2015"/> as optional by field numbers.
        /// </summary>
        /// <param name="optionObject">The OptionObject2015 to modify.</param>
        /// <param name="fieldNumbers">The field numbers to mark as optional.</param>
        /// <returns>The modified OptionObject2015.</returns>
        public static OptionObject2015? SetOptionalFields(this OptionObject2015 optionObject, List<string>? fieldNumbers)
        {
            var fieldsToSet = ArgumentGuards.ValidateAndNormalizeFieldNumbers(fieldNumbers, nameof(fieldNumbers));

            if (optionObject == null || optionObject.Forms == null)
                return optionObject;

            fieldsToSet = fieldsToSet
                .Where(f => optionObject.Forms.Any(form => form.IsFieldPresent(f)))
                .ToList();

            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ArgumentGuards.NoMatchingFieldObjectsMessage, nameof(fieldNumbers));

            foreach (var form in optionObject.Forms)
            {
                var formFieldNumbers = fieldsToSet.Where(form.IsFieldPresent).ToList();
                if (formFieldNumbers.Count == 0)
                    continue;

                form.SetOptionalFields(formFieldNumbers);
            }

            return optionObject;
        }
    }
}
