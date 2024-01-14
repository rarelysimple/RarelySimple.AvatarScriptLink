using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Services;

namespace RS.ScriptLinkService.Demo
{
    public class ScriptLinkService2 : IScriptLinkService2
    {
        public string GetVersion()
        {
            return "0.1.0";
        }

        public OptionObject2 RunScript(OptionObject2 optionObject, string parameter)
        {
            return optionObject;
        }
    }
}
