using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RarelySimple.AvatarScriptLink.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Transforms an <see cref="IOptionObject"/> to <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static IOptionObject2015 TransformToOptionObject2015(IOptionObject optionObject)
        {
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
        /// <returns></returns>
        public static IOptionObject2015 TransformToOptionObject2015(IOptionObject2 optionObject2)
        {
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
