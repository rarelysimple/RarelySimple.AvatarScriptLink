using RarelySimple.AvatarScriptLink.Net;
using RarelySimple.AvatarScriptLink.Net.Decorators;
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
            var decorator = new OptionObject2Decorator(optionObject);
            // Do work
            return decorator.Return()
                .WithErrorCode(ErrorCode.Alert)
                .WithErrorMesg("Hello World!")
                .AsOptionObject2();
        }
    }
}
