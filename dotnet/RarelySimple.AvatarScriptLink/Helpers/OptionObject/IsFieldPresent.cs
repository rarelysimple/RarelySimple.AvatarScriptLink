using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> is present by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldPresent(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new System.ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (optionObject.Forms == null)
                throw new System.NullReferenceException(ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new System.ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            foreach (var form in optionObject.Forms)
            {
                if (IsFieldPresent(form, fieldNumber))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IFormObject"/> is present by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldPresent(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (formObject.CurrentRow == null)
                return false;
            return IsFieldPresent(formObject.CurrentRow, fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IRowObject"/> is present by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static bool IsFieldPresent(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (rowObject.Fields == null)
                return false;
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return true;
            }
            return false;
        }
    }
}
