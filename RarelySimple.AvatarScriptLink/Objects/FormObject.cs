using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RarelySimple.AvatarScriptLink.Helpers;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="FormObject"/> within an <see cref="OptionObject"/>.
    /// </summary>
    public class FormObject : FormObjectBase
    {

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="FormObject"/>.
        /// </summary>
        public FormObject() : base()
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formId"></param>
        public FormObject(string formId) : base(formId)
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="currentRow"></param>
        public FormObject(string formId, RowObject currentRow) : base(formId, currentRow)
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="currentRow"></param>
        /// <param name="multipleIteration"></param>
        public FormObject(string formId, RowObject currentRow, bool multipleIteration) : base(formId, currentRow, multipleIteration)
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="currentRow"></param>
        /// <param name="multipleIteration"></param>
        /// <param name="otherRows"></param>
        public FormObject(string formId, RowObject currentRow, bool multipleIteration, List<RowObject> otherRows)
            : base(formId, currentRow, multipleIteration, otherRows)
        { }




        /// <summary>
        /// Returns a deep copy of the <see cref="FormObject"/>.
        /// </summary>
        /// <returns></returns>
        public new FormObject Clone()
        {
            var formObject = (FormObject)MemberwiseClone();
            formObject.CurrentRow = CurrentRow.Clone();
            formObject.OtherRows = new List<RowObject>();
            foreach (var row in OtherRows)
            {
                formObject.OtherRows.Add(row.Clone());
            }
            return formObject;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FormObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FormObject"/> formatted as XML.</returns>
        public override string ToXml() => OptionObjectHelpers.TransformToXml(this);
    }
}