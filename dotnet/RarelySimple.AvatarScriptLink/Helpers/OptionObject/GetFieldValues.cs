using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns a list of FieldValues of a specified <see cref="IFieldObject"/> in the <see cref="IOptionObject"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static List<string> GetFieldValues(IOptionObject optionObject, string fieldNumber)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            var form = optionObject.Forms.Find(f => f.IsFieldPresent(fieldNumber));
            if (form != null)
            {
                return GetFieldValues(form, fieldNumber);
            }
            return new List<string>();
        }
        /// <summary>
        /// Returns a list of FieldValues of a specified <see cref="IFieldObject"/> in the <see cref="IFormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static List<string> GetFieldValues(IFormObject formObject, string fieldNumber)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            List<string> values = new List<string>();
            if (IsFieldPresent(formObject, fieldNumber))
            {
                values.Add(GetFieldValue(formObject.CurrentRow, fieldNumber));
                if (formObject.MultipleIteration)
                {
                    foreach (var row in formObject.OtherRows)
                    {
                        values.Add(GetFieldValue(row, fieldNumber));
                    }
                }
                return values;
            }
            return values;
        }
    }
}
