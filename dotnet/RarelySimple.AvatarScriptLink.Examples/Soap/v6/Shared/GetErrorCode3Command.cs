using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class GetErrorCode3Command : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;

        public GetErrorCode3Command(IOptionObjectDecorator optionObjectDecorator)
        {
            _optionObject = optionObjectDecorator;
        }

        public IOptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Informational, "The code means the RunScript was successful, however is providing an alert or informational notice.");
        }
    }
}