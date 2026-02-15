using RarelySimple.AvatarScriptLink.Objects.Interfaces;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Abstracts
{
    public class FormObjectBase : ObjectBase, IFormObject
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

        #region Collection Presence Helpers

        /// <summary>
        /// Gets a value indicating whether the OtherRows collection contains any elements.
        /// </summary>
        /// <returns>True if OtherRows is not null and contains at least one row, false otherwise.</returns>
        /// <remarks>
        /// <para>This method safely checks if there are any additional rows in the form.</para>
        /// <para>Use this method before iterating over OtherRows to avoid null reference exceptions.</para>
        /// </remarks>
        public bool HasOtherRows() => OtherRows != null && OtherRows.Count > 0;

        /// <summary>
        /// Gets a value indicating whether the CurrentRow is set.
        /// </summary>
        /// <returns>True if CurrentRow is not null, false otherwise.</returns>
        /// <remarks>
        /// <para>This method safely checks if the form has a current row set.</para>
        /// <para>Use this method before accessing CurrentRow properties to avoid null reference exceptions.</para>
        /// </remarks>
        public bool HasCurrentRow() => CurrentRow != null;

        #endregion
    }
}
