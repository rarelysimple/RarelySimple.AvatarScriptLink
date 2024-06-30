using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="FormObject"/> within an <see cref="OptionObject"/>.
    /// </summary>
    public sealed class FormObject : FormObjectBase, IEquatable<FormObject>
    {
        /// <summary>
        /// Initializes a <see cref="FormObject"/>
        /// </summary>
        /// <returns>A <see cref="FormObject"/></returns>
        public static FormObject Initialize() { return new FormObject(); }

        /// <summary>
        /// Returns a deep copy of the <see cref="FormObject"/>.
        /// </summary>
        /// <returns></returns>
        public new FormObject Clone()
        {
            var formObject = (FormObject) MemberwiseClone();
            formObject.CurrentRow = CurrentRow?.Clone();
            formObject.OtherRows = new List<RowObject>();
            foreach (var row in OtherRows)
            {
                formObject.OtherRows.Add(row.Clone());
            }
            return formObject;
        }

        #region IEquatable Implementation

        /// <summary>
        /// Used to compare two <see cref="FormObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="CustomFormObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="FormObject"/> are equal.</returns>
        public bool Equals(FormObject other)
        {
            if (other == null)
                return false;
            return FormId == other.FormId &&
                   MultipleIteration == other.MultipleIteration &&
                   ((CurrentRow == null && other.CurrentRow == null) ||
                   CurrentRow == other.CurrentRow) &&
                   AreRowsEqual(OtherRows, other.OtherRows);
        }

        /// <summary>
        /// Used to compare <see cref="FormObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="FormObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is FormObject formObject))
                return false;
            return Equals(formObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="FormObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="FormObject"/>.</returns>
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + (FormId != null ? FormId.GetHashCode() : 0);
            hash = hash * 23 + MultipleIteration.GetHashCode();
            hash = hash * 23 + (CurrentRow != null ? CurrentRow.GetHashCode() : 0);
            if (OtherRows != null)
            {
                foreach (RowObject rowObject in OtherRows)
                {
                    hash = hash * 23 + (rowObject != null ? rowObject.GetHashCode() : 0);
                }
            }
            return hash;
        }

        private static bool AreRowsEqual(List<RowObject> list1, List<RowObject> list2)
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

        private static bool AreBothEmpty(List<RowObject> list1, List<RowObject> list2) => !list1.Any() && !list2.Any();

        private static bool AreBothNull(List<RowObject> list1, List<RowObject> list2) => list1 == null && list2 == null;

        public static bool operator ==(FormObject formObject1, FormObject formObject2)
        {
            if (((object)formObject1) == null || ((object)formObject2) == null)
                return Equals(formObject1, formObject2);

            return formObject1.Equals(formObject2);
        }

        public static bool operator !=(FormObject formObject1, FormObject formObject2)
        {
            if (((object)formObject1) == null || ((object)formObject2) == null)
                return !Equals(formObject1, formObject2);

            return !formObject1.Equals(formObject2);
        }

        #endregion
    }
}
