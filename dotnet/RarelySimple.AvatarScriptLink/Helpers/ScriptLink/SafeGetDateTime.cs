﻿using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Safely converts a string to an DateTime.
        /// </summary>
        /// <param name="dateTimeString"></param>
        /// <returns>Returns the converted string as an int. Otherwise, returns 0 if string is not a valid integer.</returns>
        public static DateTime SafeGetDateTime(string dateTimeString)
        {
            if (DateTime.TryParse(dateTimeString, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime convertedDateTime))
                return convertedDateTime;
            return new DateTime(0, DateTimeKind.Unspecified);
        }
    }
}
