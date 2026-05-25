using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as required by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <exception cref="ArgumentNullException">Thrown when delegated field action arguments are null.</exception>
        /// <exception cref="ArgumentException">Thrown when delegated field action validation fails or no matching fields are updated.</exception>
        /// <returns></returns>
        public static IOptionObject SetRequiredField(IOptionObject optionObject, string fieldNumber)
        {
            return SetFieldObject(optionObject, FieldAction.Require, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as required by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <exception cref="ArgumentNullException">Thrown when delegated field action arguments are null.</exception>
        /// <exception cref="ArgumentException">Thrown when delegated field action validation fails or no matching fields are found.</exception>
        /// <returns></returns>
        public static IFormObject SetRequiredField(IFormObject formObject, string fieldNumber)
        {
            return SetFieldObject(formObject, FieldAction.Require, fieldNumber);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as required by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <exception cref="ArgumentNullException">Thrown when delegated field action arguments are null.</exception>
        /// <exception cref="ArgumentException">Thrown when delegated field action validation fails or no matching fields are found.</exception>
        /// <returns></returns>
        public static IRowObject SetRequiredField(IRowObject rowObject, string fieldNumber)
        {
            return SetFieldObject(rowObject, FieldAction.Require, fieldNumber);
        }
    }
}
