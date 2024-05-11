using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Sets all <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> to disabled.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <returns></returns>
        public static IOptionObject DisableAllFieldObjects(IOptionObject optionObject)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return DisableAllFieldObjects(optionObject, new List<string>());
        }
        /// <summary>
        /// Sets all <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> to disabled, except for the FieldNumbers specified in List.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="excludedFields"></param>
        /// <returns></returns>
        public static IOptionObject DisableAllFieldObjects(IOptionObject optionObject, List<string> excludedFields)
        {
            if (optionObject == null)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (optionObject.Forms.Count == 0)
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
            if (excludedFields == null)
                throw new ArgumentNullException(nameof(excludedFields), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            return DisableAllFieldObjectsByOptionObject(optionObject, excludedFields);
        }

        private static IOptionObject DisableAllFieldObjectsByOptionObject(IOptionObject optionObject, List<string> excludedFields)
        {
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                if (optionObject.Forms[i].CurrentRow != null)
                {
                    optionObject.Forms[i].CurrentRow = DisableAllFieldObjectsByRowObject(optionObject.Forms[i].CurrentRow, excludedFields);
                }
                for (int k = 0; k < optionObject.Forms[i].OtherRows.Count; k++)
                {
                    optionObject.Forms[i].OtherRows[k] = DisableAllFieldObjectsByRowObject(optionObject.Forms[i].OtherRows[k], excludedFields);
                }
            }
            return optionObject;
        }

        private static RowObject DisableAllFieldObjectsByRowObject(IRowObject rowObject, List<string> excludedFields)
        {
            for (int i = 0; i < rowObject.Fields.Count; i++)
            {
                if (!excludedFields.Contains(rowObject.Fields[i].FieldNumber))
                    rowObject.Fields[i].SetAsDisabled();
            }
            rowObject.RowAction = RowAction.Edit;
            return (RowObject) rowObject;
        }
    }
}
