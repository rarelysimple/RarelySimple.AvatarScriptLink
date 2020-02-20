using RarelySimple.AvatarScriptLink.Objects.Advanced;
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
                return _parameter != null ? _parameter.Split(_delimiter)[0] : "";
            }
        }

        public int Count()
        {
            return ParameterList().Count;
        }

        public string[] ParameterArray()
        {
            return _parameter != null ? _parameter.Split(_delimiter) : new string[1];
        }

        public List<string> ParameterList()
        {
            return _parameter != null ? _parameter.Split(_delimiter).ToList() : new List<string>();
        }

        public override string ToString()
        {
            return _parameter;
        }
    }
}
