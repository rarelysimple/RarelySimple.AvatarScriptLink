namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Safely converts a string to an integer.
        /// </summary>
        /// <param name="fieldValue"></param>
        /// <returns>Returns the converted string as an int. Otherwise, returns 0 if string is not a valid integer.</returns>
        public static int SafeGetInt(string fieldValue)
        {
            if (int.TryParse(fieldValue, out int fieldInt))
                return fieldInt;
            return 0;
        }
    }
}
