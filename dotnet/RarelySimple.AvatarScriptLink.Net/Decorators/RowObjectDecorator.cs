using RarelySimple.AvatarScriptLink.Objects;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class RowObjectDecorator
    {
        private readonly RowObject _rowObject;

        public List<FieldObjectDecorator> Fields { get; set; }
        public string RowAction { get; set; }

        public RowObjectDecorator(RowObject rowObject)
        {
            _rowObject = rowObject;
            RowAction = rowObject.RowAction;

            Fields = new List<FieldObjectDecorator>();
            foreach (var fieldObject in rowObject.Fields)
            {
                Fields.Add(new FieldObjectDecorator(fieldObject));
            }
        }

        public string ParentRowId => _rowObject.ParentRowId;
        public string RowId => _rowObject.RowId;

        public RowObjectDecoratorReturnBuilder Return()
        {
            return new RowObjectDecoratorReturnBuilder(this);
        }

        /// <summary>
        /// Adds a <see cref="FieldObject"/> to a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldObject"></param>
        public void AddFieldObject(FieldObject fieldObject) => Fields = Helper.AddFieldObject(this, fieldObject).Fields;

        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is present in <see cref="RowObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => Helper.IsFieldPresent(this, fieldNumber);

        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in the <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public void SetFieldValue(string fieldNumber, string fieldValue) => Fields = Helper.SetFieldValue(this, fieldNumber, fieldValue).Fields;
    }
}
