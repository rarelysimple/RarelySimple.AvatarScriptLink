using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        private const string NoFieldObjectsFoundByFieldNumber = "";

        /// <summary>
        /// Returns the FieldValue of a specified <see cref="IFieldObject"/> in an <see cref="IOptionObject"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IOptionObject optionObject, string fieldNumber)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            var form = optionObject.Forms.Find(f => f.IsFieldPresent(fieldNumber));
            if (form != null)
            {
                return GetFieldValue(form, fieldNumber);
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
        }
        /// <summary>
        /// Returns the FieldValue of a specified <see cref="IFieldObject"/> in an <see cref="IOptionObject2015"/> by FormId, RowId, and FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IOptionObject optionObject, string formId, string rowId, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(formId))
                throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            foreach (var form in optionObject.Forms)
            {
                if (form.FormId == formId)
                    return GetFieldValue(form, rowId, fieldNumber);
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
        }
        /// <summary>
        /// Returns the FieldValue of a <see cref="IFieldObject"/> in a <see cref="IFormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IFormObject formObject, string fieldNumber)
        {
            return GetFieldValue(formObject, formObject.CurrentRow?.RowId, fieldNumber);
        }
        /// <summary>
        /// Returns the FieldValue of a <see cref="IFieldObject"/> in a <see cref="IFormObject"/> by RowId and FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IFormObject formObject, string rowId, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (formObject.CurrentRow.RowId == rowId)
                return GetFieldValue(formObject.CurrentRow, fieldNumber);
            foreach (RowObject rowObject in formObject.OtherRows)
            {
                if (rowObject.RowId == rowId)
                    return GetFieldValue(rowObject, fieldNumber);
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
        }
        /// <summary>
        /// Returns the FieldValue of a <see cref="IFieldObject"/> in a <see cref="IRowObject"/> by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return GetFieldValue(field);
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
        }
        /// <summary>
        /// Returns the FieldValue of a <see cref="IFieldObject"/>.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <returns></returns>
        public static string GetFieldValue(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return fieldObject.FieldValue;
        }
    }
}
