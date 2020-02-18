using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared
{
    public class GetErrorCode2Command : IRunScriptCommand
    {
        private readonly OptionObject2015 _optionObject;

        public GetErrorCode2Command(OptionObject2015 optionObject2015)
        {
            _optionObject = optionObject2015;
        }

        public OptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Warning, "The code means the RunScript is providing a warning requiring a response from the user.");
        }
    }
}