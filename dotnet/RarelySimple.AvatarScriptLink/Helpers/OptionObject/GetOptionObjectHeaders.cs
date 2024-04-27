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
            List<string> headers = GetOptionObjectHeaders((IOptionObject)optionObject);
            headers.Add("Namespace Name: " + optionObject.NamespaceName);
            headers.Add("Parent Namespace: " + optionObject.ParentNamespace);
            headers.Add("Server Name: " + optionObject.ServerName);
            headers.Add("System Code: " + optionObject.SystemCode);
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
            List<string> headers = GetOptionObjectHeaders((IOptionObject2)optionObject);
            headers.Add("Session Token: " + optionObject.SessionToken);
            return headers;
        }
    }
}
