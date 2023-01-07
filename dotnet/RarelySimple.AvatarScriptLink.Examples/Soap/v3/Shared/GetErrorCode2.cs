using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Soap.v3.Shared
{
    public static class GetErrorCode2
    {
        public static OptionObject RunScript(OptionObject optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Warning, "The code means the RunScript is providing a warning requiring a response from the user.");
        }

        public static OptionObject2 RunScript(OptionObject2 optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Warning, "The code means the RunScript is providing a warning requiring a response from the user.");
        }

        public static OptionObject2015 RunScript(OptionObject2015 optionObject)
        {
            return optionObject.ToReturnOptionObject(ErrorCode.Warning, "The code means the RunScript is providing a warning requiring a response from the user.");
        }
    }
}