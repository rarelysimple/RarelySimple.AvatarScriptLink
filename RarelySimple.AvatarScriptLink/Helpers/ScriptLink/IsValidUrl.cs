using System;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether a <see cref="Uri"/> is a valid URL for use with error code 5.
        /// </summary>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public static bool IsValidUrl(Uri uri)
        {
            if (uri == null)
                return false;
            return uri.IsAbsoluteUri;
        }
        /// <summary>
        /// Returns whether a string is a valid URL for use with error code 5.
        /// </summary>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public static bool IsValidUrl(string strUrl)
        {
            return Uri.IsWellFormedUriString(strUrl, UriKind.Absolute);
        }
    }
}
