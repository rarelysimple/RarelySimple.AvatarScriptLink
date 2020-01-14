using System.Globalization;

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
            int tempValue = 0;
            if (int.TryParse(fieldValue, out _))
                tempValue = int.Parse(fieldValue, CultureInfo.InvariantCulture);
            return tempValue;
        }
    }
}
