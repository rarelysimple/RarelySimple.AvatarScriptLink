﻿using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class RowObjectDecorator
    {
        private class RowObjectDecoratorHelper
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
            /// Sets the FieldValue of a <see cref="FieldObject"/> in a <see cref="RowObjectDecorator"/> by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static RowObjectDecorator SetFieldValue(RowObjectDecorator decorator, string fieldNumber, string fieldValue)
            {
                for (int i = 0; i < decorator.Fields.Count; i++)
                {
                    if (decorator.Fields[i].FieldNumber == fieldNumber)
                    {
                        decorator.Fields[i].FieldValue = fieldValue;
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
