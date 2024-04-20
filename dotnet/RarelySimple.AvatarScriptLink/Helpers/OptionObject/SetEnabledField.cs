using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as enabled by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject SetEnabledField(IOptionObject optionObject, string fieldNumber)
        {
            return SetFieldObject(optionObject, FieldAction.Enable, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as enabled by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IFormObject SetEnabledField(IFormObject formObject, string fieldNumber)
        {
            return SetFieldObject(formObject, FieldAction.Enable, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as enabled by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IRowObject SetEnabledField(IRowObject rowObject, string fieldNumber)
        {
            return SetFieldObject(rowObject, FieldAction.Enable, fieldNumber);
        }
    }
}
