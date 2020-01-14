using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IOptionObject"/> as enabled and not required by FieldNumber.
        /// <para>This is the equivalent of <see cref="SetOptionalField(IOptionObject, string)"/>.</para>
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IOptionObject SetEnabledField(IOptionObject optionObject, string fieldNumber) => SetOptionalField(optionObject, fieldNumber);
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IFormObject"/> as enabled and not required by FieldNumber.
        /// <para>This is the equivalent of <see cref="SetOptionalField(IFormObject, string)"/>.</para>
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IFormObject SetEnabledField(IFormObject formObject, string fieldNumber) => SetOptionalField(formObject, fieldNumber);
        /// <summary>
        /// Sets the <see cref="IFieldObject"/> in a <see cref="IRowObject"/> as enabled and not required by FieldNumber.
        /// <para>This is the equivalent of <see cref="SetOptionalField(IRowObject, string)"/>.</para>
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static IRowObject SetEnabledField(IRowObject rowObject, string fieldNumber) => SetOptionalField(rowObject, fieldNumber);
    }
}
