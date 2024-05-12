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
            if (optionObject.Forms == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return optionObject.Forms.Find(x => x.IsRowPresent(rowId)) != null;
        }
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in the <see cref="IFormObject"/> is enabled by RowId.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowPresent(IFormObject formObject, string rowId)
        {
            if (formObject.CurrentRow == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (formObject.CurrentRow.RowId == rowId)
                return true;
            if (formObject.MultipleIteration)
                return formObject.OtherRows.Exists(r => r.RowId == rowId);
            return false;
        }
    }
}
