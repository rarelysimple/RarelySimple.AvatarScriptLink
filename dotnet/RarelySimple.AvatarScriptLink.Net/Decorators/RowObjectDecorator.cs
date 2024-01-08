using RarelySimple.AvatarScriptLink.Objects;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class RowObjectDecorator
    {
        private readonly RowObject _rowObject;

        public List<FieldObjectDecorator> Fields { get; set; }
        public string ParentRowId { get; }
        public string RowAction { get; set; }
        public string RowId { get; }

        public RowObjectDecorator(RowObject rowObject)
        {
            _rowObject = rowObject;
            ParentRowId = rowObject.ParentRowId;
            RowAction = rowObject.RowAction;
            RowId = rowObject.RowId;

            Fields = new List<FieldObjectDecorator>();
            foreach (var fieldObject in rowObject.Fields)
            {
                Fields.Add(new FieldObjectDecorator(fieldObject));
            }
        }

        public RowObjectDecoratorReturnBuilder Return()
        {
            return new RowObjectDecoratorReturnBuilder(this);
        }

        /// <summary>
        /// Adds a <see cref="FieldObject"/> to a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldObject"></param>
        public void AddFieldObject(FieldObject fieldObject) => this.Fields = RowObjectDecoratorHelper.AddFieldObject(this, fieldObject).Fields;

        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in the <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public void SetFieldValue(string fieldNumber, string fieldValue) => this.Fields = RowObjectDecoratorHelper.SetFieldValue(this, fieldNumber, fieldValue).Fields;
    }
}
