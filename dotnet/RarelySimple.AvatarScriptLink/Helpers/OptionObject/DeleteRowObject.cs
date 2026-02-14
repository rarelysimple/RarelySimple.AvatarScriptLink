using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {

        /// <summary>
        /// Flags a <see cref="IRowObject"/> for deletion in specified <see cref="IOptionObject"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IOptionObject DeleteRowObject(IOptionObject optionObject, IRowObject rowObject)
        {
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return DeleteRowObject(optionObject, rowObject.RowId);
        }
        /// <summary>
        /// Flags a <see cref="RowObject"/> for deletion in specified <see cref="IOptionObject"/> by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static IOptionObject DeleteRowObject(IOptionObject optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (optionObject.Forms == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            int formIndex = optionObject.Forms.FindIndex(f => IsRowPresent(f, rowId));
            if (formIndex >= 0)
            {
                optionObject.Forms[formIndex] = (FormObject)DeleteRowObject(optionObject.Forms[formIndex], rowId);
                return optionObject;
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noRowObjectsFoundByRowId", CultureInfo.CurrentCulture), nameof(rowId));
        }
        /// <summary>
        /// Flags a <see cref="IRowObject"/> for deletion in specified <see cref="IFormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IFormObject DeleteRowObject(IFormObject formObject, IRowObject rowObject)
        {
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return DeleteRowObject(formObject, rowObject.RowId);
        }
        /// <summary>
        /// Flags a <see cref="RowObject"/> for deletion in specified <see cref="IFormObject"/> by RowId.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static IFormObject DeleteRowObject(IFormObject formObject, string rowId)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (formObject.CurrentRow?.RowId == rowId)
            {
                formObject.CurrentRow.RowAction = RowAction.Delete;
                return formObject;
            }
            if (formObject.MultipleIteration)
            {
                int rowIndex = formObject.OtherRows.FindIndex(r => r.RowId == rowId);
                if (rowIndex >= 0)
                {
                    formObject.OtherRows[rowIndex].RowAction = RowAction.Delete;
                    return formObject;
                }
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noRowObjectsFoundByRowId", CultureInfo.CurrentCulture), nameof(rowId));
        }
    }
}
