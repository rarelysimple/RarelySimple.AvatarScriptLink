namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Safely converts a string to a bool.
        /// </summary>
        /// <param name="boolString"></param>
        /// <returns>Returns the converted string as an int. Otherwise, returns 0 if string is not a valid integer.</returns>
        public static bool SafeGetBool(string boolString)
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
    }
}
