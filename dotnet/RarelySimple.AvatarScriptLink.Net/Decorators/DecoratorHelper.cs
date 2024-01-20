namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public abstract class DecoratorHelper
    {
        /// <summary>
        /// Returns whether a supplied RowAction value is valid.
        /// </summary>
        /// <param name="rowAction"></param>
        /// <returns></returns>
        public static bool IsValidRowAction(string rowAction)
        {
            if (rowAction == RowActions.Add ||
                rowAction == RowActions.Delete ||
                rowAction == RowActions.Edit ||
                string.IsNullOrEmpty(rowAction))    // same as == RowAction.None
                return true;
            return false;
        }
        /// <summary>
        /// Returns whether a supplied RowAction value is valid for return.
        /// </summary>
        /// <param name="rowAction"></param>
        /// <returns></returns>
        public static bool IsValidReturnRowAction(string rowAction)
        {
            if (rowAction == RowActions.Add ||
                rowAction == RowActions.Delete ||
                rowAction == RowActions.Edit)
                return true;
            return false;
        }
    }
}