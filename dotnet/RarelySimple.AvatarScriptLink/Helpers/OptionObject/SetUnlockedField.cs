using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    { 
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as unlocked by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject SetUnlockedField(IOptionObject optionObject, string fieldNumber)
        {
            return SetFieldObject(optionObject, FieldAction.Unlock, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as unlocked by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IFormObject SetUnlockedField(IFormObject formObject, string fieldNumber)
        {
            return SetFieldObject(formObject, FieldAction.Unlock, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as unlocked by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IRowObject SetUnlockedField(IRowObject rowObject, string fieldNumber)
        {
            return SetFieldObject(rowObject, FieldAction.Unlock, fieldNumber);
        }
    }
}
