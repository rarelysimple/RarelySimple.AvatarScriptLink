using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects.Builders.ResponseBuilders
{
    internal static class ResponseFinalizationHelpers
    {
        internal static void RemoveUneditedRows(List<FormObject> forms)
        {
            if (forms == null)
            {
                return;
            }

            for (int i = forms.Count - 1; i >= 0; i--)
            {
                var formObject = forms[i];
                if (formObject == null)
                {
                    forms.RemoveAt(i);
                    continue;
                }

                RemoveUneditedRows(formObject);

                if (formObject.CurrentRow == null && (formObject.OtherRows == null || formObject.OtherRows.Count == 0))
                {
                    forms.RemoveAt(i);
                }
            }
        }

        internal static void RemoveUneditedRows(List<FormObject> forms, List<FormObject> baselineForms)
        {
            if (forms == null)
            {
                return;
            }

            if (baselineForms == null)
            {
                RemoveUneditedRows(forms);
                return;
            }

            var baselineFieldMap = BuildBaselineFieldMap(baselineForms);

            for (int i = forms.Count - 1; i >= 0; i--)
            {
                var formObject = forms[i];
                if (formObject == null)
                {
                    forms.RemoveAt(i);
                    continue;
                }

                RemoveUneditedRows(formObject, baselineFieldMap);

                if (formObject.CurrentRow == null && (formObject.OtherRows == null || formObject.OtherRows.Count == 0))
                {
                    forms.RemoveAt(i);
                }
            }
        }

        private static void RemoveUneditedRows(FormObject formObject)
        {
            if (formObject.CurrentRow != null && !IsValidRowAction(formObject.CurrentRow.RowAction))
            {
                formObject.CurrentRow = null;
            }

            if (formObject.OtherRows == null)
            {
                formObject.OtherRows = new List<RowObject>();
                return;
            }

            for (int i = formObject.OtherRows.Count - 1; i >= 0; i--)
            {
                var rowObject = formObject.OtherRows[i];
                if (rowObject == null || !IsValidRowAction(rowObject.RowAction))
                {
                    formObject.OtherRows.RemoveAt(i);
                }
            }
        }

        private static void RemoveUneditedRows(FormObject formObject, Dictionary<string, BaselineFieldSnapshot> baselineFieldMap)
        {
            if (ShouldRemoveRow(formObject.FormId, formObject.CurrentRow, baselineFieldMap))
            {
                formObject.CurrentRow = null;
            }

            if (formObject.OtherRows == null)
            {
                formObject.OtherRows = new List<RowObject>();
                return;
            }

            for (int i = formObject.OtherRows.Count - 1; i >= 0; i--)
            {
                var rowObject = formObject.OtherRows[i];
                if (ShouldRemoveRow(formObject.FormId, rowObject, baselineFieldMap))
                {
                    formObject.OtherRows.RemoveAt(i);
                }
            }
        }

        private static bool ShouldRemoveRow(string formId, RowObject rowObject, Dictionary<string, BaselineFieldSnapshot> baselineFieldMap)
        {
            if (rowObject == null || !IsValidRowAction(rowObject.RowAction))
            {
                return true;
            }

            if (rowObject.RowAction != RowObject.RowActions.Edit)
            {
                return false;
            }

            PruneUnchangedFields(formId, rowObject, baselineFieldMap);
            return !rowObject.HasFields();
        }

        private static void PruneUnchangedFields(string formId, RowObject rowObject, Dictionary<string, BaselineFieldSnapshot> baselineFieldMap)
        {
            if (rowObject.Fields == null)
            {
                rowObject.Fields = new List<FieldObject>();
                return;
            }

            for (int i = rowObject.Fields.Count - 1; i >= 0; i--)
            {
                var field = rowObject.Fields[i];
                if (field == null)
                {
                    rowObject.Fields.RemoveAt(i);
                    continue;
                }

                if (!TryCreateFieldKey(formId, rowObject.RowId, field.FieldNumber, out var key))
                {
                    continue;
                }

                if (!baselineFieldMap.TryGetValue(key, out var baselineSnapshot))
                {
                    continue;
                }

                if (IsUnchanged(field, baselineSnapshot))
                {
                    rowObject.Fields.RemoveAt(i);
                }
            }
        }

        private static Dictionary<string, BaselineFieldSnapshot> BuildBaselineFieldMap(List<FormObject> baselineForms)
        {
            var map = new Dictionary<string, BaselineFieldSnapshot>();

            foreach (var form in baselineForms.Where(f => f != null))
            {
                if (form.CurrentRow != null)
                {
                    AddRowToBaselineMap(map, form.FormId, form.CurrentRow);
                }

                if (form.OtherRows != null)
                {
                    foreach (var row in form.OtherRows.Where(r => r != null))
                    {
                        AddRowToBaselineMap(map, form.FormId, row);
                    }
                }
            }

            return map;
        }

        private static void AddRowToBaselineMap(Dictionary<string, BaselineFieldSnapshot> map, string formId, RowObject row)
        {
            if (row.Fields == null)
            {
                return;
            }

            foreach (var field in row.Fields.Where(f => f != null))
            {
                if (!TryCreateFieldKey(formId, row.RowId, field.FieldNumber, out var key))
                {
                    continue;
                }

                map[key] = new BaselineFieldSnapshot(field.FieldValue, field.Enabled, field.Lock, field.Required);
            }
        }

        private static bool TryCreateFieldKey(string formId, string rowId, string fieldNumber, out string key)
        {
            if (string.IsNullOrEmpty(formId) || string.IsNullOrEmpty(rowId) || string.IsNullOrEmpty(fieldNumber))
            {
                key = string.Empty;
                return false;
            }

            key = string.Concat(formId, "|", rowId, "|", fieldNumber);
            return true;
        }

        private static bool IsUnchanged(FieldObject field, BaselineFieldSnapshot baselineSnapshot)
        {
            return string.Equals(field.FieldValue ?? string.Empty, baselineSnapshot.FieldValue, System.StringComparison.Ordinal)
                && string.Equals(field.Enabled ?? string.Empty, baselineSnapshot.Enabled, System.StringComparison.Ordinal)
                && string.Equals(field.Lock ?? string.Empty, baselineSnapshot.Lock, System.StringComparison.Ordinal)
                && string.Equals(field.Required ?? string.Empty, baselineSnapshot.Required, System.StringComparison.Ordinal);
        }

        private static bool IsValidRowAction(string rowAction)
        {
            return rowAction == RowObject.RowActions.Add
                || rowAction == RowObject.RowActions.Edit
                || rowAction == RowObject.RowActions.Delete;
        }

        private sealed class BaselineFieldSnapshot
        {
            internal BaselineFieldSnapshot(string fieldValue, string enabled, string locked, string required)
            {
                FieldValue = fieldValue ?? string.Empty;
                Enabled = enabled ?? string.Empty;
                Lock = locked ?? string.Empty;
                Required = required ?? string.Empty;
            }

            internal string FieldValue { get; }
            internal string Enabled { get; }
            internal string Lock { get; }
            internal string Required { get; }
        }
    }
}
