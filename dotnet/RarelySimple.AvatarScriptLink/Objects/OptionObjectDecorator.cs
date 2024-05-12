using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects
{
    public class OptionObjectDecorator : IOptionObjectDecorator
    {
        private readonly IOptionObject2015 _optionObject;

        public OptionObjectDecorator(IOptionObject2015 optionObject)
        {
            _optionObject = optionObject;
        }

        public string EntityID => _optionObject.EntityID;
        public double EpisodeNumber => _optionObject.EpisodeNumber;
        public double ErrorCode => _optionObject.ErrorCode;
        public string ErrorMesg => _optionObject.ErrorMesg;
        public string Facility => _optionObject.Facility;
        public List<FormObject> Forms => _optionObject.Forms;
        public string NamespaceName => _optionObject.NamespaceName;
        public string OptionId => _optionObject.OptionId;
        public string OptionStaffId => _optionObject.OptionStaffId;
        public string OptionUserId => _optionObject.OptionUserId;
        public string ParentNamespace => _optionObject.ParentNamespace;
        public string ServerName => _optionObject.ServerName;
        public string SystemCode => _optionObject.SystemCode;
        public string SessionToken => _optionObject.SessionToken;

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="formObject"></param>
        public void AddFormObject(FormObject formObject) => _optionObject.Forms = OptionObjectHelpers.AddFormObject(_optionObject, formObject).Forms;

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="multipleIteration"></param>
        public void AddFormObject(string formId, bool multipleIteration) => _optionObject.Forms = OptionObjectHelpers.AddFormObject(_optionObject, formId, multipleIteration).Forms;

        /// <summary>
        /// Adds a <see cref="RowObject"/> to a <see cref="FormObject"/> in _optionObject <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        public void AddRowObject(string formId, RowObject rowObject) => _optionObject.Forms = OptionObjectHelpers.AddRowObject(_optionObject, formId, rowObject).Forms;

        /// <summary>
        /// Clones the <see cref="OptionObjectBase"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObjectBase Clone()
        {
            var optionObject = (OptionObjectBase)MemberwiseClone();
            optionObject.Forms = new List<FormObject>();
            foreach (var form in optionObject.Forms)
            {
                optionObject.Forms.Add(form.Clone());
            }
            return optionObject;
        }

        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowObject"></param>
        public void DeleteRowObject(RowObject rowObject) => _optionObject.Forms = OptionObjectHelpers.DeleteRowObject(_optionObject, rowObject).Forms;

        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        public void DeleteRowObject(string rowId) => _optionObject.Forms = OptionObjectHelpers.DeleteRowObject(_optionObject, rowId).Forms;

        /// <summary>
        /// Sets all <see cref="FieldObject"/> as disabled.
        /// </summary>
        public void DisableAllFieldObjects() => _optionObject.Forms = OptionObjectHelpers.DisableAllFieldObjects(_optionObject).Forms;

        /// <summary>
        /// Sets all <see cref="FieldObject"/> as disabled except for any listed to be excluded.
        /// </summary>
        /// <param name="excludedFieldObjects"></param>
        public void DisableAllFieldObjects(List<string> excludedFieldObjects) => _optionObject.Forms = OptionObjectHelpers.DisableAllFieldObjects(_optionObject, excludedFieldObjects).Forms;

        /// <summary>
        /// Returns the CurrentRow RowId of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetCurrentRowId(string formId) => OptionObjectHelpers.GetCurrentRowId(_optionObject, formId);

        /// <summary>
        /// Returns the first value of the field matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber) => OptionObjectHelpers.GetFieldValue(_optionObject, fieldNumber);

        /// <summary>
        /// Returns the value of the <see cref="FieldObject"/> matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string formId, string rowId, string fieldNumber) => OptionObjectHelpers.GetFieldValue(_optionObject, formId, rowId, fieldNumber);

        /// <summary>
        /// Returns the values of the field matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public List<string> GetFieldValues(string fieldNumber) => OptionObjectHelpers.GetFieldValues(_optionObject, fieldNumber);

        /// <summary>
        /// Returns the Multiple Iteration Status of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool GetMultipleIterationStatus(string formId) => OptionObjectHelpers.GetMultipleIterationStatus(_optionObject, formId);

        /// <summary>
        /// Returns the CurrentRow ParentRowId of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetParentRowId(string formId) => OptionObjectHelpers.GetParentRowId(_optionObject, formId);

        /// <summary>
        /// Returns whether the specified field is enabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber) => OptionObjectHelpers.IsFieldEnabled(_optionObject, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldLocked(string fieldNumber) => OptionObjectHelpers.IsFieldLocked(_optionObject, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is modified.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldModified(string fieldNumber) => OptionObjectHelpers.IsFieldModified(_optionObject, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is present.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => OptionObjectHelpers.IsFieldPresent(_optionObject, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldRequired(string fieldNumber) => OptionObjectHelpers.IsFieldRequired(_optionObject, fieldNumber);

        /// <summary>
        /// Returns whether the specified <see cref="FormObject"/> is present.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool IsFormPresent(string formId) => OptionObjectHelpers.IsFormPresent(_optionObject, formId);

        /// <summary>
        /// Returns whether the specified <see cref="RowObject"/> is marked for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public bool IsRowMarkedForDeletion(string rowId) => OptionObjectHelpers.IsRowMarkedForDeletion(_optionObject, rowId);

        /// <summary>
        /// Returns whether the specified <see cref="RowObject"/> is present.
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public bool IsRowPresent(string rowId) => OptionObjectHelpers.IsRowPresent(_optionObject, rowId);

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetDisabledField(string fieldNumber) => _optionObject.Forms = OptionObjectHelpers.SetDisabledField(_optionObject, fieldNumber).Forms;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetDisabledFields(List<string> fieldNumbers) => _optionObject.Forms = OptionObjectHelpers.SetDisabledFields(_optionObject, fieldNumbers).Forms;

        /// <summary>
        /// Set the specified field as enabled and not required.
        /// <para>_optionObject is the equivalent of <see cref="SetOptionalField(string)"/>.</para>
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetEnabledField(string fieldNumber) => _optionObject.Forms = OptionObjectHelpers.SetEnabledField(_optionObject, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as enabled and not required.
        /// <para>_optionObject is the equivalent of <see cref="SetOptionalFields(List{string})"/>.</para>
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetEnabledFields(List<string> fieldNumbers) => _optionObject.Forms = OptionObjectHelpers.SetEnabledFields(_optionObject, fieldNumbers).Forms;

        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject"/> on the first form CurrentRow.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string fieldNumber, string fieldValue) => _optionObject.Forms = OptionObjectHelpers.SetFieldValue(_optionObject, fieldNumber, fieldValue).Forms;

        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject2015"/> 
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string formId, string rowId, string fieldNumber, string fieldValue) => _optionObject.Forms = OptionObjectHelpers.SetFieldValue(_optionObject, formId, rowId, fieldNumber, fieldValue).Forms;

        /// <summary>
        /// Set the specified field as locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetLockedField(string fieldNumber) => _optionObject.Forms = OptionObjectHelpers.SetLockedField(_optionObject, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as locked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetLockedFields(List<string> fieldNumbers) => _optionObject.Forms = OptionObjectHelpers.SetLockedFields(_optionObject, fieldNumbers).Forms;

        /// <summary>
        /// Set the specified field as not required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetOptionalField(string fieldNumber) => _optionObject.Forms = OptionObjectHelpers.SetOptionalField(_optionObject, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as not required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetOptionalFields(List<string> fieldNumbers) => _optionObject.Forms = OptionObjectHelpers.SetOptionalFields(_optionObject, fieldNumbers).Forms;

        /// <summary>
        /// Sets the specified field as required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetRequiredField(string fieldNumber) => _optionObject.Forms = OptionObjectHelpers.SetRequiredField(_optionObject, fieldNumber).Forms;

        /// <summary>
        /// Sets the specified fields as required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetRequiredFields(List<string> fieldNumbers) => _optionObject.Forms = OptionObjectHelpers.SetRequiredFields(_optionObject, fieldNumbers).Forms;

        /// <summary>
        /// Set the specified field as unlocked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetUnlockedField(string fieldNumber) => _optionObject.Forms = OptionObjectHelpers.SetUnlockedField(_optionObject, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as unlocked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetUnlockedFields(List<string> fieldNumbers) => _optionObject.Forms = OptionObjectHelpers.SetUnlockedFields(_optionObject, fieldNumbers).Forms;

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.</returns>
        public string ToHtmlString() => OptionObjectHelpers.TransformToHtmlString(_optionObject);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders) => OptionObjectHelpers.TransformToHtmlString(_optionObject, includeHtmlHeaders);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted as JSON.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted as JSON.</returns>
        public string ToJson() => OptionObjectHelpers.TransformToJson(_optionObject);

        /// <summary>
        /// Transforms the <see cref="OptionObjectBase"/>  to an <see cref="OptionObject"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObject ToOptionObject() => (OptionObject)_optionObject;

        /// <summary>
        /// Transforms the <see cref="OptionObjectBase"/>  to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObject2 ToOptionObject2() => (OptionObject2)_optionObject;

        /// <summary>
        /// Transforms the <see cref="OptionObjectBase"/>  to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public OptionObject2015 ToOptionObject2015() => (OptionObject2015)_optionObject;

        /// <summary>
        /// Creates an <see cref="OptionObjectBase"/> with the minimal information required to return.
        /// </summary>
        /// <returns></returns>
        public OptionObjectBase ToReturnOptionObject() => (OptionObjectBase)OptionObjectHelpers.GetReturnOptionObject(_optionObject);

        /// <summary>
        /// Creates an <see cref="OptionObjectBase"/> with the minimal information required to return plus the provide Error Code and Message.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public OptionObjectBase ToReturnOptionObject(double errorCode, string errorMessage) => (OptionObjectBase)OptionObjectHelpers.GetReturnOptionObject(_optionObject, errorCode, errorMessage);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObjectBase"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObjectBase"/> formatted as XML.</returns>
        public string ToXml() => OptionObjectHelpers.TransformToXml(_optionObject);
    }
}
