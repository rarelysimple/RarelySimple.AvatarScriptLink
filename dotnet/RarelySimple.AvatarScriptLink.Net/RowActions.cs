namespace RarelySimple.AvatarScriptLink.Net
{
    /// <summary>
    /// Represents a valid AvatarScriptLink <see cref="RowActions"/>.
    /// </summary>
    public static class RowActions
    {
        /// <summary>
        /// Instructs myAvatar to add this <see cref="RowObject"/>.
        /// </summary>
        public const string Add = "ADD";
        /// <summary>
        /// Instructs myAvatar to delete this <see cref="RowObject"/>.
        /// </summary>
        public const string Delete = "DELETE";
        /// <summary>
        /// Instructs myAvatar to edit this <see cref="RowObject"/>.
        /// </summary>
        public const string Edit = "EDIT";
        /// <summary>
        /// Instructs myAvatar to do nothing with this <see cref="RowObject"/>.
        /// </summary>
        public const string None = "";
    }
}
