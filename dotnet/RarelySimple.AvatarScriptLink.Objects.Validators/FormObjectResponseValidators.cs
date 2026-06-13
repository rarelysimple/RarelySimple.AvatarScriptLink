using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Validators
{
    /// <summary>
    /// Provides response validation extensions for <see cref="FormObject"/> instances.
    /// </summary>
    public static class FormObjectResponseValidators
    {
        /// <summary>
        /// Validates a response FormObject.
        /// </summary>
        /// <param name="formObject">The form object to validate.</param>
        /// <returns>The response validation result.</returns>
        public static ResponseValidationResult ValidateResponse(this FormObject? formObject)
        {
            var errors = new List<string>();

            if (formObject == null)
            {
                errors.Add(ResponseValidationMessages.FormObjectIsNull);
                return new ResponseValidationResult(errors);
            }

            if (string.IsNullOrWhiteSpace(formObject.FormId))
            {
                errors.Add(ResponseValidationMessages.FormIdIsRequired);
            }

            if (formObject.OtherRows == null)
            {
                errors.Add(ResponseValidationMessages.OtherRowsCollectionMustNotBeNull);
                return new ResponseValidationResult(errors);
            }

            if (!formObject.MultipleIteration && formObject.OtherRows.Count > 0)
            {
                errors.Add(ResponseValidationMessages.OtherRowsMustBeEmptyWhenMultipleIterationIsFalse);
            }

            if (formObject.CurrentRow != null)
            {
                var currentRowResult = formObject.CurrentRow.ValidateResponse();
                foreach (var error in currentRowResult.Errors)
                {
                    errors.Add($"CurrentRow: {error}");
                }
            }

            for (int i = 0; i < formObject.OtherRows.Count; i++)
            {
                var rowResult = formObject.OtherRows[i].ValidateResponse();
                foreach (var error in rowResult.Errors)
                {
                    errors.Add($"OtherRows[{i}]: {error}");
                }
            }

            return new ResponseValidationResult(errors);
        }
    }
}
