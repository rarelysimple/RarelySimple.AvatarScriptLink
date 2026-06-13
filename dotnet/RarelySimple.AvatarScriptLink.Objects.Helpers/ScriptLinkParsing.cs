using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers
{
    /// <summary>
    /// Provides safe parsing helpers for converting strings to common types with documented fallback behaviors.
    /// </summary>
    public static class ScriptLinkParsing
    {
        /// <summary>
        /// Safely converts a string to an integer.
        /// </summary>
        /// <param name="intString">The string to convert.</param>
        /// <returns>Returns the converted string as an int. Otherwise, returns 0 if string is not a valid integer.</returns>
        /// <remarks>
        /// <para>Behavior:</para>
        /// <list type="bullet">
        /// <item><description>Valid integers (including negative) are converted correctly.</description></item>
        /// <item><description>Decimal strings (e.g., "10.5") return 0.</description></item>
        /// <item><description>Alphabetic or special character strings return 0.</description></item>
        /// <item><description>Null or empty strings return 0.</description></item>
        /// </list>
        /// </remarks>
        public static int SafeGetInt(string? intString)
        {
            if (int.TryParse(intString, out int convertedInt))
                return convertedInt;
            return 0;
        }

        /// <summary>
        /// Safely converts a string to a boolean.
        /// </summary>
        /// <param name="boolString">The string to convert.</param>
        /// <returns>Returns true for "1", "T", "TRUE", "Y", "YES" (case-insensitive). Returns false for all other values.</returns>
        /// <remarks>
        /// <para>Behavior:</para>
        /// <list type="bullet">
        /// <item><description>"1", "T", "TRUE", "Y", "YES" (case-insensitive) convert to true.</description></item>
        /// <item><description>"0", "F", "FALSE", "N", "NO" (case-insensitive) convert to false.</description></item>
        /// <item><description>Any other string returns false.</description></item>
        /// <item><description>Null or empty strings return false.</description></item>
        /// </list>
        /// </remarks>
        public static bool SafeGetBool(string? boolString)
        {
            if (boolString != null)
            {
                switch (boolString.ToUpperInvariant())
                {
                    case "1":
                    case "T":
                    case "TRUE":
                    case "Y":
                    case "YES":
                        return true;
                    default:
                        return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Safely converts a string to a DateTime.
        /// </summary>
        /// <param name="dateTimeString">The string to convert.</param>
        /// <returns>Returns the converted string as a DateTime. Otherwise, returns new DateTime(0, DateTimeKind.Unspecified) if string is not a valid DateTime.</returns>
        /// <remarks>
        /// <para>Behavior:</para>
        /// <list type="bullet">
        /// <item><description>Supports common date formats: MM/DD/YYYY, MM-DD-YYYY, October 10, 2010, etc.</description></item>
        /// <item><description>Uses CurrentCulture for parsing.</description></item>
        /// <item><description>Invalid date strings return new DateTime(0) (January 1, 0001).</description></item>
        /// <item><description>Null or empty strings return new DateTime(0).</description></item>
        /// </list>
        /// </remarks>
        public static DateTime SafeGetDateTime(string? dateTimeString)
        {
            if (DateTime.TryParse(dateTimeString, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime convertedDateTime))
                return convertedDateTime;
            return new DateTime(0, DateTimeKind.Unspecified);
        }
    }
}
