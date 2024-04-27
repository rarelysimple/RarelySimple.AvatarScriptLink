using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns the next available RowId for an <see cref="IFormObject"/>.
        /// </summary>
        /// <param name="formObject"></param>
        /// <returns></returns>
        public static string GetNextAvailableRowId(IFormObject formObject)
        {
            if (formObject == null)
                throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            if (formObject.CurrentRow != null && !formObject.MultipleIteration)
                throw new ArgumentOutOfRangeException(ScriptLinkHelpers.GetLocalizedString("cannotAddAnotherRowObject", CultureInfo.CurrentCulture));
            int maximumNumberOfMultipleIterationRows = 9999;    // To be confirmed with Netsmart
            if (formObject.CurrentRow != null && formObject.OtherRows.Count + 1 >= maximumNumberOfMultipleIterationRows)
                throw new ArgumentOutOfRangeException(ScriptLinkHelpers.GetLocalizedString("cannotAddAnotherRowObject", CultureInfo.CurrentCulture));
            for (int i = 1; i <= maximumNumberOfMultipleIterationRows; i++)
            {
                string tempRowId = formObject.FormId + "||" + i.ToString(CultureInfo.InvariantCulture);
                if (formObject.CurrentRow == null)
                    return tempRowId;
                if (formObject.CurrentRow.RowId != tempRowId
                    && !formObject.OtherRows.Exists(r => r.RowId == tempRowId))
                    return tempRowId;
            }
            throw new ArgumentException(ScriptLinkHelpers.GetLocalizedString("couldNotDetermineNextRowId", CultureInfo.CurrentCulture));
        }
    }
}
