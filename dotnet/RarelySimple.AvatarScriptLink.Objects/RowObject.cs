using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Objects
{
    public sealed class RowObject : RowObjectBase, IEquatable<RowObject>
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

        #region IEquatable Implementation

        /// <summary>
        /// Used to compare two <see cref="RowObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="RowObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="RowObject"/> are equal.</returns>
        public bool Equals(RowObject other)
        {
            if (other == null)
                return false;
            return ParentRowId == other.ParentRowId &&
                ((RowAction == null && other.RowAction == null) ||
                RowAction == other.RowAction) &&
                RowId == other.RowId &&
                AreFieldsEqual(this.Fields, other.Fields);
        }

        /// <summary>
        /// Used to compare <see cref="RowObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="RowObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is RowObject rowObject))
                return false;
            return Equals(rowObject);
        }
        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="RowObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="RowObject"/>.</returns>
        public override int GetHashCode()
        {
            string delimiter = "||";
            StringBuilder sb = new StringBuilder();
            sb.Append(ParentRowId
                + delimiter + RowAction
                + delimiter + RowId);
            foreach (FieldObject fieldObject in Fields)
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

        private static bool AreBothEmpty(List<FieldObject> list1, List<FieldObject> list2) => !list1.Any() && !list2.Any();

        private static bool AreBothNull(List<FieldObject> list1, List<FieldObject> list2) => list1 == null && list2 == null;

        public static bool operator ==(RowObject rowObject1, RowObject rowObject2)
        {
            if (((object)rowObject1) == null || ((object)rowObject2) == null)
                return Equals(rowObject1, rowObject2);

            return rowObject1.Equals(rowObject2);
        }

        public static bool operator !=(RowObject rowObject1, RowObject rowObject2)
        {
            if (((object)rowObject1) == null || ((object)rowObject2) == null)
                return !Equals(rowObject1, rowObject2);

            return !rowObject1.Equals(rowObject2);
        }

        #endregion
    }
}
