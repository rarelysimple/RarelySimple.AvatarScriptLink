using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns the ParentRowId of a <see cref="IFormObject"/> in the <see cref="IOptionObject"/> by FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static string GetParentRowId(IOptionObject optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(formId))
                throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (optionObject.Forms == null)
                throw new NullReferenceException(ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
            foreach (var formObject in optionObject.Forms)
            {
                if (formObject.FormId == formId)
                {
                    return GetParentRowId(formObject);
                }
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFormObjectsFoundByFormId", CultureInfo.CurrentCulture), nameof(formId));
        }
        /// <summary>
        /// Returns the ParentRowId of a <see cref="IFormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static string GetParentRowId(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (formObject.CurrentRow == null)
                throw new NullReferenceException(ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
            return formObject.CurrentRow.ParentRowId;
        }
    }
}
