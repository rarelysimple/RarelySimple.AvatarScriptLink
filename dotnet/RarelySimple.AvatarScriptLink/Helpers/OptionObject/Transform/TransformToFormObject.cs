using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Transforms an Xml- or Json-formatted <see cref="String"/> to <see cref="FormObject"/>.
        /// </summary>
        /// <param name="serializedString">An Xml- or Json-formatted <see cref="System.String"/>.</param>
        /// <returns>A <see cref="FormObject"/>.</returns>
        public static IFormObject TransformToFormObject(string serializedString)
        {
            if (string.IsNullOrEmpty(serializedString))
                throw new ArgumentNullException(nameof(serializedString), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            try
            {
                return ScriptLinkHelpers.DeserializeObject<FormObject>(serializedString);
            }
            catch
            {
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("serializedStringIncompatibleFormat", CultureInfo.CurrentCulture), nameof(serializedString));
            }
        }
    }
}
