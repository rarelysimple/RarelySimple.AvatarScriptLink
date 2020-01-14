using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        public static IOptionObject Clone(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));

            return TransformToOptionObject(TransformToJson(optionObject));
        }

        public static IOptionObject2 Clone(IOptionObject2 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));

            return TransformToOptionObject2(TransformToJson(optionObject));
        }

        public static IOptionObject2015 Clone(IOptionObject2015 optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));

            return TransformToOptionObject2015(TransformToJson(optionObject));
        }

        public static IFormObject Clone(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));

            return TransformToFormObject(TransformToJson(formObject));
        }

        public static IRowObject Clone(IRowObject rowObject)
        {
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));

            return TransformToRowObject(TransformToJson(rowObject));
        }

        public static IFieldObject Clone(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));

            return TransformToFieldObject(TransformToJson(fieldObject));
        }
    }
}
