using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IOptionObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject SetFieldObject(IOptionObject optionObject, string fieldAction, string fieldNumber)
        {
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(optionObject, fieldAction, fieldNumbers);
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IFormObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IFormObject SetFieldObject(IFormObject formObject, string fieldAction, string fieldNumber)
        {
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(formObject, fieldAction, fieldNumbers);
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IRowObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IRowObject SetFieldObject(IRowObject rowObject, string fieldAction, string fieldNumber)
        {
            List<string> fieldNumbers = new List<string> { fieldNumber };
            return SetFieldObjects(rowObject, fieldAction, fieldNumbers);
        }
    }
}
