using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts
{
    public class RowObjectBase : ObjectBase, IRowObject
    {
        /// <summary>
        /// Gets or sets the Fields property of the <see cref="RowObject"/> 
        /// </summary>
        /// <value>This value is a <see cref="List{T}"/> of <see cref="FieldObject"/>.</value>
        public string RowId { get; set; }
        /// <summary>
        /// Gets or sets the ParentRowId property of the <see cref="RowObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and references the <see cref="RowId"/> of the <see cref="FormObject.CurrentRow"/> of the enclosing <see cref="FormObject"/>.</value>
        public List<FieldObject> Fields { get; set; }
        /// <summary>
        /// Gets or sets the RowAction property of the <see cref="RowObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> containing ADD, EDIT, or DELETE. Other values are invalid.</value>
        public string ParentRowId { get; set; }
        /// <summary>
        /// Gets or sets the RowId property of the <see cref="RowObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> containing the unique Id for the row.</value>
        public string RowAction { get; set; }

        #region Constructors

        /// <summary>
        /// Creates a new <see cref="RowObject"/>. 
        /// </summary>
        protected RowObjectBase()
        {
            Fields = new List<FieldObject>();
            RowAction = string.Empty;
        }

        #endregion
    }
}
