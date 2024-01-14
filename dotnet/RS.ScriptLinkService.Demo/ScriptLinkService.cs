using RarelySimple.AvatarScriptLink.Net;
using RarelySimple.AvatarScriptLink.Net.Decorators;
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
            var decorator = new OptionObjectDecorator(optionObject);
            // Do work
            return decorator.Return()
                .WithErrorCode(ErrorCode.Alert)
                .WithErrorMesg("Hello World!")
                .AsOptionObject();
        }
    }
}
