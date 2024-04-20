using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> is locked by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldLocked(IOptionObject optionObject, string fieldNumber)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldPresent(form, fieldNumber))
                    return IsFieldLocked(form, fieldNumber);
            }
            throw new ArgumentException("The OptionObject does not contain the FieldObject " + fieldNumber + ".");
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IFormObject"/> is locked by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldLocked(IFormObject formObject, string fieldNumber)
        {
            if (formObject.CurrentRow == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return IsFieldLocked(formObject.CurrentRow, fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IRowObject"/> is locked by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldLocked(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject.Fields == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("rowObjectMissingFields", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return IsFieldLocked(field);
            }
            throw new System.ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> is locked.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <returns></returns>
        public static bool IsFieldLocked(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return fieldObject.Lock == "1";
        }
    }
}
