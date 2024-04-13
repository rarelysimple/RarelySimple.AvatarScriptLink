using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="FieldObject"/> within a <see cref="RowObject"/>.
    /// </summary>
    public sealed class FieldObject : FieldObjectBase, IEquatable<FieldObject>
    {
        /// <summary>
        /// Initializes a FieldObject.
        /// </summary>
        /// <returns>A <see cref="FieldObject"/></returns>
        public static FieldObject Initialize()
        {
            return new FieldObject();
        }

        /// <summary>
        /// Returns a copy of the <see cref="FieldObject"/>.
        /// </summary>
        /// <returns></returns>
        public new FieldObject Clone()
        {
            return (FieldObject) MemberwiseClone();
        }

        #region IEquatable Implementation

        /// <summary>
        /// Used to compare two <see cref="FieldObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="FieldObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether two <see cref="FieldObject"/> are equal.</returns>
        public bool Equals(FieldObject other)
        {
            return other != null &&
                FieldValue == other.FieldValue &&
                Required == other.Required &&
                Enabled == other.Enabled &&
                FieldNumber == other.FieldNumber &&
                Lock == other.Lock;
        }
        /// <summary>
        /// Used to compare <see cref="FieldObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="FieldObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is FieldObject fieldObject))
                return false;
            return Equals(fieldObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="FieldObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="FieldObject"/>.</returns>
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + (FieldNumber != null ? FieldNumber.GetHashCode() : 0);
            hash = hash * 23 + (FieldValue != null ? FieldValue.GetHashCode() : 0);
            hash = hash * 23 + (Enabled != null ? Enabled.GetHashCode() : 0);
            hash = hash * 23 + (Lock != null ? Lock.GetHashCode() : 0);
            hash = hash * 23 + (Required != null ? Required.GetHashCode() : 0);
            return hash;
        }

        public static bool operator ==(FieldObject fieldObject1, FieldObject fieldObject2)
        {
            if (((object)fieldObject1) == null || ((object)fieldObject2) == null)
                return Equals(fieldObject1, fieldObject2);

            return fieldObject1.Equals(fieldObject2);
        }

        public static bool operator !=(FieldObject fieldObject1, FieldObject fieldObject2)
        {
            if (((object)fieldObject1) == null || ((object)fieldObject2) == null)
                return !Equals(fieldObject1, fieldObject2);

            return !fieldObject1.Equals(fieldObject2);
        }

        #endregion
    }
}
