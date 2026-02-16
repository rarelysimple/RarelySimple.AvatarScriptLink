namespace RarelySimple.AvatarScriptLink.Objects.Utilities
{
    /// <summary>
    /// Provides utilities for converting between boolean and string representations used in myAvatar.
    /// </summary>
    /// <remarks>
    /// myAvatar uses string values "0" and "1" to represent boolean states in field properties like Enabled, Locked, and Required.
    /// This utility class provides centralized conversion logic to maintain consistency across the library.
    /// </remarks>
    internal static class BooleanConversion
    {
        /// <summary>
        /// Converts a myAvatar string representation ("0" or "1") to a boolean value.
        /// </summary>
        /// <param name="value">The string value to convert. "1" is true, anything else is false.</param>
        /// <returns>True if value is "1", false otherwise.</returns>
        /// <remarks>
        /// <para>This method is used to convert myAvatar's string-based boolean representations to C# boolean values.</para>
        /// <para>Valid values: "1" (true), "0" (false), or empty string (false).</para>
        /// </remarks>
        public static bool ToBoolean(string value) => value == "1";

        /// <summary>
        /// Converts a boolean value to a myAvatar string representation ("0" or "1").
        /// </summary>
        /// <param name="value">The boolean value to convert.</param>
        /// <returns>"1" if value is true, "0" if false.</returns>
        /// <remarks>
        /// <para>This method is used to convert C# boolean values to myAvatar's string-based boolean representations.</para>
        /// <para>Returned values: "1" (true) or "0" (false).</para>
        /// </remarks>
        public static string ToAvatarBoolean(bool value) => value ? "1" : "0";
    }
}
