using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using RarelySimple.AvatarScriptLink.Net.Exceptions;
using RarelySimple.AvatarScriptLink.Objects;
using static RarelySimple.AvatarScriptLink.Objects.RowObject;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class RowObjectDecorator
    {
        private sealed class Helper : DecoratorHelper
        {
            private static readonly ResourceManager resourceManager = new ResourceManager("RarelySimple.AvatarScriptLink.Net.Localizations", Assembly.GetExecutingAssembly());

            /// <summary>
            /// Adds a <see cref="FieldObject"/> to a <see cref="RowObjectDecorator"/>.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldObject"></param>
            /// <returns></returns>
            public static RowObjectDecorator AddFieldObject(RowObjectDecorator decorator, FieldObject fieldObject)
            {
                if (decorator == null)
                   throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (fieldObject == null)
                   throw new ArgumentNullException(nameof(fieldObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (decorator.Fields.Contains(new FieldObjectDecorator(fieldObject)))
                   throw new ArgumentException(resourceManager.GetString(FieldObjectAlreadyExists, CultureInfo.CurrentCulture), nameof(fieldObject));
                if (decorator.Fields.Exists(f => f.FieldNumber == fieldObject.FieldNumber))
                   throw new ArgumentException(resourceManager.GetString(FieldNumberAlreadyExists, CultureInfo.CurrentCulture));
                decorator.Fields.Add(new FieldObjectDecorator(fieldObject.FieldNumber)
                {
                    // Setting other attributes after to flag as modified
                    Enabled = fieldObject.IsEnabled(),
                    FieldValue = fieldObject.FieldValue,
                    Locked = fieldObject.IsLocked(),
                    Required = fieldObject.IsRequired()
                });
                if (decorator.RowAction == RowActions.None)
                    decorator.RowAction = RowActions.Edit;
                return decorator;
            }
            /// <summary>
            /// Returns the FieldValue of a <see cref="FieldObject"/> in a <see cref="RowObjectDecorator"/> by FieldNumber.
            /// </summary>
            /// <param name="rowObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static string GetFieldValue(RowObjectDecorator rowObject, string fieldNumber)
            {
                if (rowObject == null)
                    throw new ArgumentNullException(nameof(rowObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                foreach (FieldObjectDecorator field in rowObject.Fields)
                {
                    if (field.FieldNumber == fieldNumber)
                        return field.FieldValue;
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="RowObjectDecorator"/> is enabled by FieldNumber.
            /// </summary>
            /// <param name="rowObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldEnabled(RowObjectDecorator rowObject, string fieldNumber)
            {
                if (rowObject == null)
                    throw new ArgumentNullException(nameof(rowObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (rowObject.Fields == null)
                    throw new ArgumentNullException(nameof(rowObject), resourceManager.GetString(RowObjectMissingFields, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                foreach (FieldObjectDecorator field in rowObject.Fields)
                {
                    if (field.FieldNumber == fieldNumber)
                        return field.Enabled;
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="RowObjectDecorator"/> is locked by FieldNumber.
            /// </summary>
            /// <param name="rowObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldLocked(RowObjectDecorator rowObject, string fieldNumber)
            {
                if (rowObject == null)
                    throw new ArgumentNullException(nameof(rowObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (rowObject.Fields == null)
                    throw new ArgumentNullException(nameof(rowObject), resourceManager.GetString(RowObjectMissingFields, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                foreach (FieldObjectDecorator field in rowObject.Fields)
                {
                    if (field.FieldNumber == fieldNumber)
                        return field.Locked;
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="RowObjectDecorator"/> is present by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldPresent(RowObjectDecorator decorator, string fieldNumber)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (decorator.Fields == null)
                    return false;
                foreach (var field in decorator.Fields)
                {
                    if (field.FieldNumber == fieldNumber)
                        return true;
                }
                return false;
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="RowObjectDecorator"/> is required by FieldNumber.
            /// </summary>
            /// <param name="rowObject"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldRequired(RowObjectDecorator rowObject, string fieldNumber)
            {
                if (rowObject == null)
                    throw new ArgumentNullException(nameof(rowObject), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (rowObject.Fields == null)
                    throw new ArgumentNullException(nameof(rowObject), resourceManager.GetString(RowObjectMissingFields, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                foreach (FieldObjectDecorator field in rowObject.Fields)
                {
                    if (field.FieldNumber == fieldNumber)
                        return field.Required;
                }
                throw new FieldObjectNotFoundException(string.Format(resourceManager.GetString(NoFieldObjectsFoundByFieldNumber, CultureInfo.CurrentCulture), fieldNumber), fieldNumber);
            }
            /// <summary>
            /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="RowObjectDecorator"/> by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static RowObjectDecorator SetFieldValue(RowObjectDecorator decorator, string fieldNumber, string fieldValue)
            {
                if (decorator == null)
                    throw new ArgumentNullException(nameof(decorator), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), resourceManager.GetString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                foreach (var fieldObject in decorator.Fields)
                {
                    if (fieldObject.FieldNumber == fieldNumber)
                    {
                        fieldObject.FieldValue = fieldValue;
                        if (decorator.RowAction == RowActions.None)
                            decorator.RowAction = RowActions.Edit;
                        break;
                    }
                }
                return decorator;
            }
        }
    }
}
