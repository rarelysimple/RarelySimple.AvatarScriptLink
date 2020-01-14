using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as enabled and not required.
        /// <para>This is the equivalent of <see cref="SetOptionalFields(IOptionObject, List{FieldObject})"/>.</para>
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject SetEnabledFields(IOptionObject optionObject, List<FieldObject> fieldObjects) => SetOptionalFields(optionObject, fieldObjects);
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as enabled and not require by FieldNumbers.
        /// <para>This is the equivalent of <see cref="SetOptionalFields(IFormObject, List{string})"/>.</para>
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject SetEnabledFields(IOptionObject optionObject, List<string> fieldNumbers) => SetOptionalFields(optionObject, fieldNumbers);
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as enabled and not required by FieldNumbers.
        /// <para>This is the equivalent of <see cref="SetOptionalFields(IFormObject, List{string})"/>.</para>
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IFormObject SetEnabledFields(IFormObject formObject, List<string> fieldNumbers) => SetOptionalFields(formObject, fieldNumbers);
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as enabled and not required by FieldNumbers.
        /// <para>This is the equivalent of <see cref="SetOptionalFields(IRowObject, List{string})"/>.</para>
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IRowObject SetEnabledFields(IRowObject rowObject, List<string> fieldNumbers) => SetOptionalFields(rowObject, fieldNumbers);
    }
}
