using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Adds a <see cref="IFormObject"/> to an <see cref="IOptionObject2015"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static IOptionObject AddFormObject(IOptionObject optionObject, IFormObject formObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (optionObject.Forms.Count == 0 && formObject.MultipleIteration)
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("firstFormCannotBeMultipleIteration", CultureInfo.CurrentCulture));
            if (optionObject.Forms.Contains((FormObject)formObject) || optionObject.Forms.Exists(f => f.FormId == formObject.FormId))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("formIdAlreadyExists", CultureInfo.CurrentCulture));
            optionObject.Forms.Add((FormObject)formObject);
            return optionObject;
        }
        /// <summary>
        /// Creates a <see cref="IFormObject"/> with specified FormId and adds to an <see cref="IOptionObject2015"/> using provided FormId and indicating whether it is a multiple iteration table.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="multipleIteration"></param>
        /// <returns></returns>
        public static IOptionObject AddFormObject(IOptionObject optionObject, string formId, bool multipleIteration)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            FormObject formObject = new FormObject
            {
                FormId = formId,
                MultipleIteration = multipleIteration
            };
            return AddFormObject(optionObject, formObject);
        }
    }
}
