using System;

namespace RarelySimple.AvatarScriptLink.Net.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a method call attempts to read or modify a FormObject that does not exist.
    /// </summary>
    public class FormObjectNotFoundException : Exception
    {
        public string FormId { get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormObjectNotFoundException"> class.
        /// </summary>
        public FormObjectNotFoundException() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormObjectNotFoundException"> class with a specified error message.
        /// </summary>
        /// <param name="message"></param>
        public FormObjectNotFoundException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormObjectNotFoundException"> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public FormObjectNotFoundException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormObjectNotFoundException"> class with a specified error message and the field number that could not be found.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="formId"></param>
        public FormObjectNotFoundException(string message, string formId) : this(message) 
        { 
            FormId = formId;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormObjectNotFoundException"> class with a specified error message, the field number that could not be found, and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="formId"></param>
        /// <param name="inner"></param>
        public FormObjectNotFoundException(string message, string formId, Exception inner) : this(message, inner)
        {
            FormId = formId;
        }
    }
}