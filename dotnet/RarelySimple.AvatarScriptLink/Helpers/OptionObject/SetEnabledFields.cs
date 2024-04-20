using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as enabled.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject SetEnabledFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            return SetFieldObjects(optionObject, FieldAction.Enable, fieldObjects);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as enabled by FieldNumbers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject SetEnabledFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(optionObject, FieldAction.Enable, fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as enabled by FieldNumbers.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IFormObject SetEnabledFields(IFormObject formObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(formObject, FieldAction.Enable, fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as enabled by FieldNumbers.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IRowObject SetEnabledFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(rowObject, FieldAction.Enable, fieldNumbers);
        }
    }
}
