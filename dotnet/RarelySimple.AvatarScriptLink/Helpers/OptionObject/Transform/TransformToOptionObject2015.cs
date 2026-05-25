using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RarelySimple.AvatarScriptLink.Objects;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Transforms an <see cref="IOptionObject"/> to <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="optionObject"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the source object contains an invalid error code.</exception>
        /// <returns></returns>
        public static IOptionObject2015 TransformToOptionObject2015(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

            if (!IsValidErrorCode(optionObject.ErrorCode))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("errorCodeIsNotValid", CultureInfo.CurrentCulture));
            var optionObject2015 = new OptionObject2015
            {
                EntityID = optionObject.EntityID,
                EpisodeNumber = optionObject.EpisodeNumber,
                ErrorCode = optionObject.ErrorCode,
                ErrorMesg = optionObject.ErrorMesg,
                Facility = optionObject.Facility,
                OptionId = optionObject.OptionId,
                OptionStaffId = optionObject.OptionStaffId,
                OptionUserId = optionObject.OptionUserId,
                SystemCode = optionObject.SystemCode,
                Forms = optionObject.Forms.Count != 0 ? optionObject.Forms : new List<FormObject>()
            };
            return optionObject2015;
        }
        /// <summary>
        /// Transforms an <see cref="IOptionObject2"/> to <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject2"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="optionObject2"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the source object contains an invalid error code.</exception>
        /// <returns></returns>
        public static IOptionObject2015 TransformToOptionObject2015(IOptionObject2 optionObject2)
        {
            if (optionObject2 == null)
                throw new ArgumentNullException(nameof(optionObject2), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

            if (!IsValidErrorCode(optionObject2.ErrorCode))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("errorCodeIsNotValid", CultureInfo.CurrentCulture));
            var optionObject2015 = new OptionObject2015
            {
                EntityID = optionObject2.EntityID,
                EpisodeNumber = optionObject2.EpisodeNumber,
                ErrorCode = optionObject2.ErrorCode,
                ErrorMesg = optionObject2.ErrorMesg,
                Facility = optionObject2.Facility,
                NamespaceName = optionObject2.NamespaceName,
                OptionId = optionObject2.OptionId,
                OptionStaffId = optionObject2.OptionStaffId,
                OptionUserId = optionObject2.OptionUserId,
                ParentNamespace = optionObject2.ParentNamespace,
                ServerName = optionObject2.ServerName,
                SystemCode = optionObject2.SystemCode,
                Forms = optionObject2.Forms.Count != 0 ? optionObject2.Forms : new List<FormObject>()
            };
            return optionObject2015;
        }
        /// <summary>
        /// Transforms a serialized string to <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="serializedString"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="serializedString"/> is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="serializedString"/> is not a compatible serialized option object.</exception>
        /// <returns></returns>
        public static IOptionObject2015 TransformToOptionObject2015(string serializedString)
        {
            if (string.IsNullOrEmpty(serializedString))
                throw new ArgumentNullException(nameof(serializedString), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            try
            {
                return ScriptLinkHelpers.DeserializeObject<OptionObject2015>(serializedString);
            }
            catch
            {
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("serializedStringIncompatibleFormat", CultureInfo.CurrentCulture), nameof(serializedString));
            }
        }
    }
}
