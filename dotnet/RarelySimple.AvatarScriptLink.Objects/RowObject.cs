using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects
{
    public sealed class RowObject : RowObjectBase
    {
        /// <summary>
        /// Initializes a <see cref="RowObject"/>
        /// </summary>
        /// <returns>A <see cref="RowObject"/></returns>
        public static RowObject Initialize() { return new RowObject(); }

        /// <summary>
        /// Returns a deep copy of the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public new RowObject Clone()
        {
            var rowObject = (RowObject) MemberwiseClone();
            rowObject.Fields = new List<FieldObject>();
            foreach (var field in Fields)
            {
                rowObject.Fields.Add(field.Clone());
            }
            return rowObject;
        }
    }
}
