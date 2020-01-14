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
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
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
                throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (optionObject.Forms.Count == 0)
                throw new NullReferenceException(ScriptLinkHelpers.GetLocalizedString("optionObjectMissingForms", CultureInfo.CurrentCulture));
            if (excludedFields == null)
                throw new ArgumentNullException(nameof(excludedFields), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            for (int i = 0; i < optionObject.Forms.Count; i++)
            {
                if (optionObject.Forms[i].CurrentRow != null)
                {
                    for (int j = 0; j < optionObject.Forms[i].CurrentRow.Fields.Count; j++)
                    {
                        if (!excludedFields.Contains(optionObject.Forms[i].CurrentRow.Fields[j].FieldNumber))
                            optionObject.Forms[i].CurrentRow.Fields[j].SetAsDisabled();
                    }
                    optionObject.Forms[i].CurrentRow.RowAction = RowAction.Edit;
                }
                for (int k = 0; k < optionObject.Forms[i].OtherRows.Count; k++)
                {
                    for (int l = 0; l < optionObject.Forms[i].OtherRows[k].Fields.Count; l++)
                    {
                        if (!excludedFields.Contains(optionObject.Forms[i].OtherRows[k].Fields[l].FieldNumber))
                            optionObject.Forms[i].OtherRows[k].Fields[l].SetAsDisabled();
                    }
                    optionObject.Forms[i].OtherRows[k].RowAction = RowAction.Edit;
                }
            }
            return optionObject;
        }
    }
}
