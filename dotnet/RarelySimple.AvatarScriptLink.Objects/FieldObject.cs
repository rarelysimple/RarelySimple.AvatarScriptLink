using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="FieldObject"/> within a <see cref="RowObject"/>.
    /// </summary>
    public sealed class FieldObject : FieldObjectBase
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
    }
}
