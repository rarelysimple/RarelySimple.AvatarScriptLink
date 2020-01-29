namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Safely converts a string to an integer.
        /// </summary>
        /// <param name="intString"></param>
        /// <returns>Returns the converted string as an int. Otherwise, returns 0 if string is not a valid integer.</returns>
        public static int SafeGetInt(string intString)
        {
            if (int.TryParse(intString, out int convertedInt))
                return convertedInt;
            return 0;
        }
    }
}
