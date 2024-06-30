using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public interface IParameter
    {
        string ScriptName { get; }

        int Count();
        string GetString(int i);
        string[] ToArray();
        List<string> ToList();
        string ToString();
    }
}
