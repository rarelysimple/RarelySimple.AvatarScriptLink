using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared
{
    public class GetErrorCode6Command : IRunScriptCommand
    {
        private readonly OptionObject2015 _optionObject;

        public GetErrorCode6Command(OptionObject2015 optionObject2015)
        {
            _optionObject = optionObject2015;
        }

        public OptionObject2015 Execute()
        {
            return _optionObject.ToReturnOptionObject(ErrorCode.OpenForm, "[PM]USER100");
        }
    }
}