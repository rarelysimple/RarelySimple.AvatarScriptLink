namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// The selected ErrorCode informs myAvatar whether an error occurred, there is a message to display, a URL to open, or a form to open. 
    /// </summary>
    public static class ErrorCode
    {
        /// <summary>
        /// Returns no message.
        /// <para>This is the equivalent of <see cref="Success"/>.</para>
        /// </summary>
        public const int None = 0;
        /// <summary>
        /// Returns a success code.
        /// <para>This is the equivalent of <see cref="None"/>.</para>
        /// </summary>
        public const int Success = 0;
        /// <summary>
        /// Returns provided message with an Ok button.
        /// <para>Script processing will be stopped on the form.</para>
        /// </summary>
        public const int Error = 1;
        /// <summary>
        /// Returns provided message with Ok and Cancel buttons.
        /// <para>Script processing will be stopped on the form, if user selects Cancel.</para>
        /// <para>This is the equivalent of <see cref="Warning"/>.</para>
        /// </summary>
        public const int OkCancel = 2;
        /// <summary>
        /// Returns provided message with Ok and Cancel buttons.
        /// <para>Script processing will be stopped on the form, if user selects Cancel.</para>
        /// <para>This is the equivalent of <see cref="OkCancel"/>.</para>
        /// </summary>
        public const int Warning = 2;
        /// <summary>
        /// Returns provided message with an Ok button.
        /// <para>This is the equivalent of <see cref="Alert"/>.</para>
        /// </summary>
        public const int Informational = 3;
        /// <summary>
        /// Returns provided message with an Ok button.
        /// <para>This is the equivalent of <see cref="Informational"/>.</para>
        /// </summary>
        public const int Alert = 3;
        /// <summary>
        /// Returns provided message with Yes and No buttons.
        /// <para>Script processing will be stopped on the form, if user selects Cancel.</para>
        /// <para>This is the equivalent of <see cref="Confirm"/>.</para>
        /// </summary>
        public const int YesNo = 4;
        /// <summary>
        /// Returns provided message with Yes and No buttons.
        /// <para>Script processing will be stopped on the form, if user selects Cancel.</para>
        /// <para>This is the equivalent of <see cref="YesNo"/>.</para>
        /// </summary>
        public const int Confirm = 4;
        /// <summary>
        /// Opens provided Url in default web browser.
        /// <para>The URL to open must be placed in the ErrorMesg property.</para>
        /// </summary>
        public const int OpenUrl = 5;
        /// <summary>
        /// Returns a message with Ok and Cancel buttons.
        /// <para>Opens specified form(s) if OK selected. Can only be used at Form Load and FieldObject OnLostFocus events.</para>
        /// </summary>
        public const int OpenForm = 6;
    }
}
