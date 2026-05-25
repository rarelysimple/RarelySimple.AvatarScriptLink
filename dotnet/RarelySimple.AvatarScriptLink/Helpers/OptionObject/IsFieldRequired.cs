using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> is required by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumber"/> is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown when no matching field can be found for <paramref name="fieldNumber"/>.</exception>
        /// <returns></returns>
        public static bool IsFieldRequired(IOptionObject optionObject, string fieldNumber)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            var form = optionObject.Forms.Find(f => f.IsFieldPresent(fieldNumber));
            if (form != null)
            {
                return IsFieldRequired(form, fieldNumber);
            }
            throw new ArgumentException("The OptionObject does not contain the FieldObject " + fieldNumber + ".");
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IFormObject"/> is required by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="formObject"/> has no current row, or when <paramref name="fieldNumber"/> is null or empty.</exception>
        /// <returns></returns>
        public static bool IsFieldRequired(IFormObject formObject, string fieldNumber)
        {
            if (formObject.CurrentRow == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return IsFieldRequired(formObject.CurrentRow, fieldNumber);
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IRowObject"/> is required by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="rowObject"/> has no fields, or when <paramref name="fieldNumber"/> is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown when no matching field can be found for <paramref name="fieldNumber"/>.</exception>
        /// <returns></returns>
        public static bool IsFieldRequired(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject.Fields == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("rowObjectMissingFields", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return IsFieldRequired(field);
            }
            throw new System.ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
        }
        /// <summary>
        /// Returns whether the <see cref="IFieldObject"/> is required.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldObject"/> is null.</exception>
        /// <returns></returns>
        public static bool IsFieldRequired(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return fieldObject.Required == "1";
        }
    }
}
