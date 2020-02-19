using System;
using System.Collections.Generic;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public interface IOptionObjectDecorator
    {
        string EntityID { get; }
        double EpisodeNumber { get; }
        double ErrorCode { get; }
        string ErrorMesg { get; }
        string Facility { get; }
        List<FormObject> Forms { get; }
        string NamespaceName { get; }
        string OptionId { get; }
        string OptionStaffId { get; }
        string OptionUserId { get; }
        string ParentNamespace { get; }
        string ServerName { get; }
        string SystemCode { get; }
        string SessionToken { get; }

        void AddFormObject(FormObject formObject);
        void AddFormObject(string formId, bool multipleIteration);
        void AddRowObject(string formId, RowObject rowObject);
        OptionObjectBase Clone();
        void DeleteRowObject(RowObject rowObject);
        void DeleteRowObject(string rowId);
        void DisableAllFieldObjects();
        void DisableAllFieldObjects(List<string> excludedFieldObjects);
        string GetCurrentRowId(string formId);
        string GetFieldValue(string fieldNumber);
        string GetFieldValue(string formId, string rowId, string fieldNumber);
        List<string> GetFieldValues(string fieldNumber);
        bool GetMultipleIterationStatus(string formId);
        string GetParentRowId(string formId);
        bool IsFieldEnabled(string fieldNumber);
        bool IsFieldLocked(string fieldNumber);
        bool IsFieldModified(string fieldNumber);
        bool IsFieldPresent(string fieldNumber);
        bool IsFieldRequired(string fieldNumber);
        bool IsFormPresent(string formId);
        bool IsRowMarkedForDeletion(string rowId);
        bool IsRowPresent(string rowId);
        void SetDisabledField(string fieldNumber);
        void SetDisabledFields(List<string> fieldNumbers);
        void SetEnabledField(string fieldNumber);
        void SetEnabledFields(List<string> fieldNumbers);
        void SetFieldValue(string fieldNumber, string fieldValue);
        void SetFieldValue(string formId, string rowId, string fieldNumber, string fieldValue);
        void SetLockedField(string fieldNumber);
        void SetLockedFields(List<string> fieldNumbers);
        void SetOptionalField(string fieldNumber);
        void SetOptionalFields(List<string> fieldNumbers);
        void SetRequiredField(string fieldNumber);
        void SetRequiredFields(List<string> fieldNumbers);
        void SetUnlockedField(string fieldNumber);
        void SetUnlockedFields(List<string> fieldNumbers);
        string ToHtmlString();
        string ToHtmlString(bool includeHtmlHeaders);
        string ToJson();
        OptionObject ToOptionObject();
        OptionObject2 ToOptionObject2();
        OptionObject2015 ToOptionObject2015();
        OptionObjectBase ToReturnOptionObject();
        OptionObjectBase ToReturnOptionObject(double errorCode, string errorMessage);
        string ToXml();
    }
}
