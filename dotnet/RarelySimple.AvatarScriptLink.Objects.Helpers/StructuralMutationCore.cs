using System;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Helpers
{
    internal static class StructuralMutationMessages
    {
        internal const string FormIdCannotBeNullOrEmpty = "FormId cannot be null or empty.";
        internal const string RowIdCannotBeNullOrEmpty = "RowId cannot be null or empty.";
        internal const string FormsCollectionCannotBeNull = "Forms collection cannot be null.";
        internal const string NoMatchingFormForFormId = "No matching form was found for the provided formId.";
        internal const string NoMatchingRowForRowId = "No matching row was found for the provided rowId.";
    }

    internal static class StructuralMutationCore
    {
        internal static FormObject GetFormObjectOrThrow(List<FormObject> forms, string formId)
        {
            if (forms == null)
            {
                throw new ArgumentNullException(nameof(forms));
            }

            var formObject = forms.Find(f => f != null && f.FormId == formId) ?? throw new ArgumentException(StructuralMutationMessages.NoMatchingFormForFormId, nameof(formId));
            return formObject;
        }

        internal static void AddRowObject(List<FormObject> forms, string formId, RowObject rowObject)
        {
            if (forms == null)
            {
                throw new ArgumentNullException(nameof(forms));
            }

            var formIndex = forms.FindIndex(f => f != null && f.FormId == formId);
            if (formIndex >= 0)
            {
                forms[formIndex].AddRowObject(rowObject);
                return;
            }

            throw new ArgumentException(StructuralMutationMessages.NoMatchingFormForFormId, nameof(formId));
        }

        internal static void DeleteRowObject(List<FormObject> forms, string rowId)
        {
            if (forms == null)
            {
                throw new ArgumentNullException(nameof(forms));
            }

            var formIndex = forms.FindIndex(f => f != null && f.IsRowPresent(rowId));
            if (formIndex >= 0)
            {
                forms[formIndex].DeleteRowObject(rowId);
                return;
            }

            throw new ArgumentException(StructuralMutationMessages.NoMatchingRowForRowId, nameof(rowId));
        }
    }
}