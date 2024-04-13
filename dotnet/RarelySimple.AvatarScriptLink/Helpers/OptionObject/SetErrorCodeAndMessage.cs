using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the ErrorCode and ErrorMesg values of an <see cref="IOptionObject"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IOptionObject SetErrorCodeAndMessage(IOptionObject optionObject, double errorCode = 0, string errorMessage = "")
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (!IsValidErrorCode(errorCode))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("errorCodeIsNotValid", CultureInfo.CurrentCulture));
            if ((int)errorCode == (int)ErrorCode.OpenUrl && !ScriptLinkHelpers.IsValidUrl(errorMessage))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("errorMessageIsNotValidUrl", CultureInfo.CurrentCulture));
            if ((int)errorCode == (int)ErrorCode.OpenForm && !IsValidOpenFormString(errorMessage))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("errorMessageIsNotValidOpenForm", CultureInfo.CurrentCulture));
            optionObject.ErrorCode = errorCode;
            optionObject.ErrorMesg = errorMessage;
            return optionObject;
        }
    }
}
