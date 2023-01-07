using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared
{
    public class GetErrorCode1Command : IRunScriptCommand
    {
        private readonly OptionObject2015 _optionObject;

        public GetErrorCode1Command(OptionObject2015 optionObject2015)
        {
            _optionObject = optionObject2015;
        }

        public OptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Error, "The code means the RunScript experienced an Error and to stop processing.");
        }
    }
}