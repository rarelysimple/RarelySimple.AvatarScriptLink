using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {

        /// <summary>
        /// Gets the CurrentRow.RowId of the <see cref="IFormObject"/> in the <see cref="IOptionObject"/> by FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static string GetCurrentRowId(IOptionObject optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(formId))
                throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (optionObject.Forms == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
            foreach (var formObject in optionObject.Forms)
            {
                if (formObject.FormId == formId)
                {
                    return GetCurrentRowId(formObject);
                }
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFormObjectsFoundByFormId", CultureInfo.CurrentCulture), nameof(optionObject));
        }
        /// <summary>
        /// Gets the CurrentRow.RowId of the <see cref="IFormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static string GetCurrentRowId(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (formObject.CurrentRow == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
            return formObject.CurrentRow.RowId;
        }
    }
}
