﻿using RarelySimple.AvatarScriptLink.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public abstract class OptionObjectBase : IOptionObject2015
    {
        protected const string ParameterCannotBeNull = "parameterCannotBeNull";
        
        #region Constructors

        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObjectBase"/>.
        /// </summary>
        protected OptionObjectBase()
        {
            Forms = new List<FormObject>();
        }
        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObjectBase"/>.
        /// </summary>
        /// <param name="optionId"></param>
        /// <param name="optionUserId"></param>
        /// <param name="optionStaffId"></param>
        /// <param name="facility"></param>
        /// <param name="entityId"></param>
        /// <param name="episodeNumber"></param>
        /// <param name="systemCode"></param>
        /// <param name="namespaceName"></param>
        /// <param name="parentNamespace"></param>
        /// <param name="serverName"></param>
        /// <param name="sessionToken"></param>
        protected OptionObjectBase(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode, string namespaceName, string parentNamespace, string serverName
            , string sessionToken)
        {
            EntityID = entityId;
            EpisodeNumber = episodeNumber;
            Facility = facility;
            NamespaceName = namespaceName;
            OptionId = optionId;
            OptionStaffId = optionStaffId;
            OptionUserId = optionUserId;
            ParentNamespace = parentNamespace;
            ServerName = serverName;
            SessionToken = sessionToken;
            SystemCode = systemCode;

            Forms = new List<FormObject>();
        }
        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObjectBase"/>.
        /// </summary>
        /// <param name="optionId"></param>
        /// <param name="optionUserId"></param>
        /// <param name="optionStaffId"></param>
        /// <param name="facility"></param>
        /// <param name="entityId"></param>
        /// <param name="episodeNumber"></param>
        /// <param name="systemCode"></param>
        /// <param name="namespaceName"></param>
        /// <param name="parentNamespace"></param>
        /// <param name="serverName"></param>
        /// <param name="sessionToken"></param>
        /// <param name="forms"></param>
        protected OptionObjectBase(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode, string namespaceName, string parentNamespace, string serverName
            , string sessionToken
            , List<FormObject> forms)
        {
            EntityID = entityId;
            EpisodeNumber = episodeNumber;
            Facility = facility;
            NamespaceName = namespaceName;
            OptionId = optionId;
            OptionStaffId = optionStaffId;
            OptionUserId = optionUserId;
            ParentNamespace = parentNamespace;
            ServerName = serverName;
            SessionToken = sessionToken;
            SystemCode = systemCode;

            Forms = forms;
        }

        #endregion
        //
        // Public Properties (DO NOT MODIFY)
        //

        /// <summary>
        /// Gets or sets the EntityID property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and can contain a myAvatar PATID, STAFFID, USERID, or INCID.</value>
        public virtual string EntityID { get; set; }
        /// <summary>
        /// Gets or sets the Episode Number property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used with episodic, patient OptionObjects.</value>
        public virtual double EpisodeNumber { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used upon return to myAvatar to determine prompted response. Possible values include 0, 1, 2, 3, 4, and 5 as string values.</value>
        public virtual double ErrorCode { get; set; }
        /// <summary>
        /// Gets or sets the ErrorMesg property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used to display a message to the user in myAvatar for ErrorCodes 1-4.</value>
        public virtual string ErrorMesg { get; set; }
        /// <summary>
        /// Gets or sets the Facility property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. For most organizations, this value is 1, however more complex security configurations will utilize additional values.</value>
        public virtual string Facility { get; set; }
        /// <summary>
        /// Gets or sets the Forms property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="List{T}"/> of <see cref="FormObject"/> .</value>
        public virtual List<FormObject> Forms { get; set; }
        /// <summary>
        /// Gets or sets the NamespaceName property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the namespace name of the Option in the myAvatar system.</value>
        public virtual string NamespaceName { get; set; }
        /// <summary>
        /// Gets or sets the OptionId property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the unique identifier of the Option in the myAvatar system.</value>
        public virtual string OptionId { get; set; }
        /// <summary>
        /// Gets or sets the OptionStaffId object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the staff Id of the current myAvatar user.</value>
        public virtual string OptionStaffId { get; set; }
        /// <summary>
        /// Gets or sets the OptionUserId object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the user id of the current myAvatar user.</value>
        public virtual string OptionUserId { get; set; }
        /// <summary>
        /// Gets or sets the ParentNamespace object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the Parent Namespace.</value>
        public virtual string ParentNamespace { get; set; }
        /// <summary>
        /// Gets or sets the ServerName object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the Server Name.</value>
        public virtual string ServerName { get; set; }
        /// <summary>
        /// Gets or sets the SystemCode object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the System Code. The value may be SBOX, BLD, UAT, or LIVE.</value>
        public virtual string SystemCode { get; set; }
        /// <summary>
        /// Gets or sets the SessionToken object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the SessionToken.</value>
        public virtual string SessionToken { get; set; }

        //
        // Begin Customizations (only methods and private properties)
        //

        protected int CalculateHashCode(int seed)
        {            
            int hash = seed;
            hash = hash * 23 + EpisodeNumber.GetHashCode();
            hash = hash * 23 + ErrorCode.GetHashCode();
            hash = hash * 23 + (ErrorMesg != null ? ErrorMesg.GetHashCode() : 0);
            hash = hash * 23 + (Facility != null ? Facility.GetHashCode() : 0);
            hash = hash * 23 + (NamespaceName != null ? NamespaceName.GetHashCode() : 0);
            hash = hash * 23 + (OptionId != null ? OptionId.GetHashCode() : 0);
            hash = hash * 23 + (OptionStaffId != null ? OptionStaffId.GetHashCode() : 0);
            hash = hash * 23 + (OptionUserId != null ? OptionUserId.GetHashCode() : 0);
            hash = hash * 23 + (ParentNamespace != null ? ParentNamespace.GetHashCode() : 0);
            hash = hash * 23 + (ServerName != null ? ServerName.GetHashCode() : 0);
            hash = hash * 23 + (SessionToken != null ? SessionToken.GetHashCode() : 0);
            hash = hash * 23 + (SystemCode != null ? SystemCode.GetHashCode() : 0);
            foreach (FormObject formObject in Forms)
            {
                hash = hash * 23 + (formObject != null ? formObject.GetHashCode() : 0);
            }
            return hash;
        }

        protected static bool AreFormsEqual(List<FormObject> list1, List<FormObject> list2)
        {
            if (!AreBothNull(list1, list2) && AreBothEmpty(list1, list2))
                return true;

            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1[i].Equals(list2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        protected static bool AreBothEmpty(List<FormObject> list1, List<FormObject> list2) => list1.Count == 0 && list2.Count == 0;

        protected static bool AreBothNull(List<FormObject> list1, List<FormObject> list2) => list1 == null && list2 == null;

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="formObject"></param>
        public void AddFormObject(FormObject formObject) => Forms = OptionObjectHelpers.AddFormObject(this, formObject).Forms;

        /// <summary>
        /// Adds a <see cref="FormObject"/> to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="multipleIteration"></param>
        public void AddFormObject(string formId, bool multipleIteration) => Forms = OptionObjectHelpers.AddFormObject(this, formId, multipleIteration).Forms;

        /// <summary>
        /// Adds a <see cref="RowObject"/> to a <see cref="FormObject"/> in this <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        public void AddRowObject(string formId, RowObject rowObject) => Forms = OptionObjectHelpers.AddRowObject(this, formId, rowObject).Forms;

        /// <summary>
        /// Clones the <see cref="OptionObjectBase"/>.
        /// </summary>
        /// <returns></returns>
        public virtual OptionObjectBase Clone()
        {
            var optionObject = (OptionObjectBase)MemberwiseClone();
            optionObject.Forms = new List<FormObject>();
            foreach (var form in Forms)
            {
                optionObject.Forms.Add(form.Clone());
            }
            return optionObject;
        }

        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowObject"></param>
        public void DeleteRowObject(RowObject rowObject) => Forms = OptionObjectHelpers.DeleteRowObject(this, rowObject).Forms;

        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion by specified RowId.
        /// </summary>
        /// <param name="rowId"></param>
        public void DeleteRowObject(string rowId) => Forms = OptionObjectHelpers.DeleteRowObject(this, rowId).Forms;

        /// <summary>
        /// Sets all <see cref="FieldObject"/> as disabled.
        /// </summary>
        public void DisableAllFieldObjects() => Forms = OptionObjectHelpers.DisableAllFieldObjects(this).Forms;

        /// <summary>
        /// Sets all <see cref="FieldObject"/> as disabled except for any listed to be excluded.
        /// </summary>
        /// <param name="excludedFieldObjects"></param>
        public void DisableAllFieldObjects(List<string> excludedFieldObjects) => Forms = OptionObjectHelpers.DisableAllFieldObjects(this, excludedFieldObjects).Forms;

        /// <summary>
        /// Returns the CurrentRow RowId of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetCurrentRowId(string formId) => OptionObjectHelpers.GetCurrentRowId(this, formId);

        /// <summary>
        /// Returns the first value of the field matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber) => OptionObjectHelpers.GetFieldValue(this, fieldNumber);

        /// <summary>
        /// Returns the value of the <see cref="FieldObject"/> matching the Field Number on the specified <see cref="FormObject"/> and <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string formId, string rowId, string fieldNumber) => OptionObjectHelpers.GetFieldValue(this, formId, rowId, fieldNumber);

        /// <summary>
        /// Returns the values of the field matching the Field Number.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public List<string> GetFieldValues(string fieldNumber) => OptionObjectHelpers.GetFieldValues(this, fieldNumber);

        /// <summary>
        /// Returns the Multiple Iteration Status of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool GetMultipleIterationStatus(string formId) => OptionObjectHelpers.GetMultipleIterationStatus(this, formId);

        /// <summary>
        /// Returns the CurrentRow ParentRowId of the form matching the FormId.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public string GetParentRowId(string formId) => OptionObjectHelpers.GetParentRowId(this, formId);

        /// <summary>
        /// Returns whether the specified field is enabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber) => OptionObjectHelpers.IsFieldEnabled(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldLocked(string fieldNumber) => OptionObjectHelpers.IsFieldLocked(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is modified.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldModified(string fieldNumber) => OptionObjectHelpers.IsFieldModified(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is present.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => OptionObjectHelpers.IsFieldPresent(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified field is required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldRequired(string fieldNumber) => OptionObjectHelpers.IsFieldRequired(this, fieldNumber);

        /// <summary>
        /// Returns whether the specified <see cref="FormObject"/> is present.
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public bool IsFormPresent(string formId) => OptionObjectHelpers.IsFormPresent(this, formId);

        /// <summary>
        /// Returns whether the specified <see cref="RowObject"/> is marked for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public bool IsRowMarkedForDeletion(string rowId) => OptionObjectHelpers.IsRowMarkedForDeletion(this, rowId);

        /// <summary>
        /// Returns whether the specified <see cref="RowObject"/> is present.
        /// </summary>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public bool IsRowPresent(string rowId) => OptionObjectHelpers.IsRowPresent(this, rowId);

        /// <summary>
        /// Sets the specified field as disabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetDisabledField(string fieldNumber) => Forms = OptionObjectHelpers.SetDisabledField(this, fieldNumber).Forms;

        /// <summary>
        /// Sets the specified fields as disabled.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetDisabledFields(List<string> fieldNumbers) => Forms = OptionObjectHelpers.SetDisabledFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Set the specified field as enabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetEnabledField(string fieldNumber) => Forms = OptionObjectHelpers.SetEnabledField(this, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as enabled.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetEnabledFields(List<string> fieldNumbers) => Forms = OptionObjectHelpers.SetEnabledFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject"/> on the first form CurrentRow.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string fieldNumber, string fieldValue) => Forms = OptionObjectHelpers.SetFieldValue(this, fieldNumber, fieldValue).Forms;

        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject2015"/> 
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string formId, string rowId, string fieldNumber, string fieldValue) => Forms = OptionObjectHelpers.SetFieldValue(this, formId, rowId, fieldNumber, fieldValue).Forms;

        /// <summary>
        /// Set the specified field as locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetLockedField(string fieldNumber) => Forms = OptionObjectHelpers.SetLockedField(this, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as locked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetLockedFields(List<string> fieldNumbers) => Forms = OptionObjectHelpers.SetLockedFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Set the specified field as not required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetOptionalField(string fieldNumber) => Forms = OptionObjectHelpers.SetOptionalField(this, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as not required and enables if disabled.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetOptionalFields(List<string> fieldNumbers) => Forms = OptionObjectHelpers.SetOptionalFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Sets the specified field as required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetRequiredField(string fieldNumber) => Forms = OptionObjectHelpers.SetRequiredField(this, fieldNumber).Forms;

        /// <summary>
        /// Sets the specified fields as required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetRequiredFields(List<string> fieldNumbers) => Forms = OptionObjectHelpers.SetRequiredFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Set the specified field as unlocked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetUnlockedField(string fieldNumber) => Forms = OptionObjectHelpers.SetUnlockedField(this, fieldNumber).Forms;

        /// <summary>
        /// Set the specified fields as unlocked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetUnlockedFields(List<string> fieldNumbers) => Forms = OptionObjectHelpers.SetUnlockedFields(this, fieldNumbers).Forms;

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.</returns>
        public virtual string ToHtmlString() => OptionObjectHelpers.TransformToHtmlString(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.</returns>
        public virtual string ToHtmlString(bool includeHtmlHeaders) => OptionObjectHelpers.TransformToHtmlString(this, includeHtmlHeaders);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted as JSON.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted as JSON.</returns>
        public string ToJson() => OptionObjectHelpers.TransformToJson(this);

        /// <summary>
        /// Transforms the <see cref="OptionObjectBase"/>  to an <see cref="OptionObject"/>.
        /// </summary>
        /// <returns></returns>
        public abstract OptionObject ToOptionObject();

        /// <summary>
        /// Transforms the <see cref="OptionObjectBase"/>  to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public abstract OptionObject2 ToOptionObject2();

        /// <summary>
        /// Transforms the <see cref="OptionObjectBase"/>  to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public abstract OptionObject2015 ToOptionObject2015();

        /// <summary>
        /// Creates an <see cref="OptionObjectBase"/> with the minimal information required to return.
        /// </summary>
        /// <returns></returns>
        public virtual OptionObjectBase ToReturnOptionObject()
        {
            throw new NotImplementedException(ScriptLinkHelpers.GetLocalizedString("methodCannotBeInherited", CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Creates an <see cref="OptionObjectBase"/> with the minimal information required to return plus the provide Error Code and Message.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public virtual OptionObjectBase ToReturnOptionObject(double errorCode, string errorMessage)
        {
            throw new NotImplementedException(ScriptLinkHelpers.GetLocalizedString("methodCannotBeInherited", CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObjectBase"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObjectBase"/> formatted as XML.</returns>
        public virtual string ToXml() => OptionObjectHelpers.TransformToXml(this);
    }
}
