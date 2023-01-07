using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class GetErrorCode0Command : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;

        public GetErrorCode0Command(IOptionObjectDecorator optionObjectDecorator)
        {
            _optionObject = optionObjectDecorator;
        }

        public IOptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Success, "The code means the RunScript was successful.");
        }
    }
}