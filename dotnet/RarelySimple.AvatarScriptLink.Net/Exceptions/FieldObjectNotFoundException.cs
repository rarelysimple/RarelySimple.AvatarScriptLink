using System;

namespace RarelySimple.AvatarScriptLink.Net.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a method call attempts to read or modify a FieldObject that does not exist.
    /// </summary>
    public class FieldObjectNotFoundException : Exception
    {
        public string FieldNumber { get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldObjectNotFoundException"> class.
        /// </summary>
        public FieldObjectNotFoundException() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldObjectNotFoundException"> class with a specified error message.
        /// </summary>
        /// <param name="message"></param>
        public FieldObjectNotFoundException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldObjectNotFoundException"> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public FieldObjectNotFoundException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldObjectNotFoundException"> class with a specified error message and the field number that could not be found.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="fieldNumber"></param>
        public FieldObjectNotFoundException(string message, string fieldNumber) : this(message) 
        { 
            FieldNumber = fieldNumber;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldObjectNotFoundException"> class with a specified error message, the field number that could not be found, and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="inner"></param>
        public FieldObjectNotFoundException(string message, string fieldNumber, Exception inner) : this(message, inner)
        {
            FieldNumber = fieldNumber;
        }

        // public override string StackTrace
        // {
        //     get {
        //         StringBuilder builder = new StringBuilder();
        //         builder.AppendLine(base.StackTrace);
        //         builder.AppendFormat("FieldNumber: {0}", FieldNumber);
        //         return builder.ToString();
        //     }
        // }
    }
}