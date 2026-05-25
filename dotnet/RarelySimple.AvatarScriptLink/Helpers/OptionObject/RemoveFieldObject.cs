using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Removes a <see cref="IFieldObject"/> from a <see cref="IRowObject"/>.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldObject"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="rowObject"/> or <paramref name="fieldObject"/> is null.</exception>
        /// <returns></returns>
        public static IRowObject RemoveFieldObject(IRowObject rowObject, IFieldObject fieldObject)
        {
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (fieldObject == null)
                throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            rowObject.Fields.Remove((FieldObject)fieldObject);
            return (RowObject)rowObject;
        }
        /// <summary>
        /// Removes a <see cref="IFieldObject"/> from a <see cref="IRowObject"/> by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="rowObject"/> is null, or when <paramref name="fieldNumber"/> is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown when no matching field exists for <paramref name="fieldNumber"/>.</exception>
        /// <returns></returns>
        public static IRowObject RemoveFieldObject(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            FieldObject fieldObject = rowObject.Fields.Find(f => f.FieldNumber == fieldNumber);
            if (fieldObject == null)
                throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("noFieldObjectsFoundByFieldNumber", CultureInfo.CurrentCulture) + fieldNumber, nameof(fieldNumber));
            return RemoveFieldObject(rowObject, fieldObject);
        }
    }
}
