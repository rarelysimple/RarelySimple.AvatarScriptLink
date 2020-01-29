using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RarelySimple.AvatarScriptLink.Helpers;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="RowObject"/> contained within a <see cref="FormObject"/>.
    /// </summary>
    public class RowObject : RowObjectBase
    {
        /// <summary>
        /// Creates a new <see cref="RowObject"/>. 
        /// </summary>
        public RowObject() : base()
        { }

        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/>.
        /// </summary>
        /// <param name="rowId"></param>
        public RowObject(string rowId) : base(rowId)
        { }
        
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="ParentRowId"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        public RowObject(string rowId, string parentRowId) : base(rowId, parentRowId)
        { }

        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/>, <see cref="ParentRowId"/>, and <see cref="RowAction"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        public RowObject(string rowId, string parentRowId, string rowAction) : base(rowId, parentRowId, rowAction)
        { }

        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        public RowObject(string rowId, List<FieldObject> fieldObjects) : base(rowId, fieldObjects)
        { }

        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        /// <param name="parentRowId"></param>
        public RowObject(string rowId, List<FieldObject> fieldObjects, string parentRowId) : base(rowId, fieldObjects, parentRowId)
        { }

        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        public RowObject(string rowId, List<FieldObject> fieldObjects, string parentRowId, string rowAction) 
            : base(rowId, fieldObjects, parentRowId, rowAction)
        { }


        /// <summary>
        /// Returns a deep copy of the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public new RowObject Clone()
        {
            var rowObject = (RowObject)MemberwiseClone();
            rowObject.Fields = new List<FieldObject>();
            foreach (var field in Fields)
            {
                rowObject.Fields.Add(field.Clone());
            }
            return rowObject;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted as XML.</returns>
        public override string ToXml() => OptionObjectHelpers.TransformToXml(this);
    }
}