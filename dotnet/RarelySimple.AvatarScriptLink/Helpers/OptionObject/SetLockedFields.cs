using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as locked.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldObjects"/> is null or contains one or more null or empty field numbers.</exception>
        /// <exception cref="ArgumentException">Thrown when no matching fields are found or no fields are updated.</exception>
        /// <returns></returns>
        public static IOptionObject SetLockedFields(IOptionObject optionObject, List<FieldObject> fieldObjects)
        {
            return SetFieldObjects(optionObject, FieldAction.Lock, fieldObjects);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as locked by FieldNumbers.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null or contains one or more null or empty field numbers.</exception>
        /// <exception cref="ArgumentException">Thrown when no matching fields are found or no fields are updated.</exception>
        /// <returns></returns>
        public static IOptionObject SetLockedFields(IOptionObject optionObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(optionObject, FieldAction.Lock, fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as locked by FieldNumbers.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null or contains one or more null or empty field numbers.</exception>
        /// <exception cref="ArgumentException">Thrown when no matching fields are found.</exception>
        /// <returns></returns>
        public static IFormObject SetLockedFields(IFormObject formObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(formObject, FieldAction.Lock, fieldNumbers);
        }
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as locked by FieldNumbers.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="fieldNumbers"/> is null or contains one or more null or empty field numbers.</exception>
        /// <exception cref="ArgumentException">Thrown when no matching fields are found.</exception>
        /// <returns></returns>
        public static IRowObject SetLockedFields(IRowObject rowObject, List<string> fieldNumbers)
        {
            return SetFieldObjects(rowObject, FieldAction.Lock, fieldNumbers);
        }
    }
}
