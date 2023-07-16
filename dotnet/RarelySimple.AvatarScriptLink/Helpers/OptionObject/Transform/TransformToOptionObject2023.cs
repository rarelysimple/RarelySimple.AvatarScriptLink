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
        /// Transforms an <see cref="IOptionObject"/> to <see cref="IOptionObject2023"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static IOptionObject2023 TransformToOptionObject2023(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (!IsValidErrorCode(optionObject.ErrorCode))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("errorCodeIsNotValid", CultureInfo.CurrentCulture));
            var optionObject2023 = new OptionObject2023
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
                Forms = optionObject.Forms.Any() ? optionObject.Forms : new List<FormObject>()
            };
            return optionObject2023;
        }
        /// <summary>
        /// Transforms an <see cref="IOptionObject2"/> to <see cref="IOptionObject2023"/>.
        /// </summary>
        /// <param name="optionObject2"></param>
        /// <returns></returns>
        public static IOptionObject2023 TransformToOptionObject2023(IOptionObject2 optionObject2)
        {
            if (optionObject2 == null)
                throw new ArgumentNullException(nameof(optionObject2), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (!IsValidErrorCode(optionObject2.ErrorCode))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("errorCodeIsNotValid", CultureInfo.CurrentCulture));
            var optionObject2023 = new OptionObject2023
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
                Forms = optionObject2.Forms.Any() ? optionObject2.Forms : new List<FormObject>()
            };
            return optionObject2023;
        }
        /// <summary>
        /// Transforms an <see cref="IOptionObject2015"/> to <see cref="IOptionObject2023"/>.
        /// </summary>
        /// <param name="optionObject2015"></param>
        /// <returns></returns>
        public static IOptionObject2023 TransformToOptionObject2023(IOptionObject2015 optionObject2015)
        {
            if (optionObject2015 == null)
                throw new ArgumentNullException(nameof(optionObject2015), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (!IsValidErrorCode(optionObject2015.ErrorCode))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("errorCodeIsNotValid", CultureInfo.CurrentCulture));
            var optionObject2023 = new OptionObject2023
            {
                EntityID = optionObject2015.EntityID,
                EpisodeNumber = optionObject2015.EpisodeNumber,
                ErrorCode = optionObject2015.ErrorCode,
                ErrorMesg = optionObject2015.ErrorMesg,
                Facility = optionObject2015.Facility,
                NamespaceName = optionObject2015.NamespaceName,
                OptionId = optionObject2015.OptionId,
                OptionStaffId = optionObject2015.OptionStaffId,
                OptionUserId = optionObject2015.OptionUserId,
                ParentNamespace = optionObject2015.ParentNamespace,
                ServerName = optionObject2015.ServerName,
                SystemCode = optionObject2015.SystemCode,
                SessionToken = optionObject2015.SessionToken,
                Forms = optionObject2015.Forms.Any() ? optionObject2015.Forms : new List<FormObject>()
            };
            return optionObject2023;
        }
        /// <summary>
        /// Transforms a serialized string to <see cref="IOptionObject2023"/>.
        /// </summary>
        /// <param name="serializedString"></param>
        /// <returns></returns>
        public static IOptionObject2023 TransformToOptionObject2023(string serializedString)
        {
            if (string.IsNullOrEmpty(serializedString))
                throw new ArgumentNullException(nameof(serializedString), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            try
            {
                return ScriptLinkHelpers.DeserializeObject<OptionObject2023>(serializedString);
            }
            catch
            {
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("serializedStringIncompatibleFormat", CultureInfo.CurrentCulture), nameof(serializedString));
            }
        }
    }
}
