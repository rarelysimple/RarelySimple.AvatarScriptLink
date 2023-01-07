using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents a myAvatar ScriptLink parameter.
    /// </summary>
    public class Parameter : IParameter
    {
        private readonly string _parameter;
        private readonly char _delimiter;

        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class with the parameter string.
        /// </summary>
        /// <param name="parameter"></param>
        public Parameter(string parameter)
        {
            _parameter = parameter;
            _delimiter = ',';
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class with the parameter string and a delimiter.
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="delimiter"></param>
        public Parameter(string parameter, char delimiter)
        {
            _parameter = parameter;
            _delimiter = delimiter;
        }
        /// <summary>
        /// Gets the first element in the <see cref="Parameter"/>.
        /// Used in most ScriptLink implementations as the Script Name.
        /// </summary>
        public string ScriptName
        {
            get
            {
                return GetString(0);
            }
        }
        /// <summary>
        /// Gets the number of elements contained in the <see cref="Parameter"/>.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return ToList().Count;
        }
        /// <summary>
        /// Gets the value of the specified parameter element as a string.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string GetString(int i)
        {
            try
            {
                return ToArray()[i];
            }
            catch (IndexOutOfRangeException)
            {
                return "";
            }
        }
        /// <summary>
        /// Creates an array from the delimited string.
        /// </summary>
        /// <returns></returns>
        public string[] ToArray()
        {
            return _parameter?.Split(_delimiter);
        }
        /// <summary>
        /// Creates a <see cref="List{T}"/> from the delimited parameter.
        /// </summary>
        /// <returns></returns>
        public List<string> ToList()
        {
            return ToArray().ToList();
        }
        /// <summary>
        /// Converts the value of this instance to the original string provided at construction.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _parameter;
        }
    }
}
