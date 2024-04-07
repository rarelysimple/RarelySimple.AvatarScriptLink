using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using RarelySimple.AvatarScriptLink.Net.Exceptions;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class OptionObject2015Decorator
    {
        public class Helper : DecoratorHelper
        {
            private static readonly ResourceManager resourceManager = new ResourceManager("RarelySimple.AvatarScriptLink.Net.Localizations", Assembly.GetExecutingAssembly());

            /// <summary>
            /// Returns the FieldValue of a specified <see cref="FieldObject"/> in an <see cref="OptionObject2015Decorator"/> by FieldNumber.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static string GetFieldValue(OptionObject2015Decorator optionObject, string fieldNumber)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                var form = optionObject.Forms.Where(x => x.IsFieldPresent(fieldNumber)).FirstOrDefault();
                if (form != null)
                {
                    return FormObjectDecorator.Helper.GetFieldValue(form, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns the FieldValue of a specified <see cref="FieldObject"/> in an <see cref="OptionObject2015Decorator"/> by FormId, RowId, and FieldNumber.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="formId"></param>
            /// <param name="rowId"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static string GetFieldValue(OptionObject2015Decorator optionObject, string formId, string rowId, string fieldNumber)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(formId))
                    throw new ArgumentNullException(nameof(formId), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                foreach (var form in optionObject.Forms)
                {
                    if (form.FormId == formId)
                        return FormObjectDecorator.Helper.GetFieldValue(form, rowId, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns whether a <see cref="FormObject"/> in the <see cref="OptionObject2015"/> is Multiple Iteration by specified FormId.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="formId"></param>
            /// <returns></returns>
            public static bool GetMultipleIterationStatus(OptionObject2015Decorator optionObject, string formId)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(formId))
                    throw new ArgumentNullException(nameof(formId), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (optionObject.Forms == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString(OptionObjectMissingForms, CultureInfo.CurrentCulture));
                foreach (var formObject in optionObject.Forms)
                {
                    if (formObject.FormId == formId)
                        return FormObjectDecorator.Helper.GetMultipleIterationStatus(formObject);
                }
                throw new FormObjectNotFoundException(string.Format(resourceManager.GetString(NoFormObjectsFoundByFormId, CultureInfo.CurrentCulture), formId), formId);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="OptionObject2015Decorator"/> is enabled by FieldNumber.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldEnabled(OptionObject2015Decorator optionObject, string fieldNumber)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (optionObject.Forms == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString(OptionObjectMissingForms, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                var form = optionObject.Forms.Where(x => x.IsFieldPresent(fieldNumber)).FirstOrDefault();
                if (form != null)
                {
                    return FormObjectDecorator.Helper.IsFieldEnabled(form, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="OptionObject2015Decorator"/> is locked by FieldNumber.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldLocked(OptionObject2015Decorator optionObject, string fieldNumber)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (optionObject.Forms == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString(OptionObjectMissingForms, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                var form = optionObject.Forms.Where(x => x.IsFieldPresent(fieldNumber)).FirstOrDefault();
                if (form != null)
                {
                    return FormObjectDecorator.Helper.IsFieldLocked(form, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="OptionObject2015Decorator"/> is present by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldPresent(OptionObject2015Decorator decorator, string fieldNumber)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (decorator.Forms == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(OptionObjectMissingForms, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return decorator.Forms.Where(x => x.IsFieldPresent(fieldNumber)).FirstOrDefault() != null;
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="OptionObject2015Decorator"/> is required by FieldNumber.
            /// </summary>
            /// <param name="optionObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldRequired(OptionObject2015Decorator optionObject, string fieldNumber)
            {
                if (optionObject == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (optionObject.Forms == null)
                    throw new ArgumentNullException(nameof(optionObject), resourceManager.GetString(OptionObjectMissingForms, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                var form = optionObject.Forms.Where(x => x.IsFieldPresent(fieldNumber)).FirstOrDefault();
                if (form != null)
                {
                    return FormObjectDecorator.Helper.IsFieldRequired(form, fieldNumber);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Sets the FieldValue of a <see cref="FieldObject"/> in an <see cref="OptionObject2015Decorator"/> by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static OptionObject2015Decorator SetFieldValue(OptionObject2015Decorator decorator, string fieldNumber, string fieldValue)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (decorator.Forms == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(OptionObjectMissingForms, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                var form = decorator.Forms.Where(x => x.IsFieldPresent(fieldNumber)).FirstOrDefault();
                if (form != null)
                {
                    if (form.MultipleIteration && form.OtherRows.Count > 0)
                        throw new ArgumentException(resourceManager.GetString(UnableToIdentifyFieldObject, CultureInfo.CurrentCulture), nameof(decorator));
                    return SetFieldValue(decorator, form.FormId, form.CurrentRow.RowId, fieldNumber, fieldValue);
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Sets the FieldValue of a <see cref="FieldObject"/> in an <see cref="OptionObject2015Decorator"/> by FormId, RowID, and FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="formId"></param>
            /// <param name="rowId"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static OptionObject2015Decorator SetFieldValue(OptionObject2015Decorator decorator, string formId, string rowId, string fieldNumber, string fieldValue)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(formId))
                    throw new ArgumentNullException(nameof(formId), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (decorator.Forms == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(OptionObjectMissingForms, CultureInfo.CurrentCulture));
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
