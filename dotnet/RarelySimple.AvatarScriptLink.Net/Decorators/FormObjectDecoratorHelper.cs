using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class FormObjectDecorator
    {
        public class Helper : DecoratorHelper
        {
            private static readonly ResourceManager resourceManager = new ResourceManager("RarelySimple.AvatarScriptLink.Net.Localizations", Assembly.GetExecutingAssembly());

            /// <summary>
            /// Returns the FieldValue of a <see cref="FieldObject"/> in the curent row of a <see cref="FormObjectDecorator"/> by FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static string GetFieldValue(FormObjectDecorator formObject, string fieldNumber)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                return GetFieldValue(formObject, formObject.CurrentRow.RowId, fieldNumber);
            }
            /// <summary>
            /// Returns the FieldValue of a <see cref="FieldObject"/> in a <see cref="FormObjectDecorator"/> by RowId and FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="rowId"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static string GetFieldValue(FormObjectDecorator formObject, string rowId, string fieldNumber)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (formObject.CurrentRow.RowId == rowId)
                    return RowObjectDecorator.Helper.GetFieldValue(formObject.CurrentRow, fieldNumber);
                foreach (RowObjectDecorator rowObject in formObject.OtherRows)
                {
                    if (rowObject.RowId == rowId)
                        return RowObjectDecorator.Helper.GetFieldValue(rowObject, fieldNumber);
                }
                throw new ArgumentException(resourceManager.GetString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
            }
            /// <summary>
            /// Returns whether a <see cref="FormObject"/> is Multiple Iteration.
            /// </summary>
            /// <param name="formObject"></param>
            /// <returns></returns>
            public static bool GetMultipleIterationStatus(FormObjectDecorator formObject)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                return formObject.MultipleIteration;
            }
            /// <summary>
            /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IFormObject"/> is enabled by FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldEnabled(FormObjectDecorator formObject, string fieldNumber)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (formObject.CurrentRow == null)
                    throw new NullReferenceException(resourceManager.GetString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                return RowObjectDecorator.Helper.IsFieldEnabled(formObject.CurrentRow, fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IFormObject"/> is locked by FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldLocked(FormObjectDecorator formObject, string fieldNumber)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (formObject.CurrentRow == null)
                    throw new NullReferenceException(resourceManager.GetString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
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
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (decorator.CurrentRow == null)
                    return false;
                return RowObjectDecorator.Helper.IsFieldPresent(decorator.CurrentRow, fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="IFieldObject"/> in the <see cref="IFormObject"/> is required by FieldNumber.
            /// </summary>
            /// <param name="formObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldRequired(FormObjectDecorator formObject, string fieldNumber)
            {
                if (formObject == null)
                    throw new ArgumentNullException(nameof(formObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (formObject.CurrentRow == null)
                    throw new NullReferenceException(resourceManager.GetString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                return RowObjectDecorator.Helper.IsFieldRequired(formObject.CurrentRow, fieldNumber);
            }
            /// <summary>
            /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IFormObject"/> by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static FormObjectDecorator SetFieldValue(FormObjectDecorator decorator, string fieldNumber, string fieldValue)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (decorator.CurrentRow == null)
                    throw new NullReferenceException(resourceManager.GetString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (decorator.MultipleIteration && decorator.OtherRows.Count > 0)
                    throw new ArgumentException(resourceManager.GetString("unableToIdentifyFieldObject", CultureInfo.CurrentCulture));
                return SetFieldValue(decorator, decorator.CurrentRow.RowId, fieldNumber, fieldValue);
            }
            /// <summary>
            /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="IFormObject"/> by RowId and FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="rowId"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static FormObjectDecorator SetFieldValue(FormObjectDecorator decorator, string rowId, string fieldNumber, string fieldValue)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (decorator.CurrentRow == null)
                    throw new NullReferenceException(resourceManager.GetString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
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
                throw new ArgumentException(resourceManager.GetString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(decorator));
            }
        }
    }
}