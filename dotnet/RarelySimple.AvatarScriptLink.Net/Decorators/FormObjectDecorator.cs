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
            if (formObject.CurrentRow != null)
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
        /// Returns the value of the <see cref="FieldObject"/> in the CurrentRow of the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber) => Helper.GetFieldValue(this, fieldNumber);

        /// <summary>
        /// Returns the value of the <see cref="FieldObject"/> in the <see cref="RowObject"/> of the <see cref="FormObject"/> by RowId and FieldNumber.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string rowId, string fieldNumber) => Helper.GetFieldValue(this, rowId, fieldNumber);

        /// <summary>
        /// Returns the Multiple Iteration Status of the <see cref="FormObject">.
        /// </summary>
        /// <returns></returns>
        public bool GetMultipleIterationStatus() => Helper.GetMultipleIterationStatus(this);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is enabled in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber) => Helper.IsFieldEnabled(this, fieldNumber);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is present in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => Helper.IsFieldPresent(this, fieldNumber);
        
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