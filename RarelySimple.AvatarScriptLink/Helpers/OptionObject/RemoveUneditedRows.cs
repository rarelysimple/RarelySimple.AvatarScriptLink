using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        public static IOptionObject RemoveUneditedRows(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));

            List<FormObject> formsToRemove = new List<FormObject>();
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                optionObject.Forms[i] = (FormObject)RemoveUneditedRows(optionObject.Forms[i]);
                if (optionObject.Forms[i].CurrentRow == null && optionObject.Forms[i].OtherRows.Count == 0)
                    formsToRemove.Add(optionObject.Forms[i]);
                else if (optionObject.Forms[i].OtherRows.Count == 0)
                    optionObject.Forms[i].OtherRows = null;
            }
            foreach (var formObject in formsToRemove)
            {
                optionObject.Forms.Remove(formObject);
            }

            return optionObject;
        }

        public static IFormObject RemoveUneditedRows(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));

            // CurrentRow
            if (formObject.CurrentRow != null &&
                (formObject.CurrentRow.RowAction == null ||
                string.IsNullOrEmpty(formObject.CurrentRow.RowAction) ||
                !IsValidRowAction(formObject.CurrentRow.RowAction)))
            {
                formObject.CurrentRow = null;
            }
            else if (formObject.CurrentRow != null && formObject.CurrentRow.RowAction == RowAction.Edit)
            {
                formObject.CurrentRow.Fields.RemoveAll(p => !p.Modified);
            }

            // OtherRows
            List<RowObject> rowsToRemove = new List<RowObject>();
            foreach (var rowObject in formObject.OtherRows)
            {
                if (rowObject.RowAction == null ||
                    string.IsNullOrEmpty(rowObject.RowAction) ||
                    !IsValidRowAction(rowObject.RowAction))
                {
                    rowsToRemove.Add(rowObject);
                }
                else if (rowObject.RowAction == RowAction.Edit)
                {
                    rowObject.Fields.RemoveAll(p => !p.Modified);
                }
            }
            foreach (var rowObject in rowsToRemove)
            {
                formObject.OtherRows.Remove(rowObject);
            }
            return formObject;
        }
    }
}
