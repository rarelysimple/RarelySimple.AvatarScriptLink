using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v3.Shared
{
    public static class GetErrorCode0
    {
        public static OptionObject RunScript(OptionObject optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Success, "The code means the RunScript was successful.");
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Success, "The code means the RunScript was successful.");
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Success, "The code means the RunScript was successful.");
        }
    }
}