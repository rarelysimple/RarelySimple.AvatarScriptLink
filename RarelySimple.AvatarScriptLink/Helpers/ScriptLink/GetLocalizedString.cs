using RarelySimple.AvatarScriptLink.Properties;
using System.Globalization;
using System.Resources;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns a localized string based on provided key, using Current Culture.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetLocalizedString(string key)
        {
            return GetLocalizedString(key, CultureInfo.CurrentCulture);
        }
        /// <summary>
        /// Returns localized string based on provided key and culture string.
        /// <para>i.e., en-us, sp-mx, etc.</para>
        /// </summary>
        /// <param name="key"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string GetLocalizedString(string key, string culture)
        {
            CultureInfo cultureInfo = culture != null ? new CultureInfo(culture) : CultureInfo.CurrentCulture;
            return GetLocalizedString(key, cultureInfo);
        }
        /// <summary>
        /// Returns localized string based on provided key and Culture.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string GetLocalizedString(string key, CultureInfo culture)
        {
            ResourceManager resourceManager = Localizations.ResourceManager;
            if (resourceManager != null)
            {
                CultureInfo cultureInfo = culture ?? CultureInfo.CurrentCulture;
                return resourceManager.GetString(key, cultureInfo);
            }
            return key;
        }
    }
}
