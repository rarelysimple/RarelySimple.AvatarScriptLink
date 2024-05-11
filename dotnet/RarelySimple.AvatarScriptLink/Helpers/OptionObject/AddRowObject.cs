using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a specified <see cref="FormObject"/> within provided <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IOptionObject AddRowObject(IOptionObject optionObject, string formId, IRowObject rowObject)
        {
            if (optionObject == null)
                throw new System.ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(formId))
                throw new System.ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (rowObject == null)
                throw new System.ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (IsFormPresent(optionObject, formId))
            {
                for (int i = 0; i < optionObject.Forms.Count; i++)
                {
                    if (optionObject.Forms[i].FormId == formId)
                    {
                        optionObject.Forms[i] = (FormObject)AddRowObject(optionObject.Forms[i], rowObject);
                        break;
                    }
                }
            }
            return optionObject;
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a provided <see cref="IFormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowObject"></param>
        /// <returns></returns>
        public static IFormObject AddRowObject(IFormObject formObject, IRowObject rowObject)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (!formObject.MultipleIteration && formObject.CurrentRow != null)
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("cannotAddAnotherRowObject", CultureInfo.CurrentCulture));
            
            if ((formObject.CurrentRow != null && formObject.CurrentRow.RowId == rowObject.RowId && !string.IsNullOrEmpty(rowObject.RowId) ||
                (formObject.OtherRows != null && formObject.OtherRows.Exists(r => r.RowId == rowObject.RowId && string.IsNullOrEmpty(rowObject.RowId)))))
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("rowIdAlreadyExists", CultureInfo.CurrentCulture));

            if (formObject.CurrentRow == null)
            {
                rowObject.RowId = GetNextAvailableRowId(formObject);
                formObject.CurrentRow = (RowObject)rowObject;
            }
            else
            {
                if (string.IsNullOrEmpty(rowObject.RowId))
                    rowObject.RowId = GetNextAvailableRowId(formObject);
                formObject.OtherRows.Add((RowObject)rowObject);
            }
            return formObject;
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a provided <see cref="IFormObject"/> using provided RowId and ParentRowId.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        /// <returns></returns>
        public static IFormObject AddRowObject(IFormObject formObject, string rowId, string parentRowId)
        {
            if (formObject == null)
                throw new System.ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return AddRowObject(formObject, rowId, parentRowId, RowAction.Add);
        }
        /// <summary>
        /// Adds a <see cref="RowObject"/> to a provided <see cref="IFormObject"/> using provided RowId, ParentRowId, and RowAction.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        /// <returns></returns>
        public static IFormObject AddRowObject(IFormObject formObject, string rowId, string parentRowId, string rowAction)
        {
            if (formObject == null)
                throw new System.ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            RowObject rowObject = new RowObject
            {
                ParentRowId = parentRowId,
                RowAction = rowAction,
                RowId = rowId
            };
            return AddRowObject(formObject, rowObject);
        }
    }
}
