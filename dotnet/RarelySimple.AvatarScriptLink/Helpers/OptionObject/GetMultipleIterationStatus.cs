using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns whether a <see cref="IFormObject"/> in the <see cref="IOptionObject"/> is Multiple Iteration by specified FormId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="optionObject"/> is null, or when <paramref name="formId"/> is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown when a matching form cannot be found for <paramref name="formId"/>.</exception>
        /// <returns></returns>
        public static bool GetMultipleIterationStatus(IOptionObject optionObject, string formId)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(formId))
                throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            foreach (var formObject in optionObject.Forms)
            {
                if (formObject.FormId == formId)
                {
                    return GetMultipleIterationStatus(formObject);
                }
            }
            throw new ArgumentException("The FormObject with FormId " + formId + " does not exist in this OptionObject.");
        }
        /// <summary>
        /// Returns whether a <see cref="IFormObject"/> is Multiple Iteration.
        /// </summary>
        /// <param name="formObject"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="formObject"/> is null.</exception>
        /// <returns></returns>
        public static bool GetMultipleIterationStatus(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return formObject.MultipleIteration;
        }
    }
}
