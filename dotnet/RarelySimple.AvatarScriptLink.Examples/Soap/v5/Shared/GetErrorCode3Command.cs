using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared
{
    public class GetErrorCode3Command : IRunScriptCommand
    {
        private readonly OptionObject2015 _optionObject;

        public GetErrorCode3Command(OptionObject2015 optionObject2015)
        {
            _optionObject = optionObject2015;
        }

        public OptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.Informational, "The code means the RunScript was successful, however is providing an alert or informational notice.");
        }
    }
}