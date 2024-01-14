using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts
{
    public class FormObjectBase : ObjectBase, IEquatable<FormObjectBase>, IFormObject
    {
        /// <summary>
        /// Gets or sets the CurrentRow property of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="RowObject"/> containing the current row.</value>
        public RowObject CurrentRow { get; set; }
        /// <summary>
        /// Gets or sets the FormId propery of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>.</value>
        public string FormId { get; set; }
        /// <summary>
        /// Gets or sets the MultipleIteration property of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="bool"/> indicating whether the Option includes a multiple iteration table.</value>
        public bool MultipleIteration { get; set; }
        /// <summary>
        /// Gets or sets the OtherRows property of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="List{T}"/> of <see cref="RowObject"/> containing all of the rows of a multiple iteration table.</value>
        public List<RowObject> OtherRows { get; set; }

        #region Constructors

        /// <summary>
        /// Creates a new ScriptLink <see cref="FormObject"/>.
        /// </summary>
        protected FormObjectBase()
        {
            OtherRows = new List<RowObject>();
        }

        #endregion

        #region IEquatable Implementation

        /// <summary>
        /// Used to compare two <see cref="FormObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="CustomFormObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="FormObject"/> are equal.</returns>
        public bool Equals(FormObjectBase other)
        {
            if (other == null)
                return false;
            return FormId == other.FormId &&
                   MultipleIteration == other.MultipleIteration &&
                   ((CurrentRow == null && other.CurrentRow == null) ||
                   CurrentRow.Equals(other.CurrentRow)) &&
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
            string delimiter = "||";
            StringBuilder sb = new StringBuilder();
            sb.Append(FormId + delimiter + MultipleIteration.ToString(CultureInfo.InvariantCulture));
            sb.Append(CurrentRow != null ? delimiter + CurrentRow.GetHashCode().ToString(CultureInfo.InvariantCulture) : "");
            if (OtherRows != null)
            {
                foreach (RowObject rowObject in OtherRows)
                {
                    sb.Append(delimiter + rowObject.GetHashCode());
                }
            }
            return sb.GetHashCode();
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

        private static bool AreBothEmpty(List<RowObject> list1, List<RowObject> list2) => (!list1.Any() && !list2.Any());

        private static bool AreBothNull(List<RowObject> list1, List<RowObject> list2) => (list1 == null && list2 == null);

        public static bool operator ==(FormObjectBase formObject1, FormObjectBase formObject2)
        {
            if (((object)formObject1) == null || ((object)formObject2) == null)
                return Equals(formObject1, formObject2);

            return formObject1.Equals(formObject2);
        }

        public static bool operator !=(FormObjectBase formObject1, FormObjectBase formObject2)
        {
            if (((object)formObject1) == null || ((object)formObject2) == null)
                return !Equals(formObject1, formObject2);

            return !(formObject1.Equals(formObject2));
        }

        #endregion
    }
}
