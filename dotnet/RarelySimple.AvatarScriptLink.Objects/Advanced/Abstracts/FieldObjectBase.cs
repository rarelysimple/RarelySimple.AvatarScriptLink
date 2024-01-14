using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;
using System;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts
{
    public class FieldObjectBase : ObjectBase, IEquatable<FieldObjectBase>, IFieldObject
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

        #region IEquatable Implementation

        /// <summary>
        /// Used to compare two <see cref="FieldObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="FieldObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether two <see cref="FieldObject"/> are equal.</returns>
        public bool Equals(FieldObjectBase other)
        {
            if (other == null)
                return false;
            return this.FieldValue == other.FieldValue &&
                this.Required == other.Required &&
                this.Enabled == other.Enabled &&
                this.FieldNumber == other.FieldNumber &&
                this.Lock == other.Lock;
        }
        /// <summary>
        /// Used to compare <see cref="FieldObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="FieldObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            FieldObjectBase fieldObject = obj as FieldObjectBase;
            if (fieldObject == null)
                return false;
            return this.Equals(fieldObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="FieldObjectBase"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="FieldObjectBase"/>.</returns>
        public override int GetHashCode()
        {
            string delimiter = "||";
            StringBuilder sb = new StringBuilder();
            sb.Append(this.FieldNumber
                + delimiter + this.FieldValue
                + delimiter + this.Enabled
                + delimiter + this.Lock
                + delimiter + this.Required);
            return sb.GetHashCode();
        }

        public static bool operator ==(FieldObjectBase fieldObject1, FieldObjectBase fieldObject2)
        {
            if (((object)fieldObject1) == null || ((object)fieldObject2) == null)
                return Equals(fieldObject1, fieldObject2);

            return fieldObject1.Equals(fieldObject2);
        }

        public static bool operator !=(FieldObjectBase fieldObject1, FieldObjectBase fieldObject2)
        {
            if (((object)fieldObject1) == null || ((object)fieldObject2) == null)
                return !Equals(fieldObject1, fieldObject2);

            return !(fieldObject1.Equals(fieldObject2));
        }

        #endregion

        #region Public Methods

        public bool IsEnabled()
        {
            return Enabled == "1";
        }

        public bool IsLocked()
        {
            return Lock == "1";
        }

        public bool IsRequired()
        {
            return Required == "1";
        }

        #endregion
    }
}
