using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as locked.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject SetLockedFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return SetFieldObjects(optionObject, FieldAction.Lock, fieldObjects);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as locked by FieldNumbers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject SetLockedFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(optionObject, FieldAction.Lock, fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as locked by FieldNumbers.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IFormObject SetLockedFields(IFormObject formObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(formObject, FieldAction.Lock, fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as locked by FieldNumbers.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IRowObject SetLockedFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(rowObject, FieldAction.Lock, fieldNumbers);
        }
    }
}
