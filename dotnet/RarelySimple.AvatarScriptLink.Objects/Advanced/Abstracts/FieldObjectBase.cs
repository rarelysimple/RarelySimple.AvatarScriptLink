using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts
{
    public class FieldObjectBase : ObjectBase, IFieldObject
    {
        /// <summary>
        /// Gets or sets the Enabled property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. 0 = Disabled. 1 = Enabled.</value>
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
        /// <value>The value is a <see cref="string"/>. 0 = Unlocked. 1 = Locked.</value>
        public string Lock { get; set; }
        /// <summary>
        /// Gets or sets the Required property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. 0 = Not required. 1 = Required.</value>
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
    }
}
