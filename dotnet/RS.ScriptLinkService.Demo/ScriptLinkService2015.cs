using RarelySimple.AvatarScriptLink.Net;
using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Services;

namespace RS.ScriptLinkService.Demo
{
    public class ScriptLinkService2015 : IScriptLinkService2015
    {
        public string GetVersion()
        {
            return "0.1.0";
        }

        public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
        {
            var decorator = new OptionObjectDecorator(optionObject);
            // Do work
            return decorator.Return()
                .WithErrorCode(ErrorCode.Alert)
                .WithErrorMesg("Hello World!")
                .AsOptionObject2015();
        }
    }
}
