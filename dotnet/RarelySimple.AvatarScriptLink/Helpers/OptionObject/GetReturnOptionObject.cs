using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Used to create the <see cref="IOptionObject"/> for return to myAvatar.
        /// </summary>
        /// <returns></returns>
        public static IOptionObject GetReturnOptionObject(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            IOptionObject returnOptionObject = ((OptionObjectBase)optionObject).Clone();
            RemoveUneditedRows(returnOptionObject);
            return returnOptionObject;
        }
        /// <summary>
        /// Used to create the <see cref="IOptionObject"/> for return to myAvatar using provide Error Code and Error Message.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IOptionObject GetReturnOptionObject(IOptionObject optionObject, double errorCode, string errorMessage)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            IOptionObject returnOptionObject = ((OptionObjectBase)optionObject).Clone();
            returnOptionObject = RemoveUneditedRows(returnOptionObject);
            returnOptionObject = SetErrorCodeAndMessage(returnOptionObject, errorCode, errorMessage);
            return returnOptionObject;
        }
        /// <summary>
        /// Used to create the <see cref="IOptionObject2"/> for return to myAvatar.
        /// </summary>
        /// <returns></returns>
        public static IOptionObject2 GetReturnOptionObject(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            IOptionObject2 returnOptionObject = ((OptionObjectBase)optionObject).Clone();
            RemoveUneditedRows(returnOptionObject);
            return returnOptionObject;
        }
        /// <summary>
        /// Used to create the <see cref="IOptionObject2"/> for return to myAvatar using provide Error Code and Error Message.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IOptionObject2 GetReturnOptionObject(IOptionObject2 optionObject, double errorCode, string errorMessage)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            IOptionObject2 returnOptionObject = ((OptionObjectBase)optionObject).Clone();
            RemoveUneditedRows(returnOptionObject);
            SetErrorCodeAndMessage(returnOptionObject, errorCode, errorMessage);
            return returnOptionObject;
        }

        /// <summary>
        /// Used to create the <see cref="IOptionObject2015"/> for return to myAvatar.
        /// </summary>
        /// <returns></returns>
        public static IOptionObject2015 GetReturnOptionObject(IOptionObject2015 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            IOptionObject2015 returnOptionObject = ((OptionObjectBase)optionObject).Clone();
            RemoveUneditedRows(returnOptionObject);
            return returnOptionObject;
        }
        /// <summary>
        /// Used to create the <see cref="IOptionObject2015"/> for return to myAvatar using provided Error Code and Error Message.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IOptionObject2015 GetReturnOptionObject(IOptionObject2015 optionObject, double errorCode, string errorMessage)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            IOptionObject2015 returnOptionObject = ((OptionObjectBase)optionObject).Clone();
            RemoveUneditedRows(returnOptionObject);
            SetErrorCodeAndMessage(returnOptionObject, errorCode, errorMessage);
            return returnOptionObject;
        }
    }
}
