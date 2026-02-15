using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Validators
{
    /// <summary>
    /// Provides response validation extensions for <see cref="RowObject"/> instances.
    /// </summary>
    public static class RowObjectResponseValidators
    {
        /// <summary>
        /// Validates a response RowObject.
        /// </summary>
        /// <param name="rowObject">The row object to validate.</param>
        /// <returns>The response validation result.</returns>
        public static ResponseValidationResult ValidateResponse(this RowObject? rowObject)
        {
            var errors = new List<string>();

            if (rowObject == null)
            {
                errors.Add("RowObject is null.");
                return new ResponseValidationResult(errors);
            }

            if (string.IsNullOrWhiteSpace(rowObject.RowId))
            {
                errors.Add("RowId is required.");
            }

            if (!IsValidRowAction(rowObject.RowAction))
            {
                errors.Add("RowAction must be ADD, EDIT, DELETE, or empty.");
            }

            if (rowObject.Fields == null)
            {
                errors.Add("Fields collection must not be null.");
                return new ResponseValidationResult(errors);
            }

            if (rowObject.Fields.Count > 0 && string.IsNullOrEmpty(rowObject.RowAction))
            {
                errors.Add("RowAction is required when row contains fields.");
            }

            for (int i = 0; i < rowObject.Fields.Count; i++)
            {
                var fieldResult = rowObject.Fields[i].ValidateResponse();
                foreach (var error in fieldResult.Errors)
                {
                    errors.Add($"Fields[{i}]: {error}");
                }
            }

            return new ResponseValidationResult(errors);
        }

        private static bool IsValidRowAction(string value)
        {
            return string.IsNullOrEmpty(value) ||
                   value == RowObject.RowActions.Add ||
                   value == RowObject.RowActions.Edit ||
                   value == RowObject.RowActions.Delete;
        }
    }
}
