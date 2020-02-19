using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class GetErrorCode1Command : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;

        public GetErrorCode1Command(IOptionObjectDecorator optionObjectDecorator)
        {
            _optionObject = optionObjectDecorator;
        }

        public IOptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Error, "The code means the RunScript experienced an Error and to stop processing.");
        }
    }
}