using System;
using System.Text.RegularExpressions;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers
{
    /// <summary>
    /// Provides validation helpers for ScriptLink-specific formats and values.
    /// </summary>
    public static class ScriptLinkValidation
    {
        /// <summary>
        /// Returns whether a string is a valid URL for use with error code 5.
        /// </summary>
        /// <param name="strUrl">The string to validate as a URL.</param>
        /// <returns>True if the string is a valid absolute URL; otherwise, false.</returns>
        /// <remarks>
        /// <para>Behavior:</para>
        /// <list type="bullet">
        /// <item><description>Null or empty strings return false.</description></item>
        /// <item><description>Relative URLs (e.g., "everydaymatters.com") return false.</description></item>
        /// <item><description>Only absolute URLs (with scheme like http:// or https://) return true.</description></item>
        /// <item><description>Query strings and fragments are allowed.</description></item>
        /// </list>
        /// </remarks>
        public static bool IsValidUrl(string? strUrl)
        {
            return !string.IsNullOrWhiteSpace(strUrl) && Uri.IsWellFormedUriString(strUrl, UriKind.Absolute);
        }

        /// <summary>
        /// Returns whether a Uri is a valid URL for use with error code 5.
        /// </summary>
        /// <param name="uri">The Uri to validate.</param>
        /// <returns>True if the Uri is an absolute URI; otherwise, false.</returns>
        /// <remarks>
        /// <para>Behavior:</para>
        /// <list type="bullet">
        /// <item><description>Null Uri returns false.</description></item>
        /// <item><description>Relative URIs return false.</description></item>
        /// <item><description>Only absolute URIs return true.</description></item>
        /// </list>
        /// </remarks>
        public static bool IsValidUrl(Uri? uri)
        {
            if (uri == null)
                return false;
            return uri.IsAbsoluteUri;
        }

        /// <summary>
        /// Returns whether a string is a valid OpenForm string for use with error code 6.
        /// </summary>
        /// <param name="value">The string to validate as an OpenForm string.</param>
        /// <returns>True if the string matches the OpenForm format; otherwise, false.</returns>
        /// <remarks>
        /// <para>OpenForm strings follow the pattern: [MODULE]FORM[|message][|patientId][|episodeNumber]</para>
        /// <para>Valid examples:</para>
        /// <list type="bullet">
        /// <item><description>PR0001</description></item>
        /// <item><description>[PM]PR0001</description></item>
        /// <item><description>[CWS]RADplus_Imaging001</description></item>
        /// <item><description>PR0001|Error occurred|12345</description></item>
        /// <item><description>PR0001|Error occurred|12345|1</description></item>
        /// </list>
        /// <para>Behavior:</para>
        /// <list type="bullet">
        /// <item><description>Null or whitespace strings return false.</description></item>
        /// <item><description>Strings with invalid characters or format return false.</description></item>
        /// </list>
        /// </remarks>
        public static bool IsValidOpenFormString(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            try
            {
                return Regex.IsMatch(value, RegexPatterns.FullPattern, RegexOptions.None, TimeSpan.FromMilliseconds(100));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
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
