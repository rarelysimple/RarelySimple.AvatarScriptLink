using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;
using System;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class OptionObjectDecorator
    {
        private readonly IOptionObject _optionObject;

        public double ErrorCode { get; set; }
        public string ErrorMesg { get; set; }
        public List<FormObjectDecorator> Forms { get; set; }

        public OptionObjectDecorator(OptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject));
            _optionObject = optionObject.Clone();

            Forms = new List<FormObjectDecorator>();
            foreach (var form in optionObject.Forms ?? new List<FormObject>())
            {
                Forms.Add(new FormObjectDecorator(form));
            }
        }

        public string EntityID => _optionObject.EntityID;
        public double EpisodeNumber => _optionObject.EpisodeNumber;
        public string Facility => _optionObject.Facility;
        public string OptionId => _optionObject.OptionId;
        public string OptionStaffId => _optionObject.OptionStaffId;
        public string OptionUserId => _optionObject.OptionUserId;
        public string SystemCode => _optionObject.SystemCode;

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObjectDecorator"/>.
        /// </summary>
        /// <param name="formObject"></param>
        public void AddFormObject(FormObject formObject) => Forms = Helper.AddFormObject(this, formObject).Forms;

        /// <summary>
        /// Adds a <see cref="FormObjectDecorator"/> to an <see cref="OptionObjectDecorator"/>.
        /// </summary>
        /// <param name="formObject"></param>
        public void AddFormObject(FormObjectDecorator formObject) => Forms = Helper.AddFormObject(this, formObject).Forms;

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObjectDecorator"/>.
        /// </summary>
        /// <param name="formId"></param>
        public void AddFormObject(string formId) => Forms = Helper.AddFormObject(this, formId).Forms;

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObjectDecorator"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="multipleIteration"></param>
        public void AddFormObject(string formId, bool multipleIteration) => Forms = Helper.AddFormObject(this, formId, multipleIteration).Forms;

        /// <summary>
        /// Adds a <see cref="RowObject"/> to a specified <see cref="FormObjectDecorator"/> within the <see cref="OptionObjectDecorator"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        public void AddRowObject(string formId, RowObject rowObject) => Forms = Helper.AddRowObject(this, formId, rowObject).Forms;

        /// <summary>
        /// Flags a <see cref="RowObject"/> for deletion in a specified <see cref="FormObjectDecorator"/> within the <see cref="OptionObjectDecorator"/> by RowId.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        public void DeleteRowObject(string formId, string rowId) => Forms = Helper.DeleteRowObject(this, formId, rowId).Forms;

        /// <summary>
        /// Disables all <see cref="FieldObject"/> in the <see cref="OptionObjectDecorator"/>.
        /// </summary>
        public void DisableAllFieldObjects() => Forms = Helper.DisableAllFieldObjects(this).Forms;

        /// <summary>
        /// Disables all <see cref="FieldObject"/> in the <see cref="OptionObjectDecorator"/>, except for the FieldNumbers specified in the list.
        /// </summary>
        /// <param name="excludedFields"></param>
        public void DisableAllFieldObjects(List<string> excludedFields) => Forms = Helper.DisableAllFieldObjects(this, excludedFields).Forms;

        /// <summary>
        /// Returns the CurrentRow RowId of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetCurrentRowId(string formId) => Helper.GetCurrentRowId(this, formId);

        /// <summary>
        /// Returns the first value of the field matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber) => Helper.GetFieldValue(this, fieldNumber);

        /// <summary>
        /// Returns the value of the <see cref="FieldObject"/> matching the Field Number on the specified <see cref="FormObject"/> and <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string formId, string rowId, string fieldNumber) => Helper.GetFieldValue(this, formId, rowId, fieldNumber);

        /// <summary>
        /// Returns the values of the field matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public List<string> GetFieldValues(string fieldNumber) => Helper.GetFieldValues(this, fieldNumber);

        /// <summary>
        /// Returns the Multiple Iteration Status of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool GetMultipleIterationStatus(string formId) => Helper.GetMultipleIterationStatus(this, formId);

        /// <summary>
        /// Returns the CurrentRow ParentRowId of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetParentRowId(string formId) => Helper.GetParentRowId(this, formId);

        /// <summary>
        /// Returns whether the specified field is enabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber) => Helper.IsFieldEnabled(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldLocked(string fieldNumber) => Helper.IsFieldLocked(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is modified.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldModified(string fieldNumber) => Helper.IsFieldModified(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is present.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => Helper.IsFieldPresent(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldRequired(string fieldNumber) => Helper.IsFieldRequired(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified <see cref="FormObject"/> is present.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool IsFormPresent(string formId) => Helper.IsFormPresent(this, formId);

        /// <summary>
        /// Returns whether the specified <see cref="RowObject"/> is marked for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public bool IsRowMarkedForDeletion(string rowId) => Helper.IsRowMarkedForDeletion(this, rowId);

        /// <summary>
        /// Returns whether the specified <see cref="RowObject"/> is present.
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public bool IsRowPresent(string rowId) => Helper.IsRowPresent(this, rowId);

        /// <summary>
        /// Creates a return builder for the <see cref="OptionObjectDecorator"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObjectDecoratorReturnBuilder Return()
        {
            return new OptionObjectDecoratorReturnBuilder(this);
        }

        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObjectDecorator"/> on the first form CurrentRow.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string fieldNumber, string fieldValue) => Forms = Helper.SetFieldValue(this, fieldNumber, fieldValue).Forms;

        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObjectDecorator"/> 
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string formId, string rowId, string fieldNumber, string fieldValue) => Forms = Helper.SetFieldValue(this, formId, rowId, fieldNumber, fieldValue).Forms;

        /// <summary>
        /// Creates an <see cref="OptionObject"/> with the minimal information required to return.
        /// </summary>
        /// <returns></returns>
        public OptionObject ToReturnOptionObject() => Return().AsOptionObject();

        /// <summary>
        /// Creates an <see cref="OptionObject"/> with the minimal information required to return plus the provide Error Code and Message.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public OptionObject ToReturnOptionObject(double errorCode, string errorMessage) => Return().WithErrorCode(errorCode).WithErrorMesg(errorMessage).AsOptionObject();
    }
}
