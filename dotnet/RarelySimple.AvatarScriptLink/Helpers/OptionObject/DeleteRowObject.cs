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
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            return DeleteRowObject(optionObject, rowObject.RowId);
        }
        /// <summary>
        /// Flags a <see cref="RowObject"/> for deletion in specified <see cref="IOptionObject2015"/> by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static IOptionObject DeleteRowObject(IOptionObject optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (optionObject.Forms == null || optionObject.Forms.Count == 0)
                throw new ArgumentNullException(ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                if (IsRowPresent(optionObject.Forms[i], rowId))
                {
                    optionObject.Forms[i] = (FormObject)DeleteRowObject(optionObject.Forms[i], rowId);
                    return optionObject;
                }
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
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
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
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (formObject.CurrentRow == null)
                throw new ArgumentNullException(ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
            if (formObject.CurrentRow.RowId == rowId)
            {
                formObject.CurrentRow.RowAction = RowAction.Delete;
                return formObject;
            }
            if (formObject.MultipleIteration)
            {
                foreach (RowObject rowObject in formObject.OtherRows)
                {
                    if (rowObject.RowId == rowId)
                    {
                        rowObject.RowAction = RowAction.Delete;
                        return formObject;
                    }
                }
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noRowObjectsFoundByRowId", CultureInfo.CurrentCulture), nameof(rowId));
        }
    }
}
