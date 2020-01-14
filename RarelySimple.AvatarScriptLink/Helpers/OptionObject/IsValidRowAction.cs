using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Helpers
{
    public static partial class OptionObjectHelpers
    {
        /// <summary>
        /// Returns whether a supplied RowAction value is valid.
        /// </summary>
        /// <param name="rowAction"></param>
        /// <returns></returns>
        public static bool IsValidRowAction(string rowAction)
        {
            if (rowAction == RowAction.Add ||
                rowAction == RowAction.Delete ||
                rowAction == RowAction.Edit ||
                string.IsNullOrEmpty(rowAction))    // same as == RowAction.None
                return true;
            return false;
        }
    }
}
