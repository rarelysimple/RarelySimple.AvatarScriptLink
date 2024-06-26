﻿using RarelySimple.AvatarScriptLink.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public abstract class RowObjectBase : IRowObject
    {
        protected const string ParameterCannotBeNull = "parameterCannotBeNull";
        
        #region Constructors

        /// <summary>
        /// Creates a new <see cref="RowObject"/>. 
        /// </summary>
        protected RowObjectBase()
        {
            Fields = new List<FieldObject>();
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/>.
        /// </summary>
        /// <param name="rowId"></param>
        protected RowObjectBase(string rowId)
        {
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            RowAction = "";
            ParentRowId = "";
            RowId = rowId;
            Fields = new List<FieldObject>();
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="ParentRowId"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        protected RowObjectBase(string rowId, string parentRowId)
        {
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(parentRowId))
                throw new ArgumentNullException(nameof(parentRowId));
            RowAction = "";
            ParentRowId = parentRowId;
            RowId = rowId;
            Fields = new List<FieldObject>();
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/>, <see cref="ParentRowId"/>, and <see cref="RowAction"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        protected RowObjectBase(string rowId, string parentRowId, string rowAction)
        {
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(parentRowId))
                throw new ArgumentNullException(nameof(parentRowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (!OptionObjectHelpers.IsValidRowAction(rowAction))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("parameterIsNotValid", CultureInfo.CurrentCulture), nameof(rowAction));
            RowAction = rowAction;
            ParentRowId = parentRowId;
            RowId = rowId;
            Fields = new List<FieldObject>();
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        protected RowObjectBase(string rowId, List<FieldObject> fieldObjects)
        {
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            RowAction = "";
            ParentRowId = "";
            RowId = rowId;
            Fields = fieldObjects ?? throw new ArgumentNullException(nameof(fieldObjects), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        /// <param name="parentRowId"></param>
        protected RowObjectBase(string rowId, List<FieldObject> fieldObjects, string parentRowId)
        {
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(parentRowId))
                throw new ArgumentNullException(nameof(parentRowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            RowAction = "";
            ParentRowId = parentRowId;
            RowId = rowId;
            Fields = fieldObjects ?? throw new ArgumentNullException(nameof(fieldObjects), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
        }
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        protected RowObjectBase(string rowId, List<FieldObject> fieldObjects, string parentRowId, string rowAction)
        {
            if (string.IsNullOrEmpty(rowId))
                throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(parentRowId))
                throw new ArgumentNullException(nameof(parentRowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (!OptionObjectHelpers.IsValidRowAction(rowAction))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("parameterIsNotValid", CultureInfo.CurrentCulture), nameof(rowAction));
            RowAction = rowAction;
            ParentRowId = parentRowId;
            RowId = rowId;
            Fields = fieldObjects ?? throw new ArgumentNullException(nameof(fieldObjects), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
        }

        #endregion
        
        //
        // Public Properties (DO NOT MODIFY)
        //

        /// <summary>
        /// Gets or sets the Fields property of the <see cref="RowObject"/> 
        /// </summary>
        /// <value>This value is a <see cref="List{T}"/> of <see cref="FieldObject"/>.</value>
        public List<FieldObject> Fields { get; set; }
        /// <summary>
        /// Gets or sets the ParentRowId property of the <see cref="RowObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and references the <see cref="RowId"/> of the <see cref="FormObject.CurrentRow"/> of the enclosing <see cref="FormObject"/>.</value>
        public string ParentRowId { get; set; }
        /// <summary>
        /// Gets or sets the RowAction property of the <see cref="RowObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> containing ADD, EDIT, or DELETE. Other values are invalid.</value>
        public string RowAction { get; set; }
        /// <summary>
        /// Gets or sets the RowId property of the <see cref="RowObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> containing the unique Id for the row.</value>
        public string RowId { get; set; }

        //
        // Begin Customizations (only methods and private properties)
        //

        /// <summary>
        /// Adds a <see cref="FieldObject"/> to a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldObject"></param>
        public void AddFieldObject(FieldObject fieldObject) => Fields = OptionObjectHelpers.AddFieldObject(this, fieldObject).Fields;

        /// <summary>
        /// Adds a <see cref="FieldObject"/> to a <see cref="RowObject"/> with the provided <see cref="FieldObject.FieldNumber"/> and <see cref="FieldObject.FieldValue"/>.
        /// </summary>
        /// <param name="fieldNumber">A <see cref="string"/> containing the <see cref="FieldObject.FieldNumber"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="fieldValue">A <see cref="string"/> containing the <see cref="FieldObject.FieldValue"/> of the <see cref="FieldObject"/>.</param>
        public void AddFieldObject(string fieldNumber, string fieldValue) => Fields = OptionObjectHelpers.AddFieldObject(this, fieldNumber, fieldValue).Fields;

        /// <summary>
        /// Adds a <see cref="FieldObject"/> to a <see cref="RowObject"/> with the provided property values.
        /// </summary>
        /// <param name="fieldNumber">A <see cref="string"/> containing the <see cref="FieldObject.FieldNumber"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="fieldValue">A <see cref="string"/> containing the <see cref="FieldObject.FieldValue"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="enabledValue">A <see cref="string"/> containing the <see cref="FieldObject.Enabled"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="lockedValue">A <see cref="string"/> containing the <see cref="FieldObject.Lock"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="requiredValue">A <see cref="string"/> containing the <see cref="FieldObject.Required"/> of the <see cref="FieldObject"/>.</param>
        public void AddFieldObject(string fieldNumber, string fieldValue, string enabledValue, string lockedValue, string requiredValue) => Fields = OptionObjectHelpers.AddFieldObject(this, fieldNumber, fieldValue, enabledValue, lockedValue, requiredValue).Fields;

        /// <summary>
        /// Adds a <see cref="FieldObject"/> to a <see cref="RowObject"/> with the provided property values.
        /// </summary>
        /// <param name="fieldNumber">A <see cref="string"/> containing the <see cref="FieldObject.FieldNumber"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="fieldValue">A <see cref="string"/> containing the <see cref="FieldObject.FieldValue"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="enabled">A <see cref="bool"/> containing the <see cref="FieldObject.Enabled"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="locked">A <see cref="bool"/> containing the <see cref="FieldObject.Lock"/> of the <see cref="FieldObject"/>.</param>
        /// <param name="required">A <see cref="bool"/> containing the <see cref="FieldObject.Required"/> of the <see cref="FieldObject"/>.</param>
        public void AddFieldObject(string fieldNumber, string fieldValue, bool enabled, bool locked, bool required) => Fields = OptionObjectHelpers.AddFieldObject(this, fieldNumber, fieldValue, enabled, locked, required).Fields;

        /// <summary>
        /// Returns a deep copy of the <see cref="object"/>.
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            var rowObject = (RowObjectBase)MemberwiseClone();
            rowObject.Fields = new List<FieldObject>();
            foreach (var field in Fields)
            {
                rowObject.Fields.Add(field.Clone());
            }
            return rowObject;
        }

        /// <summary>
        /// Returns the value of a <see cref="FieldObject"/> in a <see cref="RowObject"/> 
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber) => OptionObjectHelpers.GetFieldValue(this, fieldNumber);

        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is enabled in the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber) => OptionObjectHelpers.IsFieldEnabled(this, fieldNumber);

        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is locked in the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public bool IsFieldLocked(string fieldNumber) => OptionObjectHelpers.IsFieldLocked(this, fieldNumber);

        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is modified in the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public bool IsFieldModified(string fieldNumber) => OptionObjectHelpers.IsFieldModified(this, fieldNumber);

        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is present in <see cref="RowObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => OptionObjectHelpers.IsFieldPresent(this, fieldNumber);

        /// <summary>
        /// Determines whether a <see cref="FieldObject"/> is required in the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public bool IsFieldRequired(string fieldNumber) => OptionObjectHelpers.IsFieldRequired(this, fieldNumber);

        /// <summary>
        /// Removes a <see cref="FieldObject"/> from a <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldObject">The <see cref="FieldObject"/> to remove.</param>
        public void RemoveFieldObject(FieldObject fieldObject) => Fields = OptionObjectHelpers.RemoveFieldObject(this, fieldObject).Fields;

        /// <summary>
        /// Removes a <see cref="FieldObject"/> from a <see cref="RowObject"/> by <see cref="FieldObject.FieldNumber"/>.
        /// </summary>
        /// <param name="fieldNumber">A <see cref="string"/> containing the <see cref="FieldObject.FieldNumber"/> to remove.</param>
        public void RemoveFieldObject(string fieldNumber) => Fields = OptionObjectHelpers.RemoveFieldObject(this, fieldNumber).Fields;

        /// <summary>
        /// Removes any unmodified <see cref="FieldObject"/> from the <see cref="RowObject"/>.
        /// </summary>
        public void RemoveUnmodifiedFieldObjects() => Fields.RemoveAll(f => f.IsModified());

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetDisabledField(string fieldNumber) => Fields = OptionObjectHelpers.SetDisabledField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetDisabledFields(List<string> fieldNumbers) => Fields = OptionObjectHelpers.SetDisabledFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Sets the specified field as enabled and not required.
        /// <para>This is the equivalent of <see cref="SetOptionalField(string)"/>.</para>
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetEnabledField(string fieldNumber) => Fields = OptionObjectHelpers.SetEnabledField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as enabled and not required.
        /// <para>This is the equivalent of <see cref="SetOptionalFields(List{string})"/>.</para>
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetEnabledFields(List<string> fieldNumbers) => Fields = OptionObjectHelpers.SetEnabledFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in the <see cref="RowObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public void SetFieldValue(string fieldNumber, string fieldValue) => Fields = OptionObjectHelpers.SetFieldValue(this, fieldNumber, fieldValue).Fields;

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetLockedField(string fieldNumber) => Fields = OptionObjectHelpers.SetLockedField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetLockedFields(List<string> fieldNumbers) => Fields = OptionObjectHelpers.SetLockedFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Sets the specified field as enabled and not required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetOptionalField(string fieldNumber) => Fields = OptionObjectHelpers.SetOptionalField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as enabled and not require.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetOptionalFields(List<string> fieldNumbers) => Fields = OptionObjectHelpers.SetOptionalFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetRequiredField(string fieldNumber) => Fields = OptionObjectHelpers.SetRequiredField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetRequiredFields(List<string> fieldNumbers) => Fields = OptionObjectHelpers.SetRequiredFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetUnlockedField(string fieldNumber) => Fields = OptionObjectHelpers.SetUnlockedField(this, fieldNumber).Fields;

        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetUnlockedFields(List<string> fieldNumbers) => Fields = OptionObjectHelpers.SetUnlockedFields(this, fieldNumbers).Fields;

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted in HTML.</returns>
        public string ToHtmlString() => OptionObjectHelpers.TransformToHtmlString(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders) => OptionObjectHelpers.TransformToHtmlString(this, includeHtmlHeaders);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted as JSON.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted as JSON.</returns>
        public string ToJson() => OptionObjectHelpers.TransformToJson(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted as XML.</returns>
        public abstract string ToXml();
    }
}
