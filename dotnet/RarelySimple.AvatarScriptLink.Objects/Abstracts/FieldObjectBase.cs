using RarelySimple.AvatarScriptLink.Objects.Interfaces;
using RarelySimple.AvatarScriptLink.Objects.Utilities;

namespace RarelySimple.AvatarScriptLink.Objects.Abstracts
{
    public class FieldObjectBase : ObjectBase, IFieldObject
    {
        /// <summary>
        /// Gets or sets the Enabled property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <remarks>
        /// <para>This property stores the enabled status as a string due to myAvatar SOAP serialization requirements.</para>
        /// <para>For a more convenient boolean interface, use the <see cref="IsEnabled()"/> method or <see cref="SetEnabled(bool)"/> method.</para>
        /// </remarks>
        /// <value>The value is a <see cref="string"/>: "1" (Enabled) or "0" (Disabled).</value>
        public string Enabled { get; set; }
        /// <summary>
        /// Gets or sets the FieldNumber property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the field number. This is typically a value like 12345.6 or 12345.67.</value>
        public string FieldNumber { get; set; }
        /// <summary>
        /// Gets or sets the FieldValue property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> containing the value entered (or to be entered) in the field.</value>
        public string FieldValue { get; set; }
        /// <summary>
        /// Gets or sets the Lock property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <remarks>
        /// <para>This property stores the lock status as a string due to myAvatar SOAP serialization requirements.</para>
        /// <para>For a more convenient boolean interface, use the <see cref="IsLocked()"/> method or <see cref="SetLocked(bool)"/> method.</para>
        /// </remarks>
        /// <value>The value is a <see cref="string"/>: "1" (Locked) or "0" (Unlocked).</value>
        public string Lock { get; set; }
        /// <summary>
        /// Gets or sets the Required property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <remarks>
        /// <para>This property stores the required status as a string due to myAvatar SOAP serialization requirements.</para>
        /// <para>For a more convenient boolean interface, use the <see cref="IsRequired()"/> method or <see cref="SetRequired(bool)"/> method.</para>
        /// </remarks>
        /// <value>The value is a <see cref="string"/>: "1" (Required) or "0" (Optional).</value>
        public string Required { get; set; }

        #region Constructors

        /// <summary>
        /// Creates an empty <see cref="FieldObject"/>.
        /// </summary>
        protected FieldObjectBase()
        {
            Enabled = string.Empty;
            FieldNumber = string.Empty;
            FieldValue = string.Empty;
            Lock = string.Empty;
            Required = string.Empty;
        }

        #endregion

        #region Boolean Helper Methods

        /// <summary>
        /// Gets a value indicating whether the field is enabled.
        /// </summary>
        /// <returns>True if the Enabled property is "1", false otherwise.</returns>
        /// <remarks>
        /// <para>This method converts the string-based Enabled property to a boolean value for easier use in code.</para>
        /// <para>Use this method instead of checking <c>Enabled == "1"</c> directly.</para>
        /// </remarks>
        public bool IsEnabled() => BooleanConversion.ToBoolean(Enabled);

        /// <summary>
        /// Gets a value indicating whether the field is locked.
        /// </summary>
        /// <returns>True if the Lock property is "1", false otherwise.</returns>
        /// <remarks>
        /// <para>This method converts the string-based Lock property to a boolean value for easier use in code.</para>
        /// <para>Use this method instead of checking <c>Lock == "1"</c> directly.</para>
        /// </remarks>
        public bool IsLocked() => BooleanConversion.ToBoolean(Lock);

        /// <summary>
        /// Gets a value indicating whether the field is required.
        /// </summary>
        /// <returns>True if the Required property is "1", false otherwise.</returns>
        /// <remarks>
        /// <para>This method converts the string-based Required property to a boolean value for easier use in code.</para>
        /// <para>Use this method instead of checking <c>Required == "1"</c> directly.</para>
        /// </remarks>
        public bool IsRequired() => BooleanConversion.ToBoolean(Required);

        /// <summary>
        /// Sets the Enabled property based on the provided boolean value.
        /// </summary>
        /// <param name="value">True sets Enabled to "1", false sets it to "0".</param>
        /// <remarks>
        /// <para>This method provides a convenient way to set the Enabled property using a boolean value.</para>
        /// <para>Use this method instead of setting <c>Enabled = value ? "1" : "0"</c> directly.</para>
        /// </remarks>
        public void SetEnabled(bool value) => Enabled = BooleanConversion.ToAvatarBoolean(value);

        /// <summary>
        /// Sets the Lock property based on the provided boolean value.
        /// </summary>
        /// <param name="value">True sets Lock to "1", false sets it to "0".</param>
        /// <remarks>
        /// <para>This method provides a convenient way to set the Lock property using a boolean value.</para>
        /// <para>Use this method instead of setting <c>Lock = value ? "1" : "0"</c> directly.</para>
        /// </remarks>
        public void SetLocked(bool value) => Lock = BooleanConversion.ToAvatarBoolean(value);

        /// <summary>
        /// Sets the Required property based on the provided boolean value.
        /// </summary>
        /// <param name="value">True sets Required to "1", false sets it to "0".</param>
        /// <remarks>
        /// <para>This method provides a convenient way to set the Required property using a boolean value.</para>
        /// <para>Use this method instead of setting <c>Required = value ? "1" : "0"</c> directly.</para>
        /// </remarks>
        public void SetRequired(bool value) => Required = BooleanConversion.ToAvatarBoolean(value);

        #endregion
    }
}
