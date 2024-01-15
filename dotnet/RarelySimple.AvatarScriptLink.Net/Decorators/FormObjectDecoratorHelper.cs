namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class FormObjectDecorator
    {
        public class Helper : DecoratorHelper
        {
            /// <summary>
            /// Returns whether the <see cref="FieldObjectDecorator"/> in the <see cref="FormObjectDecorator"/> is present by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <returns></returns>
            public static bool IsFieldPresent(FormObjectDecorator decorator, string fieldNumber)
            {
                // if (formObject == null)
                //     throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(fieldNumber))
                //     throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                if (decorator.CurrentRow == null)
                    return false;
                return RowObjectDecorator.Helper.IsFieldPresent(decorator.CurrentRow, fieldNumber);
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
                // if (decorator == null)
                //     throw new ArgumentNullException(nameof(decorator), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (decorator.CurrentRow == null)
                //     throw new NullReferenceException(ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(fieldNumber))
                //     throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (decorator.MultipleIteration && decorator.OtherRows.Count > 0)
                //     throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("unableToIdentifyFieldObject", CultureInfo.CurrentCulture));
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
                // if (decorator == null)
                //     throw new ArgumentNullException(nameof(decorator), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (decorator.CurrentRow == null)
                //     throw new NullReferenceException(ScriptLinkHelpers.GetLocalizedString("formObjectMissingCurrentRow", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(rowId))
                //     throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(fieldNumber))
                //     throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
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
                // throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(decorator));
                return null;
            }
        }
    }
}