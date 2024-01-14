using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts
{
    public class RowObjectBase : ObjectBase, IEquatable<RowObjectBase>, IRowObject
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

        #region IEquatable Implementation

        /// <summary>
        /// Used to compare two <see cref="RowObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="RowObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="RowObject"/> are equal.</returns>
        public bool Equals(RowObjectBase other)
        {
            if (other == null)
                return false;
            return this.ParentRowId == other.ParentRowId &&
                ((this.RowAction == null && other.RowAction == null) ||
                this.RowAction == other.RowAction) &&
                this.RowId == other.RowId &&
                AreFieldsEqual(this.Fields, other.Fields);
        }

        /// <summary>
        /// Used to compare <see cref="RowObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="RowObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            RowObject rowObject = obj as RowObject;
            if (rowObject == null)
                return false;
            return this.Equals(rowObject);
        }
        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="RowObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="RowObject"/>.</returns>
        public override int GetHashCode()
        {
            string delimiter = "||";
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ParentRowId
                + delimiter + this.RowAction
                + delimiter + this.RowId);
            foreach (FieldObject fieldObject in this.Fields)
            {
                sb.Append(delimiter + fieldObject.GetHashCode());
            }
            return sb.GetHashCode();
        }

        private static bool AreFieldsEqual(List<FieldObject> list1, List<FieldObject> list2)
        {
            if (!AreBothNull(list1, list2) && AreBothEmpty(list1, list2))
                return true;
            if (list1.Count != list2.Count)
                return false;
            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1[i].Equals(list2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool AreBothEmpty(List<FieldObject> list1, List<FieldObject> list2) => (!list1.Any() && !list2.Any());

        private static bool AreBothNull(List<FieldObject> list1, List<FieldObject> list2) => (list1 == null && list2 == null);

        public static bool operator ==(RowObjectBase rowObject1, RowObjectBase rowObject2)
        {
            if (((object)rowObject1) == null || ((object)rowObject2) == null)
                return Equals(rowObject1, rowObject2);

            return rowObject1.Equals(rowObject2);
        }

        public static bool operator !=(RowObjectBase rowObject1, RowObjectBase rowObject2)
        {
            if (((object)rowObject1) == null || ((object)rowObject2) == null)
                return !Equals(rowObject1, rowObject2);

            return !(rowObject1.Equals(rowObject2));
        }

        #endregion
    }
}
