using System;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Validators
{
    /// <summary>
    /// Provides extension methods for validating <see cref="FieldObject"/> instances.
    /// </summary>
    public static class FieldObjectValidators
    {
        /// <summary>
        /// Determines if a <see cref="FieldObject"/> has a value.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to validate.</param>
        /// <returns>True if the field has a non-empty value, false otherwise.</returns>
        public static bool HasValue(this FieldObject fieldObject)
        {
            return !string.IsNullOrEmpty(fieldObject?.FieldValue);
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> has an empty or null value.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to validate.</param>
        /// <returns>True if the field has an empty or null value, false otherwise.</returns>
        public static bool IsEmpty(this FieldObject fieldObject)
        {
            return string.IsNullOrEmpty(fieldObject?.FieldValue);
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> matches a specific value.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to validate.</param>
        /// <param name="value">The value to compare.</param>
        /// <returns>True if the field value matches the provided value, false otherwise.</returns>
        public static bool ValueEquals(this FieldObject fieldObject, string value)
        {
            return fieldObject?.FieldValue == value;
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> value matches a value (case-insensitive).
        /// </summary>
        /// <param name="fieldObject">The FieldObject to validate.</param>
        /// <param name="value">The value to compare.</param>
        /// <returns>True if the field value matches the provided value (case-insensitive), false otherwise.</returns>
        public static bool ValueEqualsIgnoreCase(this FieldObject fieldObject, string value)
        {
            return string.Equals(fieldObject?.FieldValue, value, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> value contains a specific substring.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to validate.</param>
        /// <param name="substring">The substring to search for.</param>
        /// <returns>True if the field value contains the substring, false otherwise.</returns>
        public static bool ValueContains(this FieldObject fieldObject, string substring)
        {
            return fieldObject?.FieldValue?.Contains(substring) == true;
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> value starts with a specific prefix.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to validate.</param>
        /// <param name="prefix">The prefix to check for.</param>
        /// <returns>True if the field value starts with the prefix, false otherwise.</returns>
        public static bool ValueStartsWith(this FieldObject fieldObject, string prefix)
        {
            return fieldObject?.FieldValue?.StartsWith(prefix) == true;
        }

        /// <summary>
        /// Determines if a <see cref="FieldObject"/> value ends with a specific suffix.
        /// </summary>
        /// <param name="fieldObject">The FieldObject to validate.</param>
        /// <param name="suffix">The suffix to check for.</param>
        /// <returns>True if the field value ends with the suffix, false otherwise.</returns>
        public static bool ValueEndsWith(this FieldObject fieldObject, string suffix)
        {
            return fieldObject?.FieldValue?.EndsWith(suffix) == true;
        }
    }
}
