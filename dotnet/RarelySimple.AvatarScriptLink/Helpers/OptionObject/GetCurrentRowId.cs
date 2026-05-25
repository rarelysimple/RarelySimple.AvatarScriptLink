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
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="optionObject"/> is null, or when <paramref name="formId"/> is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown when a matching form cannot be found for <paramref name="formId"/>.</exception>
        /// <returns></returns>
        public static string GetCurrentRowId(IOptionObject optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(formId))
                throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
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
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="formObject"/> is null, or when it has no current row.</exception>
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
