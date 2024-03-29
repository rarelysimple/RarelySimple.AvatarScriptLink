﻿using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class OptionObjectDecorator
    {
        public class Helper : DecoratorHelper
        {
            private static readonly ResourceManager resourceManager = new ResourceManager("RarelySimple.AvatarScriptLink.Net.Localizations", Assembly.GetExecutingAssembly());

            /// <summary>
            /// Returns the FieldValue of a specified <see cref="FieldObject"/> in an <see cref="OptionObjectDecorator"/> by FieldNumber.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static string GetFieldValue(OptionObjectDecorator optionObject, string fieldNumber)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                foreach (var form in optionObject.Forms)
                {
                    if (form.IsFieldPresent(fieldNumber))
                        return FormObjectDecorator.Helper.GetFieldValue(form, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns the FieldValue of a specified <see cref="FieldObject"/> in an <see cref="OptionObjectDecorator"/> by FormId, RowId, and FieldNumber.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="formId"></param>
            /// <param name="rowId"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static string GetFieldValue(OptionObjectDecorator optionObject, string formId, string rowId, string fieldNumber)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(formId))
                    throw new ArgumentNullException(nameof(formId), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                foreach (var form in optionObject.Forms)
                {
                    if (form.FormId == formId)
                        return FormObjectDecorator.Helper.GetFieldValue(form, rowId, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns whether a <see cref="FormObject"/> in the <see cref="OptionObject"/> is Multiple Iteration by specified FormId.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="formId"></param>
            /// <returns></returns>
            public static bool GetMultipleIterationStatus(OptionObjectDecorator optionObject, string formId)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(formId))
                    throw new ArgumentNullException(nameof(formId), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (optionObject.Forms == null)
                    throw new NullReferenceException(resourceManager.GetString("optionObjectMissingForms", CultureInfo.CurrentCulture));
                foreach (var formObject in optionObject.Forms)
                {
                    if (formObject.FormId == formId)
                        return FormObjectDecorator.Helper.GetMultipleIterationStatus(formObject);
                }
                throw new FormObjectNotFoundException(string.Format(resourceManager.GetString("noFormObjectsFoundByFormId", CultureInfo.CurrentCulture), formId), formId);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="OptionObjectDecorator"/> is enabled by FieldNumber.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldEnabled(OptionObjectDecorator optionObject, string fieldNumber)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (optionObject.Forms == null)
                    throw new NullReferenceException(resourceManager.GetString("optionObjectMissingForms", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                foreach (var form in optionObject.Forms)
                {
                    if (FormObjectDecorator.Helper.IsFieldPresent(form, fieldNumber))
                        return FormObjectDecorator.Helper.IsFieldEnabled(form, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="OptionObjectDecorator"/> is locked by FieldNumber.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldLocked(OptionObjectDecorator optionObject, string fieldNumber)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (optionObject.Forms == null)
                    throw new NullReferenceException(resourceManager.GetString("optionObjectMissingForms", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                foreach (var form in optionObject.Forms)
                {
                    if (FormObjectDecorator.Helper.IsFieldPresent(form, fieldNumber))
                        return FormObjectDecorator.Helper.IsFieldLocked(form, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="OptionObjectDecorator"/> is present by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldPresent(OptionObjectDecorator decorator, string fieldNumber)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (decorator.Forms == null)
                    throw new NullReferenceException(resourceManager.GetString("optionObjectMissingForms", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                foreach (var form in decorator.Forms)
                {
                    if (FormObjectDecorator.Helper.IsFieldPresent(form, fieldNumber))
                        return true;
                }
                return false;
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="OptionObjectDecorator"/> is required by FieldNumber.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldRequired(OptionObjectDecorator optionObject, string fieldNumber)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (optionObject.Forms == null)
                    throw new NullReferenceException(resourceManager.GetString("optionObjectMissingForms", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                foreach (var form in optionObject.Forms)
                {
                    if (FormObjectDecorator.Helper.IsFieldPresent(form, fieldNumber))
                        return FormObjectDecorator.Helper.IsFieldRequired(form, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Sets the FieldValue of a <see cref="FieldObject"/> in an <see cref="OptionObjectDecorator"/> by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static OptionObjectDecorator SetFieldValue(OptionObjectDecorator decorator, string fieldNumber, string fieldValue)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (decorator.Forms == null)
                    throw new NullReferenceException(resourceManager.GetString("optionObjectMissingForms", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                foreach (var form in decorator.Forms)
                {
                    if (form.IsFieldPresent(fieldNumber))
                    {
                        if (form.MultipleIteration && form.OtherRows.Count > 0)
                            throw new ArgumentException(resourceManager.GetString("unableToIdentifyFieldObject", CultureInfo.CurrentCulture), nameof(decorator));
                        return SetFieldValue(decorator, form.FormId, form.CurrentRow.RowId, fieldNumber, fieldValue);
                    }
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Sets the FieldValue of a <see cref="FieldObject"/> in an <see cref="OptionObjectDecorator"/> by FormId, RowID, and FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="formId"></param>
            /// <param name="rowId"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static OptionObjectDecorator SetFieldValue(OptionObjectDecorator decorator, string formId, string rowId, string fieldNumber, string fieldValue)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(formId))
                    throw new ArgumentNullException(nameof(formId), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (decorator.Forms == null)
                    throw new NullReferenceException(resourceManager.GetString("optionObjectMissingForms", CultureInfo.CurrentCulture));
                for (int i = 0; i < decorator.Forms.Count; i++)
                {
                    if (decorator.Forms[i].FormId == formId)
                    {
                        var formObject = FormObjectDecorator.Helper.SetFieldValue(decorator.Forms[i], rowId, fieldNumber, fieldValue);
                        if (formObject.CurrentRow != null ||
                            formObject.OtherRows.Count > 0)
                            decorator.Forms[i] = formObject;
                    }
                }
                return decorator;
            }
        }
    }
}
