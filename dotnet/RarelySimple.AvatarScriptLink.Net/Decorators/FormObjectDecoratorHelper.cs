using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using RarelySimple.AvatarScriptLink.Net.Exceptions;
using RarelySimple.AvatarScriptLink.Objects;
using static RarelySimple.AvatarScriptLink.Objects.RowObject;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class FormObjectDecorator
    {
        private sealed class Helper : DecoratorHelper
        {
            private static readonly ResourceManager resourceManager = new ResourceManager("RarelySimple.AvatarScriptLink.Net.Localizations", Assembly.GetExecutingAssembly());

            /// <summary>
            /// Gets the CurrentRow.RowId of the <see cref="FormObjectDecorator"/>.
            /// </summary>
            /// <param name="formObject"></param>
            /// <returns></returns>
            public static string GetCurrentRowId(FormObjectDecorator formObject)
            {
                if (formObject.CurrentRow == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
                return formObject.CurrentRow.RowId;
            }
            /// <summary>
            /// Returns the FieldValue of a <see cref="FieldObjectDecorator"/> in the curent row of a <see cref="FormObjectDecorator"/> by FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static string GetFieldValue(FormObjectDecorator formObject, string fieldNumber)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return GetFieldValue(formObject, formObject.CurrentRow.RowId, fieldNumber);
            }
            /// <summary>
            /// Returns the FieldValue of a <see cref="FieldObjectDecorator"/> in a <see cref="FormObjectDecorator"/> by RowId and FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="rowId"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static string GetFieldValue(FormObjectDecorator formObject, string rowId, string fieldNumber)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (formObject.CurrentRow.RowId == rowId)
                    return formObject.CurrentRow.GetFieldValue(fieldNumber);
                foreach (RowObjectDecorator rowObject in formObject.OtherRows)
                {
                    if (rowObject.RowId == rowId)
                        return rowObject.GetFieldValue(fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns a list of FieldValues of a specified <see cref="FieldObject"/> in the <see cref="FormObjectDecorator"/> by FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static List<string> GetFieldValues(FormObjectDecorator formObject, string fieldNumber)
            {
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                List<string> values = new List<string>();
                if (IsFieldPresent(formObject, fieldNumber))
                {
                    values.Add(formObject.CurrentRow.GetFieldValue(fieldNumber));
                    if (formObject.MultipleIteration)
                    {
                        foreach (RowObjectDecorator rowObject in formObject.OtherRows)
                        {
                            values.Add(rowObject.GetFieldValue(fieldNumber));
                        }
                    }
                    return values;
                }
                return values;
            }
            /// <summary>
            /// Returns whether a <see cref="FormObjectDecorator"/> is Multiple Iteration.
            /// </summary>
            /// <param name="formObject"></param>
            /// <returns></returns>
            public static bool GetMultipleIterationStatus(FormObjectDecorator formObject)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return formObject.MultipleIteration;
            }
            /// <summary>
            /// Returns the ParentRowId of a <see cref="FormObjectDecorator"/>.
            /// </summary>
            /// <param name="formObject"></param>
            /// <returns></returns>
            public static string GetParentRowId(FormObjectDecorator formObject)
            {
                if (formObject.CurrentRow == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
                return formObject.CurrentRow.ParentRowId;
            }
            /// <summary>
            /// Returns whether the <see cref="IFieldObject"/> in the <see cref="FormObjectDecorator"/> is enabled by FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldEnabled(FormObjectDecorator formObject, string fieldNumber)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (formObject.CurrentRow == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(FormObjectMissingCurrentRow, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return formObject.CurrentRow.IsFieldEnabled(fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="FormObjectDecorator"/> is locked by FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldLocked(FormObjectDecorator formObject, string fieldNumber)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (formObject.CurrentRow == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(FormObjectMissingCurrentRow, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return formObject.CurrentRow.IsFieldLocked(fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="FormObjectDecorator"/> is modified by FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldModified(FormObjectDecorator formObject, string fieldNumber)
            {
                if (formObject.CurrentRow == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return formObject.CurrentRow.IsFieldModified(fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="FormObjectDecorator"/> is present by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldPresent(FormObjectDecorator decorator, string fieldNumber)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (decorator.CurrentRow == null)
                    return false;
                return decorator.CurrentRow.IsFieldPresent(fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="FormObjectDecorator"/> is required by FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldRequired(FormObjectDecorator formObject, string fieldNumber)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (formObject.CurrentRow == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(FormObjectMissingCurrentRow, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return formObject.CurrentRow.IsFieldRequired(fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="RowObject"/> in an <see cref="FormObject"/> is marked for deletion by RowId.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="rowId"></param>
            /// <returns></returns>
            public static bool IsRowMarkedForDeletion(FormObjectDecorator formObject, string rowId)
            {
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (formObject.CurrentRow.RowId == rowId)
                    return formObject.CurrentRow.RowAction == RowActions.Delete;
                if (formObject.MultipleIteration)
                    return formObject.OtherRows.Exists(r => r.RowId == rowId && r.RowAction == RowActions.Delete);
                return false;
            }
            /// <summary>
            /// Returns whether the <see cref="RowObjectDecorator"/> in the <see cref="FormObjectDecorator"/> is enabled by RowId.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="rowId"></param>
            /// <returns></returns>
            public static bool IsRowPresent(FormObjectDecorator formObject, string rowId)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (formObject.CurrentRow != null && formObject.CurrentRow.RowId == rowId)
                    return true;
                if (formObject.MultipleIteration)
                    return formObject.OtherRows.Exists(r => r.RowId == rowId);
                return false;
            }
            /// <summary>
            /// Sets the FieldValue of a <see cref="FieldObjectDecorator"/> in a <see cref="FormObjectDecorator"/> by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static FormObjectDecorator SetFieldValue(FormObjectDecorator decorator, string fieldNumber, string fieldValue)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (decorator.CurrentRow == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(FormObjectMissingCurrentRow, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (decorator.MultipleIteration && decorator.OtherRows.Count > 0)
                    throw new ArgumentException(resourceManager.GetString(UnableToIdentifyFieldObject, CultureInfo.CurrentCulture));
                return SetFieldValue(decorator, decorator.CurrentRow.RowId, fieldNumber, fieldValue);
            }
            /// <summary>
            /// Sets the FieldValue of a <see cref="FieldObjectDecorator"/> in a <see cref="FormObjectDecorator"/> by RowId and FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="rowId"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static FormObjectDecorator SetFieldValue(FormObjectDecorator decorator, string rowId, string fieldNumber, string fieldValue)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (decorator.CurrentRow == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(FormObjectMissingCurrentRow, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (decorator.CurrentRow.RowId == rowId)
                {
                    decorator.CurrentRow.SetFieldValue(fieldNumber, fieldValue);
                    return decorator;
                }
                if (decorator.MultipleIteration)
                {
                    for (int i = 0; i < decorator.OtherRows.Count; i++)
                    {
                        if (decorator.OtherRows[i].RowId == rowId)
                        {
                            decorator.OtherRows[i].SetFieldValue(fieldNumber, fieldValue);
                            return decorator;
                        }
                    }
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns the next available RowId for a <see cref="FormObjectDecorator"/>.
            /// </summary>
            /// <param name="formObject"></param>
            /// <returns></returns>
            public static string GetNextAvailableRowId(FormObjectDecorator formObject)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (formObject.CurrentRow != null && !formObject.MultipleIteration)
                    throw new ArgumentOutOfRangeException(resourceManager.GetString("cannotAddAnotherRowObject", CultureInfo.CurrentCulture));
                int maximumNumberOfMultipleIterationRows = 9999;
                if (formObject.CurrentRow != null && formObject.OtherRows.Count + 1 >= maximumNumberOfMultipleIterationRows)
                    throw new ArgumentOutOfRangeException(resourceManager.GetString("cannotAddAnotherRowObject", CultureInfo.CurrentCulture));
                for (int i = 1; i <= maximumNumberOfMultipleIterationRows; i++)
                {
                    string tempRowId = formObject.FormId + "||" + i.ToString(CultureInfo.InvariantCulture);
                    if ((formObject.CurrentRow == null || formObject.CurrentRow.RowId != tempRowId)
                        && !formObject.OtherRows.Exists(r => r.RowId == tempRowId))
                        return tempRowId;
                }
                throw new ArgumentException(resourceManager.GetString("couldNotDetermineNextRowId", CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Adds a <see cref="RowObjectDecorator"/> to a provided <see cref="FormObjectDecorator"/>.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="rowObject"></param>
            /// <returns></returns>
            public static FormObjectDecorator AddRowObject(FormObjectDecorator formObject, RowObject rowObject)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (rowObject == null)
                    throw new ArgumentNullException(nameof(rowObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (!formObject.MultipleIteration && formObject.CurrentRow != null)
                    throw new ArgumentException(resourceManager.GetString("cannotAddAnotherRowObject", CultureInfo.CurrentCulture));
                
                if ((formObject.CurrentRow != null && formObject.CurrentRow.RowId == rowObject.RowId && !string.IsNullOrEmpty(rowObject.RowId)) ||
                    (formObject.OtherRows != null && formObject.OtherRows.Exists(r => r.RowId == rowObject.RowId && !string.IsNullOrEmpty(rowObject.RowId))))
                    throw new ArgumentException(resourceManager.GetString("rowIdAlreadyExists", CultureInfo.CurrentCulture));

                if (formObject.CurrentRow == null)
                {
                    rowObject.RowId = GetNextAvailableRowId(formObject);
                    formObject.CurrentRow = new RowObjectDecorator(rowObject);
                }
                else
                {
                    if (string.IsNullOrEmpty(rowObject.RowId))
                        rowObject.RowId = GetNextAvailableRowId(formObject);
                    formObject.OtherRows.Add(new RowObjectDecorator(rowObject));
                }
                return formObject;
            }
            /// <summary>
            /// Adds a <see cref="RowObject"/> to a provided <see cref="FormObjectDecorator"/> using provided RowId and ParentRowId.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="rowId"></param>
            /// <param name="parentRowId"></param>
            /// <returns></returns>
            public static FormObjectDecorator AddRowObject(FormObjectDecorator formObject, string rowId, string parentRowId)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return AddRowObject(formObject, rowId, parentRowId, RowActions.Add);
            }
            /// <summary>
            /// Adds a <see cref="RowObject"/> to a provided <see cref="FormObjectDecorator"/> using provided RowId, ParentRowId, and RowAction.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="rowId"></param>
            /// <param name="parentRowId"></param>
            /// <param name="rowAction"></param>
            /// <returns></returns>
            public static FormObjectDecorator AddRowObject(FormObjectDecorator formObject, string rowId, string parentRowId, string rowAction)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                RowObject rowObject = new RowObject
                {
                    ParentRowId = parentRowId,
                    RowAction = rowAction,
                    RowId = rowId
                };
                return AddRowObject(formObject, rowObject);
            }
            /// <summary>
            /// Flags a <see cref="RowObject"/> for deletion in a <see cref="FormObjectDecorator"/>.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="rowObject"></param>
            /// <returns></returns>
            public static FormObjectDecorator DeleteRowObject(FormObjectDecorator formObject, RowObject rowObject)
            {
                if (rowObject == null)
                    throw new ArgumentNullException(nameof(rowObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return DeleteRowObject(formObject, rowObject.RowId);
            }
            /// <summary>
            /// Flags a <see cref="RowObject"/> for deletion in a <see cref="FormObjectDecorator"/> by RowId.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="rowId"></param>
            /// <returns></returns>
            public static FormObjectDecorator DeleteRowObject(FormObjectDecorator formObject, string rowId)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

                if (formObject.CurrentRow?.RowId == rowId)
                {
                    formObject.CurrentRow.RowAction = RowActions.Delete;
                    return formObject;
                }

                if (formObject.MultipleIteration)
                {
                    int rowIndex = formObject.OtherRows.FindIndex(r => r.RowId == rowId);
                    if (rowIndex >= 0)
                    {
                        formObject.OtherRows[rowIndex].RowAction = RowActions.Delete;
                        return formObject;
                    }
                }

                throw new ArgumentException(resourceManager.GetString("noRowObjectsFoundByRowId", CultureInfo.CurrentCulture), nameof(rowId));
            }
            /// <summary>
            /// Disables all <see cref="FieldObject"/> in the <see cref="FormObjectDecorator"/>.
            /// </summary>
            /// <param name="formObject"></param>
            /// <returns></returns>
            public static FormObjectDecorator DisableAllFieldObjects(FormObjectDecorator formObject)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return DisableAllFieldObjects(formObject, new List<string>());
            }
            /// <summary>
            /// Disables all <see cref="FieldObject"/> in the <see cref="FormObjectDecorator"/>, except for the FieldNumbers specified in the list.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="excludedFields"></param>
            /// <returns></returns>
            public static FormObjectDecorator DisableAllFieldObjects(FormObjectDecorator formObject, List<string> excludedFields)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (excludedFields == null)
                    throw new ArgumentNullException(nameof(excludedFields), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));

                if (formObject.CurrentRow != null)
                {
                    formObject.CurrentRow.DisableAllFieldObjects(excludedFields);
                }

                if (formObject.MultipleIteration)
                {
                    formObject.OtherRows.ForEach(r => r.DisableAllFieldObjects(excludedFields));
                }

                return formObject;
            }
        }
    }
}
