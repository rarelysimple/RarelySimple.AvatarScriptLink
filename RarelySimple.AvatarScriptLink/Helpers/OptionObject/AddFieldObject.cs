using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Adds a <see cref="IFieldObject"/> to a <see cref="IRowObject"/>.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldObject"></param>
        /// <returns></returns>
        public static IRowObject AddFieldObject(IRowObject rowObject, IFieldObject fieldObject)
        {
            if (rowObject == null)
                throw new System.ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (fieldObject == null)
                throw new System.ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (rowObject.Fields.Contains((FieldObject)fieldObject))
                throw new System.ArgumentException(ScriptLinkHelpers.GetLocalizedString("fieldObjectAlreadyExists", CultureInfo.CurrentCulture), nameof(fieldObject));
            if (rowObject.Fields.Exists(f => f.FieldNumber == fieldObject.FieldNumber))
                throw new System.ArgumentException(ScriptLinkHelpers.GetLocalizedString("fieldNumberAlreadyExists", CultureInfo.CurrentCulture));
            rowObject.Fields.Add((FieldObject)fieldObject);
            return rowObject;
        }
        /// <summary>
        /// Adds a <see cref="IFieldObject"/> to a <see cref="IRowObject"/> using supplied FieldNumber and FieldValue.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static IRowObject AddFieldObject(IRowObject rowObject, string fieldNumber, string fieldValue)
        {
            if (rowObject == null)
                throw new System.ArgumentNullException(nameof(rowObject));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new System.ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            return AddFieldObject(rowObject, fieldNumber, fieldValue, false, false, false);
        }
        /// <summary>
        /// Adds a <see cref="IFieldObject"/> to a <see cref="IRowObject"/> using supplied FieldNumber and FieldValue and setting the Enabled, Locked, and Required values (e.g., Y or N).
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <param name="enabledValue"></param>
        /// <param name="lockedValue"></param>
        /// <param name="requiredValue"></param>
        /// <returns></returns>
        public static IRowObject AddFieldObject(IRowObject rowObject, string fieldNumber, string fieldValue, string enabledValue, string lockedValue, string requiredValue)
        {
            if (rowObject == null)
                throw new System.ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new System.ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            bool enabled = enabledValue == "1";
            bool locked = lockedValue == "1";
            bool required = requiredValue == "1";
            return AddFieldObject(rowObject, fieldNumber, fieldValue, enabled, locked, required);
        }
        /// <summary>
        /// Adds a <see cref="IFieldObject"/> to a <see cref="IRowObject"/> using supplied FieldNumber and FieldValue and setting the Enabled, Locked, and Required values.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <param name="enabled"></param>
        /// <param name="locked"></param>
        /// <param name="required"></param>
        /// <returns></returns>
        public static IRowObject AddFieldObject(IRowObject rowObject, string fieldNumber, string fieldValue, bool enabled, bool locked, bool required)
        {
            if (rowObject == null)
                throw new System.ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            if (string.IsNullOrEmpty(fieldNumber))
                throw new System.ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            FieldObject fieldObject = new FieldObject(fieldNumber, fieldValue, enabled, locked, required);
            return AddFieldObject(rowObject, fieldObject);
        }
    }
}
