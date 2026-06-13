using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using RarelySimple.AvatarScriptLink.Objects.Interfaces;

namespace RarelySimple.AvatarScriptLink.Objects.Validators
{
    /// <summary>
    /// Provides response validation extensions for OptionObject variants.
    /// </summary>
    public static class OptionObjectResponseValidators
    {
        /// <summary>
        /// Validates a response OptionObject.
        /// </summary>
        /// <param name="optionObject">The option object to validate.</param>
        /// <returns>The response validation result.</returns>
        public static ResponseValidationResult ValidateResponse(this IOptionObject? optionObject)
        {
            var errors = new List<string>();

            if (optionObject == null)
            {
                errors.Add(ResponseValidationMessages.OptionObjectIsNull);
                return new ResponseValidationResult(errors);
            }

            if (string.IsNullOrWhiteSpace(optionObject.EntityID))
            {
                errors.Add(ResponseValidationMessages.EntityIdIsRequired);
            }

            ValidateErrorCode(optionObject.ErrorCode, errors);
            ValidateErrorMessage(optionObject.ErrorCode, optionObject.ErrorMesg ?? string.Empty, errors);

            return new ResponseValidationResult(errors);
        }

        /// <summary>
        /// Determines whether a response OptionObject is valid.
        /// </summary>
        /// <param name="optionObject">The option object to validate.</param>
        /// <returns>True if valid, false otherwise.</returns>
        public static bool IsValidResponse(this IOptionObject? optionObject)
        {
            return optionObject.ValidateResponse().IsValid;
        }

        /// <summary>
        /// Validates a response OptionObject including payload forms, rows, and fields.
        /// </summary>
        /// <param name="optionObject">The option object to validate.</param>
        /// <returns>The response validation result.</returns>
        public static ResponseValidationResult ValidateResponsePayload(this IOptionObject? optionObject)
        {
            var errors = new List<string>();
            var baseResult = optionObject.ValidateResponse();
            errors.AddRange(baseResult.Errors);

            if (optionObject == null)
            {
                return new ResponseValidationResult(errors);
            }

            if (optionObject.Forms == null)
            {
                errors.Add("Forms collection must not be null.");
                return new ResponseValidationResult(errors);
            }

            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                var form = optionObject.Forms[i];
                if (form == null)
                {
                    errors.Add($"Forms[{i}] is null.");
                    continue;
                }

                var formResult = form.ValidateResponse();
                foreach (var error in formResult.Errors)
                {
                    errors.Add($"Forms[{i}]: {error}");
                }
            }

            return new ResponseValidationResult(errors);
        }

        /// <summary>
        /// Determines whether a response OptionObject payload is valid.
        /// </summary>
        /// <param name="optionObject">The option object to validate.</param>
        /// <returns>True if valid, false otherwise.</returns>
        public static bool IsValidResponsePayload(this IOptionObject? optionObject)
        {
            return optionObject.ValidateResponsePayload().IsValid;
        }

        private static void ValidateErrorCode(double errorCode, List<string> errors)
        {
            if (double.IsNaN(errorCode) || double.IsInfinity(errorCode))
            {
                errors.Add(ResponseValidationMessages.ErrorCodeMustBeFiniteBetween0And6);
                return;
            }

            if (errorCode < 0 || errorCode > 6)
            {
                errors.Add(ResponseValidationMessages.ErrorCodeMustBeBetween0And6);
                return;
            }

            double rounded = Math.Round(errorCode, 0, MidpointRounding.AwayFromZero);
            if (Math.Abs(errorCode - rounded) > 1e-9)
            {
                errors.Add(ResponseValidationMessages.ErrorCodeMustBeIntegerBetween0And6);
            }
        }

        private static void ValidateErrorMessage(double errorCode, string errorMessage, List<string> errors)
        {
            int normalizedCode = NormalizeErrorCode(errorCode);
            if (normalizedCode == -1)
            {
                return;
            }

            if (normalizedCode == 0 && !string.IsNullOrEmpty(errorMessage))
            {
                errors.Add(ResponseValidationMessages.ErrorMesgMustBeEmptyWhenErrorCodeIs0);
                return;
            }

            if (normalizedCode >= 1 && normalizedCode <= 4 && string.IsNullOrWhiteSpace(errorMessage))
            {
                errors.Add(ResponseValidationMessages.ErrorMesgIsRequiredWhenErrorCodeIsBetween1And4);
                return;
            }

            if (normalizedCode == 5 && !IsValidUrl(errorMessage))
            {
                errors.Add(ResponseValidationMessages.ErrorMesgMustBeValidAbsoluteUrlWhenErrorCodeIs5);
                return;
            }

            if (normalizedCode == 6 && !IsValidOpenFormString(errorMessage))
            {
                errors.Add(ResponseValidationMessages.ErrorMesgMustBeValidOpenFormStringWhenErrorCodeIs6);
            }
        }

        private static int NormalizeErrorCode(double errorCode)
        {
            if (double.IsNaN(errorCode) || double.IsInfinity(errorCode))
            {
                return -1;
            }

            int code = (int)Math.Round(errorCode, 0, MidpointRounding.AwayFromZero);
            if (code < 0 || code > 6)
            {
                return -1;
            }

            return code;
        }

        private static bool IsValidUrl(string value)
        {
            return !string.IsNullOrWhiteSpace(value) && Uri.IsWellFormedUriString(value, UriKind.Absolute);
        }

        private static bool IsValidOpenFormString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            return Regex.IsMatch(value, RegexPatterns.FullPattern, RegexOptions.None, TimeSpan.FromMilliseconds(100));
        }

        private static class RegexPatterns
        {
            private const string ModulePrefix = @"(\[(PM|CWS|MSO)\])?";
            private const string ModuleForm = @"[A-Z]+[0-9]+";
            private const string RadplusForm = @"RADplus_[A-Za-z]+[0-9]+";
            private const string Form = @"(?:" + ModuleForm + "|" + RadplusForm + ")";
            private const string PrefixedForm = @"(\s*)" + ModulePrefix + Form;
            private const string FormList = PrefixedForm + @"((\s*)&(\s*)" + ModulePrefix + Form + ")*";
            private const string Message = @"((\s*)\|(\s*)([^\|\t\n\r])*)?";
            private const string PatientId = @"((\s*)\|(\s*)\d+)?";
            private const string EpisodeNumber = @"((\s*)\|(\s*)([1-9][0-9]*)+|(\s*)\|(\s*))?";
            public const string FullPattern = "^" + FormList + Message + PatientId + EpisodeNumber + "$";
        }
    }
}
