using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns a List of the <see cref="IOptionObject"/> properties and values.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static List<string> GetOptionObjectHeaders(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            List<string> headers = new List<string>
            {
                "Entity ID: " + optionObject.EntityID,
                "Episode Number: " + optionObject.EpisodeNumber,
                "Error Code: " + optionObject.ErrorCode,
                "Error Message: " + optionObject.ErrorMesg,
                "Facility: " + optionObject.Facility,
                "Option ID: " + optionObject.OptionId,
                "Option Staff ID: " + optionObject.OptionStaffId,
                "Option User ID: " + optionObject.OptionUserId,
                "System Code: " + optionObject.SystemCode
            };
            return headers;
        }
        /// <summary>
        /// Returns a List of the <see cref="IOptionObject2"/> properties and values.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static List<string> GetOptionObjectHeaders(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            List<string> headers = new List<string>
            {
                "Entity ID: " + optionObject.EntityID,
                "Episode Number: " + optionObject.EpisodeNumber,
                "Error Code: " + optionObject.ErrorCode,
                "Error Message: " + optionObject.ErrorMesg,
                "Facility: " + optionObject.Facility,
                "Namespace Name: " + optionObject.NamespaceName,
                "Option ID: " + optionObject.OptionId,
                "Option Staff ID: " + optionObject.OptionStaffId,
                "Option User ID: " + optionObject.OptionUserId,
                "Parent Namepace: " + optionObject.ParentNamespace,
                "Server Name: " + optionObject.ServerName,
                "System Code: " + optionObject.SystemCode
            };
            return headers;
        }
        /// <summary>
        /// Returns a List of the <see cref="IOptionObject2015"/> properties and values.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static List<string> GetOptionObjectHeaders(IOptionObject2015 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            List<string> headers = new List<string>
            {
                "Entity ID: " + optionObject.EntityID,
                "Episode Number: " + optionObject.EpisodeNumber,
                "Error Code: " + optionObject.ErrorCode,
                "Error Message: " + optionObject.ErrorMesg,
                "Facility: " + optionObject.Facility,
                "Namespace Name: " + optionObject.NamespaceName,
                "Option ID: " + optionObject.OptionId,
                "Option Staff ID: " + optionObject.OptionStaffId,
                "Option User ID: " + optionObject.OptionUserId,
                "Parent Namepace: " + optionObject.ParentNamespace,
                "Server Name: " + optionObject.ServerName,
                "System Code: " + optionObject.SystemCode,
                "SessionToken:" + optionObject.SessionToken
            };
            return headers;
        }
    }
}
