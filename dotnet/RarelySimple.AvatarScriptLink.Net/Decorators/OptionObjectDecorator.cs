﻿using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;
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
            _optionObject = optionObject.Clone();

            Forms = new List<FormObjectDecorator>();
            foreach (var form in optionObject.Forms)
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

        public OptionObjectDecoratorReturnBuilder Return()
        {
            return new OptionObjectDecoratorReturnBuilder(this);
        }

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
        /// Returns the Multiple Iteration Status of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool GetMultipleIterationStatus(string formId) => Helper.GetMultipleIterationStatus(this, formId);

        /// <summary>
        /// Returns whether the specified field is present.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => Helper.IsFieldPresent(this, fieldNumber);

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