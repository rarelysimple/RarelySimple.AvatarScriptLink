using System.Collections.Generic;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class FormObjectDecorator
    {
        private readonly FormObject _formObject;

        public RowObjectDecorator CurrentRow { get; set; }
        public List<RowObjectDecorator> OtherRows { get; set; }

        public FormObjectDecorator(FormObject formObject)
        {
            _formObject = formObject;
            CurrentRow = new RowObjectDecorator(formObject.CurrentRow);
            OtherRows = new List<RowObjectDecorator>();
            foreach (var rowObject in formObject.OtherRows)
            {
                OtherRows.Add(new RowObjectDecorator(rowObject));
            }
        }

        public string FormId => _formObject.FormId;
        public bool MultipleIteration => _formObject.MultipleIteration;

        public FormObjectDecoratorReturnBuilder Return()
        {
            return new FormObjectDecoratorReturnBuilder(this);
        }
        
        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in the <see cref="CurrentRow"/> of a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string fieldNumber, string fieldValue)
        {
            var tempDecorator = Helper.SetFieldValue(this, fieldNumber, fieldValue);
            CurrentRow = tempDecorator.CurrentRow;
            OtherRows = tempDecorator.OtherRows;
        }
        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string rowId, string fieldNumber, string fieldValue)
        {
            var tempDecorator = Helper.SetFieldValue(this, rowId, fieldNumber, fieldValue);
            CurrentRow = tempDecorator.CurrentRow;
            OtherRows = tempDecorator.OtherRows;
        }
    }
}