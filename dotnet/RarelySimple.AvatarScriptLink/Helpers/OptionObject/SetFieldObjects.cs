using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IOptionObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldObjects"></param>
        /// <returns></returns>
        public static IOptionObject SetFieldObjects(IOptionObject optionObject, string fieldAction, List<FieldObject> fieldObjects)
        {
            List<string> fieldNumbers = GetFieldNumbersToSet(fieldObjects);
            return SetFieldObjects(optionObject, fieldAction, fieldNumbers);
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IOptionObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IOptionObject SetFieldObjects(IOptionObject optionObject, string fieldAction, List<string> fieldNumbers)
        {
            if (string.IsNullOrEmpty(fieldAction))
                throw new ArgumentNullException(nameof(fieldAction), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

            List<string> fieldsToSet = new List<string>();
            foreach (string fieldNumber in fieldNumbers.Where(f => IsFieldPresent(optionObject, f)))
            {
                fieldsToSet.Add(fieldNumber);
            }
            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFound", CultureInfo.CurrentCulture));

            int formErrors = 0;
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                try
                {
                    optionObject.Forms[i] = (FormObject)SetFieldObjects(optionObject.Forms[i], fieldAction, fieldsToSet);
                }
                catch
                {
                    // The FieldObjects to set may not be present on each FormObject
                    formErrors++;
                }
            }
            if (formErrors == optionObject.Forms.Count)
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsWereSet", CultureInfo.CurrentCulture));

            return optionObject;
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IFormObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IFormObject SetFieldObjects(IFormObject formObject, string fieldAction, List<string> fieldNumbers)
        {
            if (string.IsNullOrEmpty(fieldAction))
                throw new ArgumentNullException(nameof(fieldAction), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

            List<string> fieldsToSet = new List<string>();
            foreach (string fieldNumber in fieldNumbers.Where(f => IsFieldPresent(formObject, f)))
            {
                fieldsToSet.Add(fieldNumber);
            }
            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFound", CultureInfo.CurrentCulture));

            formObject.CurrentRow = (RowObject)SetFieldObjects(formObject.CurrentRow, fieldAction, fieldsToSet);

            if (formObject.MultipleIteration)
            {
                for (int i = 0; i < formObject.OtherRows.Count; i++)
                {
                    formObject.OtherRows[i] = (RowObject)SetFieldObjects(formObject.OtherRows[i], fieldAction, fieldsToSet);
                }
            }
            return formObject;
        }
        /// <summary>
        /// Sets <see cref="FieldObject"/> in an <see cref="IRowObject"/> according to specified FieldAction.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldAction"></param>
        /// <param name="fieldNumbers"></param>
        /// <returns></returns>
        public static IRowObject SetFieldObjects(IRowObject rowObject, string fieldAction, List<string> fieldNumbers)
        {
            if (string.IsNullOrEmpty(fieldAction))
                throw new ArgumentNullException(nameof(fieldAction), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

            List<string> fieldsToSet = new List<string>();
            foreach (string fieldNumber in fieldNumbers.Where(f => IsFieldPresent(rowObject, f)))
            {
                fieldsToSet.Add(fieldNumber);
            }
            if (fieldsToSet.Count == 0)
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFound", CultureInfo.CurrentCulture));

            foreach (var fieldObject in rowObject.Fields.Where(f => fieldsToSet.Contains(f.FieldNumber)))
            {
                switch (fieldAction)
                {
                    case FieldAction.Disable:
                        fieldObject.SetAsDisabled();
                        rowObject.RowAction = RowAction.Edit;
                        break;
                    case FieldAction.Enable:
                        fieldObject.SetAsEnabled();
                        rowObject.RowAction = RowAction.Edit;
                        break;
                    case FieldAction.Lock:
                        fieldObject.SetAsLocked();
                        rowObject.RowAction = RowAction.Edit;
                        break;
                    case FieldAction.Modify:
                        fieldObject.SetAsModified();
                        rowObject.RowAction = RowAction.Edit;
                        break;
                    case FieldAction.Optional:
                        fieldObject.SetAsOptional();
                        rowObject.RowAction = RowAction.Edit;
                        break;
                    case FieldAction.Require:
                        fieldObject.SetAsRequired();
                        rowObject.RowAction = RowAction.Edit;
                        break;
                    case FieldAction.Unlock:
                        fieldObject.SetAsUnlocked();
                        rowObject.RowAction = RowAction.Edit;
                        break;
                    default:
                        break;
                }
            }
            return rowObject;
        }

        #region HelperMethods
        private static List<string> GetFieldNumbersToSet(List<FieldObject> fieldObjects)
        {
            List<string> fieldNumbers = new List<string>();
            foreach (var fieldObject in fieldObjects)
            {
                fieldNumbers.Add(fieldObject.FieldNumber);
            }
            return fieldNumbers;
        }
        #endregion
    }
}
