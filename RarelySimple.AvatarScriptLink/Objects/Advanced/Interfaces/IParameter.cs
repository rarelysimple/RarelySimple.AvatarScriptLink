using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public interface IParameter
    {
        string ScriptName { get; }

        int Count();
        string[] ParameterArray();
        List<string> ParameterList();
        string ToString();
    }
}
