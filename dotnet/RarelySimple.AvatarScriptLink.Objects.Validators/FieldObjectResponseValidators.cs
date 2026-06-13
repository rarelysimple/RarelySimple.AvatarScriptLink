using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Validators
{
    /// <summary>
    /// Provides response validation extensions for <see cref="FieldObject"/> instances.
    /// </summary>
    public static class FieldObjectResponseValidators
    {
        /// <summary>
        /// Validates a response FieldObject.
        /// </summary>
        /// <param name="fieldObject">The field object to validate.</param>
        /// <returns>The response validation result.</returns>
        public static ResponseValidationResult ValidateResponse(this FieldObject? fieldObject)
        {
            var errors = new List<string>();

            if (fieldObject == null)
            {
                errors.Add(ResponseValidationMessages.FieldObjectIsNull);
                return new ResponseValidationResult(errors);
            }

            if (string.IsNullOrWhiteSpace(fieldObject.FieldNumber))
            {
                errors.Add(ResponseValidationMessages.FieldNumberIsRequired);
            }

            ValidateFlag(fieldObject.Enabled, "Enabled", errors);
            ValidateFlag(fieldObject.Lock, "Lock", errors);
            ValidateFlag(fieldObject.Required, "Required", errors);

            return new ResponseValidationResult(errors);
        }

        private static void ValidateFlag(string value, string name, List<string> errors)
        {
            if (!string.IsNullOrEmpty(value) && value != "0" && value != "1")
            {
                errors.Add(string.Format(ResponseValidationMessages.FieldFlagMustBeZeroOrOne, name));
            }
        }
    }
}
