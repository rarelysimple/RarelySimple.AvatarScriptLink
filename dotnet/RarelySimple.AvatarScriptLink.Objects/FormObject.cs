using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="FormObject"/> within an <see cref="OptionObject"/>.
    /// </summary>
    public sealed class FormObject : FormObjectBase
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
    }
}
