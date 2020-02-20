using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects
{
    public class Parameter : IParameter
    {
        private readonly string _parameter;
        private readonly char _delimiter;

        public Parameter(string parameter)
        {
            _parameter = parameter;
            _delimiter = ',';
        }

        public Parameter(string parameter, char delimiter)
        {
            _parameter = parameter;
            _delimiter = delimiter;
        }

        public string ScriptName
        {
            get
            {
                return GetString(0);
            }
        }

        public int Count()
        {
            return ToList().Count;
        }

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

        public string[] ToArray()
        {
            return _parameter?.Split(_delimiter);
        }

        public List<string> ToList()
        {
            return ToArray().ToList();
        }

        public override string ToString()
        {
            return _parameter;
        }
    }
}
