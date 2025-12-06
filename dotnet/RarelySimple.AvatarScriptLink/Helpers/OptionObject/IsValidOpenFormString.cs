using System.Text.RegularExpressions;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns whether a given string is a valid OpenForm string.
        /// </summary>
        /// <param name="openFormString"></param>
        /// <returns></returns>
        public static bool IsValidOpenFormString(string openFormString)
        {
            if (string.IsNullOrEmpty(openFormString))
                return false;
            return Regex.IsMatch(openFormString, RegexPatterns.FullPattern);
        }

        /// <summary>
        /// Provides modular regular expression components for validating custom identifier strings.
        /// 
        /// The class breaks down the full validation pattern into reusable parts:
        /// - <c>ModulePrefix</c>: Optional tag such as [PM], [CWS], or [MSO].
        /// - <c>ModuleForm</c>: Uppercase letters followed by digits (e.g., ABC123).
        /// - <c>RadplusForm</c>: "RADplus_" followed by a word and digits (e.g., RADplus_Client100).
        /// - <c>Form</c>: Either a legacy token or a RADplus token.
        /// - <c>PrefixedForm</c>: A token with optional prefix and whitespace.
        /// - <c>FormList</c>: One or more tokens joined by "&".
        /// - <c>Message</c>: Optional message for user introduced by "|".
        /// - <c>PatientId</c>: Optional patient id for launch context introduced by "|".
        /// - <c>EpisodeNumber</c>: Optional episode number for launch context introduced by "|", allowing numbers or an empty pipe.
        /// - <c>FullPattern</c>: The complete regex that composes all parts into a strict validation rule.
        /// </summary>
        public static class RegexPatterns
{
            // Optional module prefix like [PM], [CWS], [MSO]
            private const string ModulePrefix = @"(\[(PM|CWS|MSO)\])?";

            // Module form: uppercase letters followed by digits
            private const string ModuleForm = @"[A-Z]+[0-9]+";

            // RADplus form: RADplus_ followed by word + digits
            private const string RadplusForm = @"RADplus_[A-Za-z]+[0-9]+";

            // General form: either Module-specific or RADplus
            private const string Form = @"(?:" + ModuleForm + "|" + RadplusForm + ")";

            // Full form id with optional prefix
            private const string PrefixedForm = @"(\s*)" + ModulePrefix + Form;

            // Form list joined by &
            private const string FormList = PrefixedForm + @"((\s*)&(\s*)" + ModulePrefix + Form + ")*";

            // Optional suffix parts separated by |
            private const string Message   = @"((\s*)\|(\s*)([^\|\t\n\r])*)?";
            private const string PatientId = @"((\s*)\|(\s*)\d+)?";
            private const string EpisodeNumber  = @"((\s*)\|(\s*)([1-9][0-9]*)+|(\s*)\|(\s*))?";

            /// <summary>
            /// Full validation regex pattern for custom identifiers with optional suffixes.
            /// 
            /// Structure:
            /// 1. Leading form list:
            ///    - Each form ID may be optionally prefixed with [PM], [CWS], or [MSO].
            ///    - Form formats allowed:
            ///        • Module-specific: Uppercase letters followed by digits (e.g., ABC123).
            ///        • RADplus: "RADplus_" followed by a word and digits (e.g., RADplus_Client100).
            ///    - Multiple forms may be joined with "&".
            ///
            /// 2. Optional suffix sections (pipe-delimited):
            ///    - Message: "| some text"
            ///    - PATID: "| 42"
            ///    - EPISODE: "| 100" or an empty pipe ("|")
            ///
            /// Examples of valid matches:
            ///    • [PM]ABC123
            ///    • XYZ456 & RADplus_Client100 | notes | 5 | 100
            ///    • RADplus_Client100
            ///    • ABC123 | description | 42
            ///
            /// This pattern enforces strict formatting rules for identifiers while
            /// allowing both module-specific and RADplus-prefixed forms.
            /// </summary>
            public const string FullPattern = "^" + FormList + Message + PatientId + EpisodeNumber + "$";
        }
    }
}
