using System;
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
            Regex regex = new Regex(@"^((\s*)(\[(PM|CWS|MSO)\])?[A-Z]+[0-9]+)((\s*)&(\s*)(\[(PM|CWS|MSO)\])?[A-Z]+[0-9]+)*((\s*)\|(\s*)([^\|\t\n\r])*)?((\s*)\|(\s*)\d+)?((\s*)\|(\s*)([1-9][0-9]*)+|(\s*)\|(\s*))?$", RegexOptions.None, TimeSpan.FromMilliseconds(100));
            return regex.IsMatch(openFormString);
        }
    }
}
