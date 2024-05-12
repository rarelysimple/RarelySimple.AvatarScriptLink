using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IOptionObject"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IOptionObject SetFieldValue(IOptionObject optionObject, string fieldNumber, string fieldValue)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            var formObject = optionObject.Forms.Find(f => f.IsFieldPresent(fieldNumber));
            if (formObject != null)
            {
                if (formObject.MultipleIteration && formObject.OtherRows.Count > 0)
                    throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("unableToIdentifyFieldObject", CultureInfo.CurrentCulture), nameof(optionObject));

                string formId = formObject.FormId;
                string rowId = formObject.GetCurrentRowId();
                return SetFieldValue(optionObject, formId, rowId, fieldNumber, fieldValue);
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IOptionObject"/> by FormId, RowID, and FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IOptionObject SetFieldValue(IOptionObject optionObject, string formId, string rowId, string fieldNumber, string fieldValue)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(formId))
                throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (optionObject.Forms == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                if (optionObject.Forms[i].FormId == formId)
                    optionObject.Forms[i] = (FormObject)SetFieldValue(optionObject.Forms[i], rowId, fieldNumber, fieldValue);
            }
            return optionObject;
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IFormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IFormObject SetFieldValue(IFormObject formObject, string fieldNumber, string fieldValue)
        {
            if (formObject.CurrentRow == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (formObject.MultipleIteration && formObject.OtherRows.Count > 0)
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("unableToIdentifyFieldObject", CultureInfo.CurrentCulture));
            return SetFieldValue(formObject, formObject.CurrentRow.RowId, fieldNumber, fieldValue);
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IFormObject"/> by RowId and FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IFormObject SetFieldValue(IFormObject formObject, string rowId, string fieldNumber, string fieldValue)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (formObject.CurrentRow == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (formObject.CurrentRow.RowId == rowId)
            {
                formObject.CurrentRow = (RowObject)SetFieldValue(formObject.CurrentRow, fieldNumber, fieldValue);
                return formObject;
            }
            if (formObject.MultipleIteration)
            {
                for (int i = 0; i < formObject.OtherRows.Count; i++)
                {
                    if (formObject.OtherRows[i].RowId == rowId)
                    {
                        formObject.OtherRows[i] = (RowObject)SetFieldValue(formObject.OtherRows[i], fieldNumber, fieldValue);
                        return formObject;
                    }
                }
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(formObject));
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IRowObject"/> by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IRowObject SetFieldValue(IRowObject rowObject, string fieldNumber, string fieldValue)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            for (int i = 0; i < rowObject.Fields.Count; i++)
            {
                if (rowObject.Fields[i].FieldNumber == fieldNumber)
                {
                    rowObject.Fields[i].FieldValue = fieldValue;
                    rowObject.RowAction = RowAction.Edit;
                    break;
                }
            }
            return rowObject;
        }
        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IFieldObject SetFieldValue(IFieldObject fieldObject, string fieldValue)
        {
            if (fieldObject == null)
                throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            fieldObject.FieldValue = fieldValue;
            return fieldObject;
        }
    }
}
