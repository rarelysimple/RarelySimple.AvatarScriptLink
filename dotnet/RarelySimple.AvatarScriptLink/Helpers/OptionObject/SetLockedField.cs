using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as locked by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <exception cref="ArgumentNullException">Thrown when delegated field action arguments are null.</exception>
        /// <exception cref="ArgumentException">Thrown when delegated field action validation fails or no matching fields are updated.</exception>
        /// <returns></returns>
        public static IOptionObject SetLockedField(IOptionObject optionObject, string fieldNumber)
        {
            return SetFieldObject(optionObject, FieldAction.Lock, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as locked by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <exception cref="ArgumentNullException">Thrown when delegated field action arguments are null.</exception>
        /// <exception cref="ArgumentException">Thrown when delegated field action validation fails or no matching fields are found.</exception>
        /// <returns></returns>
        public static IFormObject SetLockedField(IFormObject formObject, string fieldNumber)
        {
            return SetFieldObject(formObject, FieldAction.Lock, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as locked by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <exception cref="ArgumentNullException">Thrown when delegated field action arguments are null.</exception>
        /// <exception cref="ArgumentException">Thrown when delegated field action validation fails or no matching fields are found.</exception>
        /// <returns></returns>
        public static IRowObject SetLockedField(IRowObject rowObject, string fieldNumber)
        {
            return SetFieldObject(rowObject, FieldAction.Lock, fieldNumber);
        }
    }
}
