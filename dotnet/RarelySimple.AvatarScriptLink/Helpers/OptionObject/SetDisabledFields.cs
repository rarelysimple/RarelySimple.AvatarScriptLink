using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as disabled.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject SetDisabledFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            return SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as disabled by FieldNumbers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject SetDisabledFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as disabled by FieldNumbers.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IFormObject SetDisabledFields(IFormObject formObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(formObject, FieldAction.Disable, fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as disabled by FieldNumbers.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IRowObject SetDisabledFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(rowObject, FieldAction.Disable, fieldNumbers);
        }
    }
}
