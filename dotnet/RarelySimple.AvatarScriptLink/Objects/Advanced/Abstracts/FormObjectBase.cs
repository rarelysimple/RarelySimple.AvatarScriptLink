using RarelySimple.AvatarScriptLink.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public abstract class FormObjectBase : IEquatable<FormObjectBase>, IFormObject
    {
        protected const string ParameterCannotBeNull = "parameterCannotBeNull";
        
        #region Constructors

        /// <summary>
        /// Creates a new ScriptLink <see cref="FormObject"/>.
        /// </summary>
        protected FormObjectBase()
        {
            OtherRows = new List<RowObject>();
        }

        protected FormObjectBase(string formId)
        {
            if (string.IsNullOrEmpty(formId))
                throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            CurrentRow = null;
            FormId = formId;
            MultipleIteration = false;
            OtherRows = new List<RowObject>();
        }

        protected FormObjectBase(string formId, RowObject currentRow)
        {
            if (string.IsNullOrEmpty(formId))
                throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            CurrentRow = currentRow ?? throw new ArgumentNullException(nameof(currentRow), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            FormId = formId;
            MultipleIteration = false;
            OtherRows = new List<RowObject>();
        }

        protected FormObjectBase(string formId, RowObject currentRow, bool multipleIteration)
        {
            if (string.IsNullOrEmpty(formId))
                throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            CurrentRow = currentRow ?? throw new ArgumentNullException(nameof(currentRow), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            FormId = formId;
            MultipleIteration = multipleIteration;
            OtherRows = new List<RowObject>();
        }

        protected FormObjectBase(string formId, RowObject currentRow, bool multipleIteration, List<RowObject> otherRows)
        {
            if (string.IsNullOrEmpty(formId))
                throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            CurrentRow = currentRow ?? throw new ArgumentNullException(nameof(currentRow), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            FormId = formId;
            MultipleIteration = multipleIteration;
            OtherRows = otherRows ?? throw new ArgumentNullException(nameof(otherRows), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
        }

        #endregion

        //
        // Public Properties (DO NOT MODIFY)
        //

        /// <summary>
        /// Gets or sets the CurrentRow property of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="RowObject"/> containing the current row.</value>
        public RowObject CurrentRow { get; set; }
        /// <summary>
        /// Gets or sets the FormId propery of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>.</value>
        public string FormId { get; set; }
        /// <summary>
        /// Gets or sets the MultipleIteration property of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="bool"/> indicating whether the Option includes a multiple iteration table.</value>
        public bool MultipleIteration { get; set; }
        /// <summary>
        /// Gets or sets the OtherRows property of the <see cref="FormObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="List{T}"/> of <see cref="RowObject"/> containing all of the rows of a multiple iteration table.</value>
        public List<RowObject> OtherRows { get; set; }

        //
        // Begin Customizations (only methods and private properties)
        //

        //
        // Constructor
        //

        

        //
        // Private Properties
        //

        //
        // IEquatable<FormObject> Methods
        //

        /// <summary>
        /// Used to compare two <see cref="FormObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="CustomFormObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="FormObject"/> are equal.</returns>
        public bool Equals(FormObjectBase other)
        {
            if (other == null)
                return false;
            return FormId == other.FormId &&
                   MultipleIteration == other.MultipleIteration &&
                   CurrentRow == other.CurrentRow &&
                   AreRowsEqual(OtherRows, other.OtherRows);
        }

        /// <summary>
        /// Used to compare <see cref="FormObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="FormObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            FormObject formObject = obj as FormObject;
            if (formObject == null)
                return false;
            return Equals(formObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="FormObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="FormObject"/>.</returns>
        public override int GetHashCode()
        {
            string delimiter = "||";
            StringBuilder sb = new StringBuilder();
            sb.Append(FormId + delimiter + MultipleIteration.ToString(CultureInfo.InvariantCulture));
            sb.Append(CurrentRow != null ? delimiter + CurrentRow.GetHashCode().ToString(CultureInfo.InvariantCulture) : "");
            if (OtherRows != null)
            {
                foreach (RowObject rowObject in OtherRows)
                {
                    sb.Append(delimiter + rowObject.GetHashCode());
                }
            }
            return sb.GetHashCode();
        }

        private static bool AreRowsEqual(List<RowObject> list1, List<RowObject> list2)
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

        private static bool AreBothEmpty(List<RowObject> list1, List<RowObject> list2) => (!list1.Any() && !list2.Any());

        private static bool AreBothNull(List<RowObject> list1, List<RowObject> list2) => (list1 == null && list2 == null);

        public static bool operator ==(FormObjectBase formObject1, FormObjectBase formObject2)
        {
            if (((object)formObject1) == null || ((object)formObject2) == null)
                return Object.Equals(formObject1, formObject2);

            return formObject1.Equals(formObject2);
        }

        public static bool operator !=(FormObjectBase formObject1, FormObjectBase formObject2)
        {
            if (((object)formObject1) == null || ((object)formObject2) == null)
                return !Object.Equals(formObject1, formObject2);

            return !(formObject1.Equals(formObject2));
        }

        //
        // IFormObject Methods
        //

        /// <summary>
        /// Adds a <see cref="RowObject"/> to a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="rowObject"></param>
        public void AddRowObject(RowObject rowObject)
        {
            if (rowObject == null)
                return;
            IFormObject tempFormObject = OptionObjectHelpers.AddRowObject(this, rowObject);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to the <see cref="CurrentRow"/> of a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        public void AddRowObject(string rowId, string parentRowId)
        {
            IFormObject tempFormObject = OptionObjectHelpers.AddRowObject(this, rowId, parentRowId);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        public void AddRowObject(string rowId, string parentRowId, string rowAction)
        {
            IFormObject tempFormObject = OptionObjectHelpers.AddRowObject(this, rowId, parentRowId, rowAction);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }

        /// <summary>
        /// Returns a deep copy of the <see cref="FormObjectBase"/>.
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            var formObject = (FormObjectBase)MemberwiseClone();
            formObject.CurrentRow = CurrentRow.Clone();
            formObject.OtherRows = new List<RowObject>();
            foreach (var row in OtherRows)
            {
                formObject.OtherRows.Add(row.Clone());
            }
            return formObject;
        }

        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        public void DeleteRowObject(RowObject rowObject)
        {
            IFormObject tempFormObject = OptionObjectHelpers.DeleteRowObject(this, rowObject);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Marks a <see cref="RowObject"/> for deletion.
        /// </summary>
        /// <param name="rowId"></param>
        public void DeleteRowObject(string rowId)
        {
            IFormObject tempFormObject = OptionObjectHelpers.DeleteRowObject(this, rowId);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }

        /// <summary>
        /// Returns the RowId of the <see cref="CurrentRow"/>.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentRowId() => OptionObjectHelpers.GetCurrentRowId(this);

        /// <summary>
        /// Returns the value of the <see cref="FieldObject"/> in the CurrentRow of the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string fieldNumber) => OptionObjectHelpers.GetFieldValue(this, fieldNumber);

        /// <summary>
        /// Returns the value of the <see cref="FieldObject"/> in the <see cref="RowObject"/> of the <see cref="FormObject"/> by RowId and FieldNumber.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public string GetFieldValue(string rowId, string fieldNumber) => OptionObjectHelpers.GetFieldValue(this, rowId, fieldNumber);

        /// <summary>
        /// Returns a <see cref="List{T}"/> of FieldValues in a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public List<string> GetFieldValues(string fieldNumber) => OptionObjectHelpers.GetFieldValues(this, fieldNumber);

        /// <summary>
        /// Returns the next available RowId of the <see cref="FormObject"/>.
        /// </summary>
        /// <returns></returns>
        public string GetNextAvailableRowId() => OptionObjectHelpers.GetNextAvailableRowId(this);

        /// <summary>
        /// Returns the ParentRowId of the <see cref="CurrentRow"/>.
        /// </summary>
        /// <returns></returns>
        public string GetParentRowId() => OptionObjectHelpers.GetParentRowId(this);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is enabled in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldEnabled(string fieldNumber) => OptionObjectHelpers.IsFieldEnabled(this, fieldNumber);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is locked in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldLocked(string fieldNumber) => OptionObjectHelpers.IsFieldLocked(this, fieldNumber);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is modified in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldModified(string fieldNumber) => OptionObjectHelpers.IsFieldModified(this, fieldNumber);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is present in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldNumber) => OptionObjectHelpers.IsFieldPresent(this, fieldNumber);

        /// <summary>
        /// Determines whether the <see cref="FieldObject"/> is required in the <see cref="FormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsFieldRequired(string fieldNumber) => OptionObjectHelpers.IsFieldRequired(this, fieldNumber);

        /// <summary>
        /// Determines whether the <see cref="RowObject"/> is marked for deletion in the <see cref="FormObject"/> by RowId.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsRowMarkedForDeletion(string rowId) => OptionObjectHelpers.IsRowMarkedForDeletion(this, rowId);

        /// <summary>
        /// Determines whether the <see cref="RowObject"/> is present in the <see cref="FormObject"/> by RowId.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public bool IsRowPresent(string rowId) => OptionObjectHelpers.IsRowPresent(this, rowId);

        /// <summary>
        /// Sets the specified field as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetDisabledField(string fieldNumber)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetDisabledField(this, fieldNumber);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as disabled and unrequires if required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetDisabledFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetDisabledFields(this, fieldNumbers);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified field as enabled and not required.
        /// <para>This is the equivalent of <see cref="SetOptionalField(string)"/>.</para>
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetEnabledField(string fieldNumber)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetEnabledField(this, fieldNumber);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as enabled and not required.
        /// <para>This is the equivalent of <see cref="SetOptionalFields(List{string})"/>.</para>
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetEnabledFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetEnabledFields(this, fieldNumbers);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in the <see cref="CurrentRow"/> of a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string fieldNumber, string fieldValue)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetFieldValue(this, fieldNumber, fieldValue);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the value of a <see cref="FieldObject"/> in a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public void SetFieldValue(string rowId, string fieldNumber, string fieldValue)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetFieldValue(this, rowId, fieldNumber, fieldValue);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified field as locked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetLockedField(string fieldNumber)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetLockedField(this, fieldNumber);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as locked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetLockedFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetLockedFields(this, fieldNumbers);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified field as enabled and not required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetOptionalField(string fieldNumber)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetOptionalField(this, fieldNumber);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as enabled and not required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetOptionalFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetOptionalFields(this, fieldNumbers);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified field as enabled and required.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetRequiredField(string fieldNumber)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetRequiredField(this, fieldNumber);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as enabled and required.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetRequiredFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetRequiredFields(this, fieldNumbers);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified field as unlocked.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public void SetUnlockedField(string fieldNumber)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetUnlockedField(this, fieldNumber);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }
        /// <summary>
        /// Sets the specified fields as unlocked.
        /// </summary>
        /// <param name="fieldNumbers"></param>
        public void SetUnlockedFields(List<string> fieldNumbers)
        {
            IFormObject tempFormObject = OptionObjectHelpers.SetUnlockedFields(this, fieldNumbers);
            CurrentRow = tempFormObject.CurrentRow;
            OtherRows = tempFormObject.OtherRows;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FormObject"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FormObject"/> formatted in HTML.</returns>
        public string ToHtmlString() => OptionObjectHelpers.TransformToHtmlString(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FormObject"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FormObject"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders) => OptionObjectHelpers.TransformToHtmlString(this, includeHtmlHeaders);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FormObject"/> formatted as JSON.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FormObject"/> formatted as JSON.</returns>
        public string ToJson() => OptionObjectHelpers.TransformToJson(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FormObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FormObject"/> formatted as XML.</returns>
        public abstract string ToXml();
    }
}
