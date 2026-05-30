using RarelySimple.AvatarScriptLink.Objects.Abstracts;
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
            foreach (var row in OtherRows?.Where(r => r != null) ?? Enumerable.Empty<RowObject>())
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
                   RowObject.AreRowsEqual(OtherRows, other.OtherRows);
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
            foreach (RowObject rowObject in OtherRows ?? Enumerable.Empty<RowObject>())
            {
                hash = hash * 23 + (rowObject != null ? rowObject.GetHashCode() : 0);
            }
            return hash;
        }

        public static bool AreFormsEqual(List<FormObject> list1, List<FormObject> list2)
        {
            var count1 = list1?.Count ?? 0;
            var count2 = list2?.Count ?? 0;

            if (count1 != count2)
                return false;

            for (int i = 0; i < count1; i++)
            {
                if (!Equals(list1[i], list2[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AreBothEmpty(List<FormObject> list1, List<FormObject> list2) => (list1?.Count ?? 0) == 0 && (list2?.Count ?? 0) == 0;

        public static bool AreBothNull(List<FormObject> list1, List<FormObject> list2) => list1 == null && list2 == null;

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
