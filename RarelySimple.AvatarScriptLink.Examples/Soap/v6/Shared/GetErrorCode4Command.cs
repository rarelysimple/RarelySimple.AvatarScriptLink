using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared
{
    public class GetErrorCode4Command : IRunScriptCommand
    {
        private readonly IOptionObjectDecorator _optionObject;

        public GetErrorCode4Command(IOptionObjectDecorator optionObjectDecorator)
        {
            _optionObject = optionObjectDecorator;
        }

        public IOptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Confirm, "The code means the RunScript is prompting a confirmation.");
        }
    }
}