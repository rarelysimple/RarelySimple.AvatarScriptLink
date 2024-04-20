using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> is modified by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldModified(IOptionObject optionObject, string fieldNumber)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldPresent(form, fieldNumber))
                    return IsFieldModified(form, fieldNumber);
            }
            throw new ArgumentException("The OptionObject does not contain the FieldObject " + fieldNumber + ".");
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IFormObject"/> is modified by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldModified(IFormObject formObject, string fieldNumber)
        {
            if (formObject.CurrentRow == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return IsFieldModified(formObject.CurrentRow, fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IRowObject"/> is modified by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldModified(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject.Fields == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("rowObjectMissingFields", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return field.Modified;
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
        }
    }
}
