using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Services;

namespace RS.ScriptLinkService.Demo
{
    public class ScriptLinkService : IScriptLinkService
    {
        public string GetVersion()
        {
            return "0.1.0";
        }

        public OptionObject RunScript(OptionObject optionObject, string parameter)
        {
            return optionObject;
        }
    }
}
