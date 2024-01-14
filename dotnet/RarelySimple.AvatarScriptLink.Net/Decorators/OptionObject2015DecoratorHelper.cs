namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class OptionObject2015Decorator
    {
        public class Helper : DecoratorHelper
        {
            /// <summary>
            /// Sets the FieldValue of a <see cref="FieldObject"/> in an <see cref="OptionObject2015Decorator"/> by FieldNumber.
            /// </summary>
            /// <param name="decorator"></param>
            /// <param name="fieldNumber"></param>
            /// <param name="fieldValue"></param>
            /// <returns></returns>
            public static OptionObject2015Decorator SetFieldValue(OptionObject2015Decorator decorator, string fieldNumber, string fieldValue)
            {
                // if (decorator == null)
                //     throw new ArgumentNullException(nameof(decorator), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (decorator.Forms == null)
                //     throw new NullReferenceException(ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(fieldNumber))
                //     throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                foreach (var form in decorator.Forms)
                {
                    // if (form.IsFieldPresent(fieldNumber))
                    // {
                        // if (formObject.MultipleIteration && formObject.OtherRows.Count > 0)
                        //     throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("unableToIdentifyFieldObject", CultureInfo.CurrentCulture), nameof(decorator));
                        return SetFieldValue(decorator, form.FormId, form.CurrentRow.RowId, fieldNumber, fieldValue);
                    // }
                }
                // throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
                return null;
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
                // if (decorator == null)
                //     throw new ArgumentNullException(nameof(decorator), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(formId))
                //     throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(rowId))
                //     throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (string.IsNullOrEmpty(fieldNumber))
                //     throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                // if (decorator.Forms == null)
                //     throw new NullReferenceException(ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
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
