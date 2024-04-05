using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in the <see cref="IOptionObject"/> is enabled by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowPresent(IOptionObject optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (optionObject.Forms == null)
                throw new ArgumentNullException(ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            foreach (FormObject formObject in optionObject.Forms)
            {
                if (IsRowPresent(formObject, rowId))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in the <see cref="IFormObject"/> is enabled by RowId.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowPresent(IFormObject formObject, string rowId)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (formObject.CurrentRow == null)
                throw new ArgumentNullException(ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (formObject.CurrentRow.RowId == rowId)
                return true;
            if (formObject.MultipleIteration)
                return formObject.OtherRows.Exists(r => r.RowId == rowId);
            return false;
        }
    }
}
