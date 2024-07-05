using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using RarelySimple.AvatarScriptLink.Net.Exceptions;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class FormObjectDecorator
    {
        public class Helper : DecoratorHelper
        {
            private static readonly ResourceManager resourceManager = new ResourceManager("RarelySimple.AvatarScriptLink.Net.Localizations", Assembly.GetExecutingAssembly());

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
                    return RowObjectDecorator.Helper.GetFieldValue(formObject.CurrentRow, fieldNumber);
                foreach (RowObjectDecorator rowObject in formObject.OtherRows)
                {
                    if (rowObject.RowId == rowId)
                        return RowObjectDecorator.Helper.GetFieldValue(rowObject, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
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
                return RowObjectDecorator.Helper.IsFieldEnabled(formObject.CurrentRow, fieldNumber);
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
                return RowObjectDecorator.Helper.IsFieldLocked(formObject.CurrentRow, fieldNumber);
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
                return RowObjectDecorator.Helper.IsFieldPresent(decorator.CurrentRow, fieldNumber);
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
                return RowObjectDecorator.Helper.IsFieldRequired(formObject.CurrentRow, fieldNumber);
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
                    decorator.CurrentRow = RowObjectDecorator.Helper.SetFieldValue(decorator.CurrentRow, fieldNumber, fieldValue);
                    return decorator;
                }
                if (decorator.MultipleIteration)
                {
                    for (int i = 0; i < decorator.OtherRows.Count; i++)
                    {
                        if (decorator.OtherRows[i].RowId == rowId)
                        {
                            decorator.OtherRows[i] = RowObjectDecorator.Helper.SetFieldValue(decorator.OtherRows[i], fieldNumber, fieldValue);
                            return decorator;
                        }
                    }
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
        }
    }
}