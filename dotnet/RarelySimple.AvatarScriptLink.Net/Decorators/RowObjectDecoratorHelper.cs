using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class RowObjectDecorator
    {
        public class Helper : DecoratorHelper
        {
            /// <summary>
            /// Adds a <see cref="FieldObject"/> to a <see cref="RowObjectDecorator"/>.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldObject"></param>
            /// <returns></returns>
            public static RowObjectDecorator AddFieldObject(RowObjectDecorator decorator, FieldObject fieldObject)
            {
                //if (rowObject == null)
                //    throw new System.ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                //if (fieldObject == null)
                //    throw new System.ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                //if (rowObject.Fields.Contains((FieldObject)fieldObject))
                //    throw new System.ArgumentException(ScriptLinkHelpers.GetLocalizedString("fieldObjectAlreadyExists", CultureInfo.CurrentCulture), nameof(fieldObject));
                //if (rowObject.Fields.Exists(f => f.FieldNumber == fieldObject.FieldNumber))
                //    throw new System.ArgumentException(ScriptLinkHelpers.GetLocalizedString("fieldNumberAlreadyExists", CultureInfo.CurrentCulture));
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
                // if (rowObject == null)
                //     throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(fieldNumber))
                //     throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                foreach (FieldObjectDecorator field in rowObject.Fields)
                {
                    if (field.FieldNumber == fieldNumber)
                        return field.FieldValue;
                }
                // throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
                return null;
            }
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="RowObjectDecorator"/> is present by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldPresent(RowObjectDecorator decorator, string fieldNumber)
            {
                // if (decorator == null)
                //     throw new ArgumentNullException(nameof(decorator), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(fieldNumber))
                //     throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
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
            /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="RowObjectDecorator"/> by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static RowObjectDecorator SetFieldValue(RowObjectDecorator decorator, string fieldNumber, string fieldValue)
            {
                // if (decorator == null)
                //     throw new ArgumentNullException(nameof(decorator), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(fieldNumber))
                //     throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
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
