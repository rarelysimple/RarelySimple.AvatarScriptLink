using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Validators
{
    /// <summary>
    /// Represents the result of response validation.
    /// </summary>
    public sealed class ResponseValidationResult
    {
        private readonly List<string> errors;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseValidationResult"/> class.
        /// </summary>
        /// <param name="errors">The validation errors.</param>
        public ResponseValidationResult(List<string> errors)
        {
            this.errors = errors ?? new List<string>();
        }

        /// <summary>
        /// Gets a value indicating whether the response is valid.
        /// </summary>
        public bool IsValid => errors.Count == 0;

        /// <summary>
        /// Gets the validation errors.
        /// </summary>
        public IReadOnlyList<string> Errors => errors;
    }
}
